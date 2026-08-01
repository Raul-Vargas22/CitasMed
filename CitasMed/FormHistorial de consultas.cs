using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CitasMed
{
    public partial class FormHistorial_de_consultas : Form
    {
        public FormHistorial_de_consultas()
        {
            InitializeComponent();

            ucMenuEmpleado1.SeleccionarHistorial();
            ucMenuEmpleado1.InicioClick += btnInicio_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;

            PanelRedondo(panel1);

            // Evento para mostrar diagnóstico y tratamiento
            dataGridView1.SelectionChanged -=
                dataGridView1_SelectionChanged;

            dataGridView1.SelectionChanged +=
                dataGridView1_SelectionChanged;
        }

        private void CargarHistorial()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            CONCAT_WS(
                                ' ',
                                p.nombre,
                                p.apellido_paterno,
                                p.apellido_materno
                            ) AS PACIENTE,

                            co.id_consulta AS CLAVE,

                            p.edad AS EDAD,

                            p.telefono AS TELÉFONO,

                            CONCAT_WS(
                                ' ',
                                m.nombre,
                                m.apellido_paterno,
                                m.apellido_materno
                            ) AS DOCTOR,

                            e.nombre AS ESPECIALIDAD,

                            co.diagnostico AS DIAGNOSTICO,

                            co.tratamiento AS TRATAMIENTO

                        FROM Consulta co

                        INNER JOIN Cita c
                            ON co.id_cita = c.id_cita

                        INNER JOIN Paciente p
                            ON c.id_paciente = p.id_paciente

                        INNER JOIN Medico m
                            ON c.id_medico = m.id_medico

                        INNER JOIN Especialidad e
                            ON m.id_especialidad =
                               e.id_especialidad

                        ORDER BY
                            c.fecha DESC,
                            c.hora DESC;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(
                            consulta,
                            conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = tabla;

                    // Tabla inmodificable
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.MultiSelect = false;

                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.EditMode =
                        DataGridViewEditMode.EditProgrammatically;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    // Estas columnas se usan internamente,
                    // pero no se muestran en la tabla
                    dataGridView1.Columns["DIAGNOSTICO"].Visible =
                        false;

                    dataGridView1.Columns["TRATAMIENTO"].Visible =
                        false;

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                        MostrarDatosSeleccionados();
                    }
                    else
                    {
                        txtDiagnostico.Clear();
                        txtTratamiento.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el historial:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosSeleccionados()
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                txtDiagnostico.Clear();
                txtTratamiento.Clear();
                return;
            }

            object diagnostico =
                dataGridView1.CurrentRow
                .Cells["DIAGNOSTICO"].Value;

            object tratamiento =
                dataGridView1.CurrentRow
                .Cells["TRATAMIENTO"].Value;

            txtDiagnostico.Text =
                diagnostico == DBNull.Value
                ? ""
                : Convert.ToString(diagnostico);

            txtTratamiento.Text =
                tratamiento == DBNull.Value
                ? ""
                : Convert.ToString(tratamiento);
        }

        private void dataGridView1_SelectionChanged(
            object sender,
            EventArgs e)
        {
            MostrarDatosSeleccionados();
        }

        private void PanelRedondo(Panel panel)
        {
            GraphicsPath ruta = new GraphicsPath();

            int radio = 20;

            ruta.StartFigure();

            ruta.AddArc(
                0,
                0,
                radio,
                radio,
                180,
                90);

            ruta.AddArc(
                panel.Width - radio,
                0,
                radio,
                radio,
                270,
                90);

            ruta.AddArc(
                panel.Width - radio,
                panel.Height - radio,
                radio,
                radio,
                0,
                90);

            ruta.AddArc(
                0,
                panel.Height - radio,
                radio,
                radio,
                90,
                90);

            ruta.CloseFigure();

            panel.Region = new Region(ruta);
        }

        private void FormHistorial_de_consultas_Load(
            object sender,
            EventArgs e)
        {
            txtDiagnostico.ReadOnly = true;
            txtTratamiento.ReadOnly = true;

            CargarHistorial();
        }

        private void btnInicio_Click(
            object sender,
            EventArgs e)
        {
            btnRegresar_Click(sender, e);
        }

        private void btnRegresar_Click(
            object sender,
            EventArgs e)
        {
            FormEmpleado empleado =
                new FormEmpleado();

            empleado.Show();
            this.Close();
        }

        private void lblNueva_Click(
            object sender,
            EventArgs e)
        {
            using (Registro_de_paciente registro =
                   new Registro_de_paciente())
            {
                registro.ShowDialog(this);
            }
        }

        private void lblProgramada_Click(
            object sender,
            EventArgs e)
        {
            FormCitas_programadas programadas =
                new FormCitas_programadas();

            programadas.Show();
            this.Hide();
        }

        private void lblHistorial_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Actualmente se encuentra en esta sección");
        }

        private void lblMedicos_Click(
            object sender,
            EventArgs e)
        {
            FormMédicos_y_Especialidades medicos =
                new FormMédicos_y_Especialidades();

            medicos.Show();
            this.Hide();
        }

        private void lblPacientes_Click(
            object sender,
            EventArgs e)
        {
            FormPaciente pacientes =
                new FormPaciente();

            pacientes.Show();
            this.Hide();
        }

        private void ucMenuEmpleado1_Load(
            object sender,
            EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            MostrarDatosSeleccionados();
        }

        private void panel7_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}