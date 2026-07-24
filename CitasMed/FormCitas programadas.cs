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
    public partial class FormCitas_programadas : Form
    {
        private DataTable tablaCitas = new DataTable();

        private void CargarCitas()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                SELECT
                    c.id_cita AS CLAVE,

                    CONCAT(
                        p.nombre, ' ',
                        p.apellido_paterno, ' ',
                        IFNULL(p.apellido_materno, '')
                    ) AS PACIENTE,

                    p.telefono AS TELEFONO,

                    e.nombre AS ESPECIALIDAD,

                    CONCAT(
                        m.nombre, ' ',
                        m.apellido_paterno, ' ',
                        IFNULL(m.apellido_materno, '')
                    ) AS DOCTOR,

                    DATE_FORMAT(c.fecha, '%d/%m/%Y') AS FECHA,
                    TIME_FORMAT(c.hora, '%H:%i') AS HORA,
                    c.motivo AS MOTIVO

                FROM Cita c

                INNER JOIN Paciente p
                    ON c.id_paciente = p.id_paciente

                INNER JOIN Medico m
                    ON c.id_medico = m.id_medico

                INNER JOIN Especialidad e
                    ON m.id_especialidad = e.id_especialidad

                WHERE c.estado IN ('Programada', 'Reagendada')

                ORDER BY c.fecha, c.hora;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    tablaCitas.Clear();
                    tablaCitas.Columns.Clear();

                    adaptador.Fill(tablaCitas);

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = tablaCitas;

                    // Evitar modificaciones directas
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.EditMode =
                        DataGridViewEditMode.EditProgrammatically;

                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.MultiSelect = false;
                    dataGridView1.RowHeadersVisible = false;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las citas:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public FormCitas_programadas()
        {
            InitializeComponent();
            ucMenuEmpleado1.SeleccionarProgramadas();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;
        }
        private void RedondearPanel(Panel panel, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radio, panel.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(boton.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(boton.Width - radio, boton.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, boton.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormEmpleado empleado = new FormEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void lblNueva_Click(object sender, EventArgs e)
        {
            Registro_de_paciente registro = new Registro_de_paciente();
            registro.Show();
            this.Hide();
        }

        private void lblProgramada_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente se encuentra en esta sección");
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial_de_consultas historial = new FormHistorial_de_consultas();
            historial.Show();
            this.Hide();
        }

        private void lblMedicos_Click(object sender, EventArgs e)
        {
            FormMédicos_y_Especialidades medicos = new FormMédicos_y_Especialidades();
            medicos.Show();
            this.Hide();
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
            this.Hide();
        }

        private void FormCitas_programadas_Load(object sender, EventArgs e)
        {


            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;


            RedondearPanel(panel7, 20);

            RedondearBoton(button2, 20);
            RedondearBoton(button3, 20);

            CargarCitas();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = textBox1.Text
                .Trim()
                .Replace("'", "''");

            tablaCitas.DefaultView.RowFilter =
                "PACIENTE LIKE '%" + texto + "%' OR " +
                "DOCTOR LIKE '%" + texto + "%' OR " +
                "ESPECIALIDAD LIKE '%" + texto + "%' OR " +
                "MOTIVO LIKE '%" + texto + "%'";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Selecciona una cita para eliminar.");
                return;
            }

            int idCita = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["CLAVE"].Value);

            string paciente = Convert.ToString(
                dataGridView1.CurrentRow.Cells["PACIENTE"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar la cita de " +
                paciente + "?",
                "Eliminar cita",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                DELETE FROM Cita
                WHERE id_cita = @idCita;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idCita", idCita);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Cita eliminada correctamente.");

                CargarCitas();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "No se puede eliminar porque esta cita ya tiene una consulta registrada.");
                }
                else
                {
                    MessageBox.Show(
                        "Error al eliminar la cita:\n" +
                        ex.Message);
                }
            }
        }
    }
}