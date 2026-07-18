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
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                      "Actualmente se encuentra en esta seccion",
                      "ATENCION",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
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
                                telefono AS TELEFONO,
                                calle AS CALLE,
                                colonia AS COLONIA,
                                municipio AS MUNICIPIO,
                                entidad AS ENTIDAD,
                                enfermedad_cronica AS 'ENFERMEDAD CRONICA'
                                FROM Paciente";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvPacientes.Columns.Clear();
                    dgvPacientes.AutoGenerateColumns = true;
                    dgvPacientes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPaciente_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormAdministrador admin = new FormAdministrador();
            admin.Show();
            this.Hide();
        }

    }
}
