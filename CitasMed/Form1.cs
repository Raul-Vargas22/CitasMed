using System;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream
        private const string CONTRASENA = "faul";

=======
>>>>>>> Stashed changes
        public Form1()
        {
            InitializeComponent();

            btnVerPassword.Click -= btnVerPassword_Click;
            btnVerPassword.Click += btnVerPassword_Click;

            Button botonIniciar = BuscarBotonIniciar(this);

            if (botonIniciar != null)
            {
                botonIniciar.Click -= btnIniciarSesion_Click;
                botonIniciar.Click -= button1_Click;
                botonIniciar.Click += btnIniciarSesion_Click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepararRol("Administrador");
        }

        private void PrepararRol(string rol)
        {
            tntTitulo.TextAlign = ContentAlignment.MiddleCenter;
            tntTitulo.Text = rol;

            lblPassword.Text = "Ingrese la contraseña";
            lblPassword.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = false;
            textContrasena.PasswordChar = '●';

            textContrasena.Clear();
            textContrasena.Focus();
        }

        private void lblAdministrador_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            PrepararRol("Administrador");
        }

        private void lblDoctor_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            PrepararRol("Doctor");
        }

        private void label4_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            PrepararRol("Empleado");
        }

<<<<<<< Updated upstream
        private void btnIniciarSesion_Click(
            object sender,
            EventArgs e)
        {
            string datoIngresado = textContrasena.Text.Trim();
            string rolSeleccionado = tntTitulo.Text.Trim();

            if (datoIngresado == "")
=======
        private bool ValidarCredenciales(string rol, string usuario, string contrasena)
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "";

                    if (rol == "Administrador")
                    {
                        consulta = @"SELECT COUNT(*)
                             FROM Administrador
                             WHERE usuario = @usuario
                             AND contrasena = @contrasena";
                    }
                    else if (rol == "Doctor")
                    {
                        consulta = @"SELECT COUNT(*)
                             FROM Medico
                             WHERE usuario = @usuario
                             AND contrasena = @contrasena";
                    }
                    else if (rol == "Empleado")
                    {
                        consulta = @"SELECT COUNT(*)
                             FROM Empleado
                             WHERE usuario = @usuario
                             AND contrasena = @contrasena";
                    }

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@usuario", usuario);

                        comando.Parameters.AddWithValue(
                            "@contrasena", contrasena);

                        int cantidad = Convert.ToInt32(
                            comando.ExecuteScalar());

                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al conectar con la base de datos: " +
                    ex.Message);

                return false;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string datopassword =
                textContrasena.Text.Trim();

            string datousuario =
                txtUsuario.Text.Trim();

            string rolSeleccionado =
                tntTitulo.Text.Trim();

            if (datopassword == "" || datousuario == "")
>>>>>>> Stashed changes
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsuario.Focus();
                return;
            }

<<<<<<< Updated upstream
            if (datoIngresado != CONTRASENA)
=======
            bool accesoCorrecto = ValidarCredenciales(
                rolSeleccionado,
                datousuario,
                datopassword
            );

            if (!accesoCorrecto)
>>>>>>> Stashed changes
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                textContrasena.Clear();
                textContrasena.Focus();
                return;
            }

            Form formularioDestino;

            if (rolSeleccionado == "Administrador")
            {
                formularioDestino =
                    new FormAdministrador();
            }
            else if (rolSeleccionado == "Doctor")
            {
                formularioDestino =
                    new FormDoctor();
            }
            else
            {
                formularioDestino =
                    new FormEmpleado();
            }

            MessageBox.Show(
                "Bienvenido " +
                rolSeleccionado.ToLower() + ".",
                "Acceso correcto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            formularioDestino.FormClosed += (s, args) =>
            {
                this.Show();

                txtUsuario.Clear();
                textContrasena.Clear();

                txtUsuario.Focus();
            };

            formularioDestino.Show();
            this.Hide();
        }

        private Button BuscarBotonIniciar(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                if (control is Button boton &&
                    boton.Text.Trim().Equals(
                        "Iniciar sesión",
                        StringComparison.OrdinalIgnoreCase))
                {
                    return boton;
                }

                Button botonEncontrado =
                    BuscarBotonIniciar(control);

                if (botonEncontrado != null)
                {
                    return botonEncontrado;
                }
            }

            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnIniciarSesion_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show
            (
                "¿Estás seguro de querer salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            textContrasena.UseSystemPasswordChar =! textContrasena.UseSystemPasswordChar;

            textContrasena.Focus();
            textContrasena.SelectionStart =
            textContrasena.Text.Length;
        }
    }
}