using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class FormMédicos_y_Especialidades : Form
    {
        public FormMédicos_y_Especialidades()
        {
            InitializeComponent();

            ucMenuEmpleado1.SeleccionarMedicos();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;

            PanelRedondo(panel1);

            CargarMedicos();

            ConfigurarAccesibilidadVoz();
        }
        private void ConfigurarAccesibilidadVoz()
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AsistenteVoz.Decir(
                        $"Pantalla de médicos y especialidades. {dataGridView1.Rows.Count} médicos registrados. " +
                        "Use las flechas para navegar la lista.");
                }
            };
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;

            string nombre = Convert.ToString(dataGridView1.CurrentRow.Cells["NOMBRE"].Value);
            string apellido = Convert.ToString(dataGridView1.CurrentRow.Cells["APELLIDO PATERNO"].Value);
            string especialidad = Convert.ToString(dataGridView1.CurrentRow.Cells["ESPECIALIDAD"].Value);

            AsistenteVoz.Decir($"Doctor {nombre} {apellido}, especialidad {especialidad}");
        }
        private void CargarMedicos()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                SELECT
                    m.nombre AS NOMBRE,
                    m.apellido_paterno AS 'APELLIDO PATERNO',
                    m.apellido_materno AS 'APELLIDO MATERNO',
                    e.nombre AS ESPECIALIDAD,
                    m.cedula AS CÉDULA
                FROM Medico m
                LEFT JOIN Especialidad e
                    ON m.id_especialidad = e.id_especialidad
                ORDER BY m.nombre;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = tabla;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.EditMode =
                        DataGridViewEditMode.EditProgrammatically;

                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.MultiSelect = false;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                AsistenteVoz.Decir("Error al cargar los médicos.");
                MessageBox.Show(
                    "Error al cargar los médicos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void PanelRedondo(Panel panel)
        {
            GraphicsPath ruta = new GraphicsPath();
            int radio = 20;
            ruta.StartFigure();
            ruta.AddArc(0, 0, radio, radio, 180, 90);
            ruta.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            ruta.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            ruta.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            ruta.CloseFigure();
            panel.Region = new Region(ruta);
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Regresando al menú principal.");
            FormEmpleado empleado = new FormEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void FormMédicos_y_Especialidades_Load(object sender, EventArgs e)
        {
            AsistenteVoz.Decir($"Pantalla de médicos y especialidades. {dataGridView1.Rows.Count} médicos registrados.");
        }
        private void lblNueva_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Nueva cita");
            using (Registro_de_paciente registro =
                   new Registro_de_paciente())
            {
                registro.ShowDialog(this);
            }
        }

        private void lblProgramada_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Citas programadas");
            FormCitas_programadas programadas = new FormCitas_programadas();
            programadas.Show();
            this.Hide();
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Historial de consultas");
            FormHistorial_de_consultas historial = new FormHistorial_de_consultas();
            historial.Show();
            this.Hide();
        }

        private void lblMedicos_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Actualmente se encuentra en esta sección");
            MessageBox.Show("Actualmente se encuentra en esta sección");
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Pacientes");
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
            this.Hide();
        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
