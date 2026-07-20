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
    public partial class Registro_de_paciente : Form
    {
        public Registro_de_paciente()
        {
            InitializeComponent();
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


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"INSERT INTO Paciente
                                (curp, nombre, apellido_paterno, apellido_materno, genero, telefono, correo, calle, colonia, municipio, entidad, enfermedad_cronica, id_especialidad_solicitada)
                                VALUES
                                (@curp, @nombre, @apellido_paterno, @apellido_materno, @genero, @telefono, @correo, @calle, @colonia, @municipio, @entidad, @enfermedad_cronica, @id_especialidad)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue("@curp", txtCurp.Text);
                    comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@apellido_paterno", txtApellidoPaterno.Text);
                    comando.Parameters.AddWithValue("@apellido_materno", txtApellidoMaterno.Text);
                    comando.Parameters.AddWithValue("@genero", cmbGenero.Text);
                    comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    comando.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    comando.Parameters.AddWithValue("@calle", txtCalle.Text);
                    comando.Parameters.AddWithValue("@colonia", txtColonia.Text);
                    comando.Parameters.AddWithValue("@municipio", txtMunicipio.Text);
                    comando.Parameters.AddWithValue("@entidad", "Hidalgo");
                    comando.Parameters.AddWithValue("@enfermedad_cronica", txtEnfermedadCronica.Text);
                    comando.Parameters.AddWithValue("@id_especialidad", cmbEspecialidad.SelectedValue);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Paciente registrado correctamente.");

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar paciente: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtCurp.Clear();
            txtCalle.Clear();
            txtColonia.Clear();
            txtMunicipio.Clear();
            txtEnfermedadCronica.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void btnMenu_empleado_Click_1(object sender, EventArgs e)
        {
            FormEmpleado empleado = new FormEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void CargarEspecialidades()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "SELECT id_especialidad, nombre FROM Especialidad";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    cmbEspecialidad.DataSource = tabla;
                    cmbEspecialidad.DisplayMember = "nombre";
                    cmbEspecialidad.ValueMember = "id_especialidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message);
            }
        }
        

        private void Registro_de_paciente_Load(object sender, EventArgs e)
        {
            RedondearPanel(panel1, 20);
            RedondearPanel(panel2, 20);
            RedondearPanel(panel3, 20);
            RedondearPanel(panel4, 20);
            RedondearPanel(panel5, 20);
            RedondearPanel(panel6, 20);
            RedondearPanel(panel7, 20);
            RedondearPanel(panel8, 20);
            RedondearPanel(panel9, 20);
            RedondearPanel(panel10, 20);
            RedondearPanel(panel11, 20);
            RedondearPanel(panel12, 20);

            if (cmbGenero.Items.Count == 0)
            {
                cmbGenero.Items.Add("Masculino");
                cmbGenero.Items.Add("Femenino");
                cmbGenero.Items.Add("Otro");
            }

            CargarEspecialidades();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
