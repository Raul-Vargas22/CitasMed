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
        private ZoomFormulario zoomFormulario;


        public Registro_de_paciente()
        {
            InitializeComponent();
            GuardarColores(this);
            zoomFormulario = new ZoomFormulario(this);

        }


        public Registro_de_paciente(int idPaciente)
        {
            InitializeComponent();

            modoEdicion = true;
            idPacienteEditar = idPaciente;

            ConfigurarAccesibilidadVoz();
        }

        private void ConfigurarAccesibilidadVoz()
        {
            txtCurp.Enter += (s, e) => AsistenteVoz.Decir("CURP");
            txtNombre.Enter += (s, e) => AsistenteVoz.Decir("Nombre");
            txtApellidoPaterno.Enter += (s, e) => AsistenteVoz.Decir("Apellido paterno");
            txtApellidoMaterno.Enter += (s, e) => AsistenteVoz.Decir("Apellido materno");
            cmbGenero.Enter += (s, e) => AsistenteVoz.Decir("Género");
            numEdad.Enter += (s, e) => AsistenteVoz.Decir("Edad");
            txtTelefono.Enter += (s, e) => AsistenteVoz.Decir("Teléfono");
            txtCorreo.Enter += (s, e) => AsistenteVoz.Decir("Correo electrónico");
            txtCalle.Enter += (s, e) => AsistenteVoz.Decir("Calle");
            txtColonia.Enter += (s, e) => AsistenteVoz.Decir("Colonia");
            txtMunicipio.Enter += (s, e) => AsistenteVoz.Decir("Municipio");
            txtEnfermedadCronica.Enter += (s, e) => AsistenteVoz.Decir("Enfermedad crónica");
            cmbEspecialidad.Enter += (s, e) => AsistenteVoz.Decir("Especialidad");
            button1.Enter += (s, e) => AsistenteVoz.Decir(
                modoEdicion ? "Botón guardar cambios" : "Botón registrar");
            btnMenu_empleado.Enter += (s, e) => AsistenteVoz.Decir("Botón regresar al menú");

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AsistenteVoz.Decir(
                        modoEdicion
                            ? "Formulario de edición de paciente. Modifique los campos necesarios y presione guardar cambios."
                            : "Formulario de registro de paciente. Complete todos los campos y presione registrar.");
                }
            };
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

        private void dtFecha_cita_ValueChanged(object sender, EventArgs e)
        {
            dtFecha_cita.MinDate = DateTime.Today;
            dtFecha_cita.Value = DateTime.Today;
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
                            edad = @edad,
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
                            (
                                curp,
                                nombre,
                                apellido_paterno,
                                apellido_materno,
                                genero,
                                edad,
                                telefono,
                                correo,
                                calle,
                                colonia,
                                municipio,
                                entidad,
                                enfermedad_cronica
                            )
                            VALUES
                            (
                                @curp,
                                @nombre,
                                @apellido_paterno,
                                @apellido_materno,
                                @genero,
                                @edad,
                                @telefono,
                                @correo,
                                @calle,
                                @colonia,
                                @municipio,
                                @entidad,
                                @enfermedad_cronica
                            )";
                    }

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@curp", txtCurp.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@nombre", txtNombre.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellido_paterno",
                            txtApellidoPaterno.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellido_materno",
                            txtApellidoMaterno.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@genero", cmbGenero.Text);

                        comando.Parameters.AddWithValue(
                            "@edad", Convert.ToInt32(numEdad.Value));

                        comando.Parameters.AddWithValue(
                            "@telefono", txtTelefono.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@correo", txtCorreo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@calle", txtCalle.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@colonia", txtColonia.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@municipio", txtMunicipio.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@entidad", "Hidalgo");

                        comando.Parameters.AddWithValue(
                            "@enfermedad_cronica",
                            txtEnfermedadCronica.Text.Trim());

                        if (modoEdicion)
                        {
                            comando.Parameters.AddWithValue(
                                "@idPaciente", idPacienteEditar);
                        }

                        comando.ExecuteNonQuery();
                        int idPaciente = 0;

                        if (!modoEdicion)
                        {
                            idPaciente = Convert.ToInt32(comando.LastInsertedId);
                        }
                        else
                        {
                            idPaciente = idPacienteEditar;
                        }
                    }
                }

                if (modoEdicion)
                {
                    AsistenteVoz.Decir("Paciente actualizado correctamente.");
                    MessageBox.Show("Paciente actualizado correctamente.");

                    this.Close();
                }
                else
                {
                    AsistenteVoz.Decir("Paciente registrado correctamente.");
                    MessageBox.Show("Paciente registrado correctamente.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                AsistenteVoz.Decir("Error al guardar el paciente.");
                MessageBox.Show("Error al guardar paciente: " + ex.Message);
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

            numEdad.Value = numEdad.Minimum;
        }

        private void btnMenu_empleado_Click_1(object sender, EventArgs e)
        {
            Sesion.AbrirFormularioSegunRol();
            this.Close();
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
                AsistenteVoz.Decir("Editando datos del paciente.");
            }
            else
            {
                button1.Text = "REGISTRAR";
                AsistenteVoz.Decir("Formulario de registro de nuevo paciente.");
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
                                edad,
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
                        comando.Parameters.AddWithValue(
                            "@idPaciente", idPacienteEditar);

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

                                if (lector["edad"] != DBNull.Value)
                                {
                                    numEdad.Value =
                                        Convert.ToDecimal(lector["edad"]);
                                }

                                txtTelefono.Text =
                                    Convert.ToString(lector["telefono"]);

                                txtCorreo.Text =
                                    Convert.ToString(lector["correo"]);

                                txtCalle.Text =
                                    Convert.ToString(lector["calle"]);

                                txtColonia.Text =
                                    Convert.ToString(lector["colonia"]);

                                txtMunicipio.Text =
                                    Convert.ToString(lector["municipio"]);

                                txtEnfermedadCronica.Text =
                                    Convert.ToString(
                                        lector["enfermedad_cronica"]);
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el paciente.");

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
                MessageBox.Show("Error al cargar el paciente: " + ex.Message);
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

        private void txtHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnZoomMas_Click(object sender, EventArgs e)
        {
            zoomFormulario.ZoomMas();

        }

        private void btnZoomMenos_Click(object sender, EventArgs e)
        {
            zoomFormulario.ZoomMenos();

        }
        private bool altoContraste = false;
        private Dictionary<Control, Color> coloresFondo = new Dictionary<Control, Color>();
        private Dictionary<Control, Color> coloresTexto = new Dictionary<Control, Color>();

        private void GuardarColores(Control control)
        {
            coloresFondo[control] = control.BackColor;
            coloresTexto[control] = control.ForeColor;

            foreach (Control c in control.Controls)
            {
                GuardarColores(c);
            }
        }
        private void CambiarContraste(Control control)
        {
            if (altoContraste)
            {
                control.BackColor = Color.Black;
                control.ForeColor = Color.Yellow;

                if (control is Button)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.Yellow;
                }

                if (control is TextBox)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }

                if (control is ComboBox)
                {
                    control.BackColor = Color.Black;
                    control.ForeColor = Color.White;
                }

                if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.Black;
                    dgv.GridColor = Color.Yellow;
                    dgv.DefaultCellStyle.BackColor = Color.Black;
                    dgv.DefaultCellStyle.ForeColor = Color.Yellow;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
                    dgv.EnableHeadersVisualStyles = false;
                }
            }
            else
            {
                control.BackColor = coloresFondo[control];
                control.ForeColor = coloresTexto[control];

                if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = coloresFondo[control];
                    dgv.GridColor = Color.Gray;
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                    dgv.EnableHeadersVisualStyles = false;
                }
            }

            foreach (Control c in control.Controls)
            {
                CambiarContraste(c);
            }
        }

        private void btnContraste_Click(object sender, EventArgs e)
        {
            altoContraste = !altoContraste;

            CambiarContraste(this);

            if (altoContraste)
                AsistenteVoz.Decir("Modo de alto contraste activado.");
            else
                AsistenteVoz.Decir("Modo de alto contraste desactivado.");

        }
    }
}