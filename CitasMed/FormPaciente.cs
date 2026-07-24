using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {

            InitializeComponent();

            ucMenuEmpleado1.SeleccionarPacientes();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                      "Actualmente se encuentra en esta seccion");
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void lblNueva_Click(object sender, EventArgs e)
        {
            Registro_de_paciente registro = new Registro_de_paciente();
            registro.Show();
            this.Hide();
        }

        private void lblProgramada_Click(object sender, EventArgs e)
        {
            FormCitas_programadas programadas = new FormCitas_programadas();
            programadas.Show();
            this.Hide();
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial_de_consultas historial = new FormHistorial_de_consultas();
            historial.Show();
            this.Hide();
        }

        private void lblMedicos_Click(object sender, EventArgs e)
        {
            FormMédicos_y_Especialidades Medicos_especialidades = new FormMédicos_y_Especialidades();
            Medicos_especialidades.Show();
            this.Hide();
        }

        private void CargarPacientes()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"SELECT 
                        id_paciente AS CLAVE,
                        curp AS CURP,
                        nombre AS NOMBRE,
                        apellido_paterno AS 'APELLIDO PATERNO',
                        apellido_materno AS 'APELLIDO MATERNO',
                        genero AS GENERO,
                        edad AS EDAD,
                        telefono AS TELEFONO,
                        correo AS CORREO,
                        calle AS CALLE,
                        colonia AS COLONIA,
                        municipio AS MUNICIPIO,
                        entidad AS ENTIDAD,
                        enfermedad_cronica AS 'ENFERMEDAD CRONICA'
                        FROM Paciente
                        ORDER BY id_paciente;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvPacientes.DataSource = null;
                    dgvPacientes.Columns.Clear();
                    dgvPacientes.AutoGenerateColumns = true;
                    dgvPacientes.DataSource = tabla;

                    // Tabla completamente inmodificable
                    dgvPacientes.ReadOnly = true;
                    dgvPacientes.AllowUserToAddRows = false;
                    dgvPacientes.AllowUserToDeleteRows = false;
                    dgvPacientes.EditMode =
                        DataGridViewEditMode.EditProgrammatically;

                    dgvPacientes.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dgvPacientes.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar pacientes: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormEmpleado empleado = new FormEmpleado();
            empleado.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null ||
                dgvPacientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Selecciona un paciente para editar.");
                return;
            }

            int idPaciente = Convert.ToInt32(
                dgvPacientes.CurrentRow.Cells["CLAVE"].Value);

            using (Registro_de_paciente formulario =
                   new Registro_de_paciente(idPaciente))
            {
                formulario.ShowDialog();
            }

            CargarPacientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dgvPacientes.CurrentRow == null ||
                dgvPacientes.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un paciente.");
                return;
            }

            int idPaciente = Convert.ToInt32(
                dgvPacientes.CurrentRow.Cells[0].Value);

            string nombre = Convert.ToString(
                dgvPacientes.CurrentRow.Cells[2].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar al paciente " +
                nombre + "?",
                "Eliminar paciente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

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

                    string consulta = @"DELETE FROM Paciente
                                WHERE id_paciente = @idPaciente";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idPaciente", idPaciente);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Paciente eliminado correctamente.");
                CargarPacientes();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "No se puede eliminar porque el paciente tiene citas registradas.");
                }
                else
                {
                    MessageBox.Show(
                        "Error al eliminar: " + ex.Message);
                }
            }
        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }
    }
}
