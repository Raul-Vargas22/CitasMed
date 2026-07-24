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
        private bool modoEdicion = false;
        private int idPacienteEditar = 0;

        public Registro_de_paciente()
        {
            InitializeComponent();
        }

        public Registro_de_paciente(int idPaciente)
        {
            InitializeComponent();

            modoEdicion = true;
            idPacienteEditar = idPaciente;
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
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta;

                    if (modoEdicion)
                    {
                        consulta = @"UPDATE Paciente SET
                            curp = @curp,
                            nombre = @nombre,
                            apellido_paterno = @apellido_paterno,
                            apellido_materno = @apellido_materno,
                            genero = @genero,
                            telefono = @telefono,
                            correo = @correo,
                            calle = @calle,
                            colonia = @colonia,
                            municipio = @municipio,
                            entidad = @entidad,
                            enfermedad_cronica = @enfermedad_cronica
                            WHERE id_paciente = @idPaciente";
                    }
                    else
                    {
                        consulta = @"INSERT INTO Paciente
                            (curp,
                             nombre,
                             apellido_paterno,
                             apellido_materno,
                             genero,
                             telefono,
                             correo,
                             calle,
                             colonia,
                             municipio,
                             entidad,
                             enfermedad_cronica)
                            VALUES
                            (@curp,
                             @nombre,
                             @apellido_paterno,
                             @apellido_materno,
                             @genero,
                             @telefono,
                             @correo,
                             @calle,
                             @colonia,
                             @municipio,
                             @entidad,
                             @enfermedad_cronica)";
                    }

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@curp", txtCurp.Text);

                        comando.Parameters.AddWithValue(
                            "@nombre", txtNombre.Text);

                        comando.Parameters.AddWithValue(
                            "@apellido_paterno",
                            txtApellidoPaterno.Text);

                        comando.Parameters.AddWithValue(
                            "@apellido_materno",
                            txtApellidoMaterno.Text);

                        comando.Parameters.AddWithValue(
                            "@genero", cmbGenero.Text);

                        comando.Parameters.AddWithValue(
                            "@telefono", txtTelefono.Text);

                        comando.Parameters.AddWithValue(
                            "@correo", txtCorreo.Text);

                        comando.Parameters.AddWithValue(
                            "@calle", txtCalle.Text);

                        comando.Parameters.AddWithValue(
                            "@colonia", txtColonia.Text);

                        comando.Parameters.AddWithValue(
                            "@municipio", txtMunicipio.Text);

                        comando.Parameters.AddWithValue(
                            "@entidad", "Hidalgo");

                        comando.Parameters.AddWithValue(
                            "@enfermedad_cronica",
                            txtEnfermedadCronica.Text);

                        if (modoEdicion)
                        {
                            comando.Parameters.AddWithValue(
                                "@idPaciente", idPacienteEditar);
                        }

                        comando.ExecuteNonQuery();
                    }
                }

                if (modoEdicion)
                {
                    MessageBox.Show(
                        "Paciente actualizado correctamente.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Paciente registrado correctamente.");

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar paciente: " + ex.Message);
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

                    string consulta = @"
                        SELECT id_especialidad, nombre
                        FROM Especialidad
                        ORDER BY nombre;";

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

            if (modoEdicion)
            {
                button1.Text = "GUARDAR CAMBIOS";
                this.Text = "Editar paciente";

                CargarDatosPaciente();
            }
            else
            {
                button1.Text = "REGISTRAR";
            }
        }

        private void CargarDatosPaciente()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"SELECT
                                curp,
                                nombre,
                                apellido_paterno,
                                apellido_materno,
                                genero,
                                telefono,
                                correo,
                                calle,
                                colonia,
                                municipio,
                                entidad,
                                enfermedad_cronica
                                FROM Paciente
                                WHERE id_paciente = @idPaciente";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {

                        using (MySqlDataReader lector =
                               comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtCurp.Text = Convert.ToString(lector["curp"]);

                                txtNombre.Text = Convert.ToString(lector["nombre"]);

                                numEdad.Value = Convert.ToDecimal(lector["edad"]);

                                txtApellidoPaterno.Text = Convert.ToString(lector["apellido_paterno"]);

                                txtApellidoMaterno.Text = Convert.ToString(lector["apellido_materno"]);

                                cmbGenero.Text = Convert.ToString(lector["genero"]);

                                txtTelefono.Text = Convert.ToString(lector["telefono"]);

                                txtCorreo.Text = Convert.ToString(lector["correo"]);

                                txtCalle.Text = Convert.ToString(lector["calle"]);

                                txtColonia.Text = Convert.ToString(lector["colonia"]);

                                txtMunicipio.Text = Convert.ToString(lector["municipio"]);

                                txtEnfermedadCronica.Text = Convert.ToString(lector["enfermedad_cronica"]);

                                dtFecha_cita.Value = Convert.ToDateTime(lector["Fecha de la cita"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el paciente: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnfermedadCronica_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
