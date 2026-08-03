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

namespace CitasMed
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();

            button3.Enabled = true;
            button3.Visible = true;
            button3.BringToFront();

            button3.Click -= button3_Click;
            button3.Click += button3_Click;

            ucMenuEmpleado1.SeleccionarPacientes();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;

            ConfigurarAccesibilidadVoz();
        }
        private void ConfigurarAccesibilidadVoz()
        {
            // Botones de acción
            button2.Enter += (s, e) => AsistenteVoz.Decir("Botón editar paciente");
            button3.Enter += (s, e) => AsistenteVoz.Decir("Botón eliminar paciente");

            // Lee el paciente seleccionado al cambiar de fila con teclado o mouse
            dgvPacientes.SelectionChanged += dgvPacientes_SelectionChanged;

            // Repetir la pantalla completa con F1
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AsistenteVoz.Decir(
                        $"Pantalla de pacientes. {dgvPacientes.Rows.Count} pacientes registrados. " +
                        "Use las flechas para navegar la tabla, o el menú para ir a otras secciones.");
                }
            };
        }
        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null || dgvPacientes.CurrentRow.IsNewRow)
                return;

            string nombre = Convert.ToString(dgvPacientes.CurrentRow.Cells["NOMBRE"].Value);
            string apellido = Convert.ToString(dgvPacientes.CurrentRow.Cells["APELLIDO PATERNO"].Value);
            string edad = Convert.ToString(dgvPacientes.CurrentRow.Cells["EDAD"].Value);

            AsistenteVoz.Decir($"Paciente seleccionado: {nombre} {apellido}, {edad} años");
        }


        private void lblPacientes_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Actualmente se encuentra en esta sección");
            MessageBox.Show("Actualmente se encuentra en esta seccion");
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();

            if (Sesion.perfil == "Doctor")
            {
                button2.Visible = false;   // Editar
                button3.Visible = false;   // Eliminar
                label10.Text = "DOCTOR";
            }
            else
            {
                button2.Visible = true;
                button3.Visible = true;
                label10.Text = "EMPLEADO";
            }
            AsistenteVoz.Decir($"Pantalla de pacientes. {dgvPacientes.Rows.Count} pacientes registrados.");
        }

        private void lblNueva_Click(object sender, EventArgs e)
        {
            using (Registro_de_paciente registro =
                   new Registro_de_paciente())
            {
                registro.ShowDialog(this);
            }
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
                    dgvPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            
            Sesion.AbrirFormularioSegunRol();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al botón Editar");

            if (dgvPacientes.CurrentRow == null || dgvPacientes.CurrentRow.IsNewRow)
            {
                AsistenteVoz.Decir("Selecciona un paciente para editar.");
                MessageBox.Show( "Selecciona un paciente para editar.");
                return;
            }

            int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["CLAVE"].Value);
            AsistenteVoz.Decir("Abriendo formulario de edición.");


            Registro_de_paciente formulario = new Registro_de_paciente(idPaciente);
            formulario.ShowDialog();

            CargarPacientes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null || dgvPacientes.CurrentRow.IsNewRow)
            {
                AsistenteVoz.Decir("Selecciona un paciente.");
                MessageBox.Show("Selecciona un paciente.");
                return;
            }

            int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells[0].Value);
            string nombre = Convert.ToString(dgvPacientes.CurrentRow.Cells[2].Value);
            AsistenteVoz.Decir($"¿Confirma eliminar al paciente {nombre}?");

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar al paciente " + nombre + "?",
                "Eliminar paciente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                AsistenteVoz.Decir("Eliminación cancelada.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"DELETE FROM Paciente WHERE id_paciente = @idPaciente";

                    using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idPaciente", idPaciente);
                        comando.ExecuteNonQuery();
                    }
                }
                AsistenteVoz.Decir("Paciente eliminado correctamente.");
                MessageBox.Show("Paciente eliminado correctamente.");
                CargarPacientes();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    AsistenteVoz.Decir("No se puede eliminar porque el paciente tiene citas registradas.");
                    MessageBox.Show("No se puede eliminar porque el paciente tiene citas registradas.");
                }
                else
                {
                    AsistenteVoz.Decir("Error al eliminar el paciente.");
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}