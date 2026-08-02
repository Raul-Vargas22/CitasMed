using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CitasMed
{
    public partial class Form1 : Form
    {
        private string rolSeleccionado = "Administrador";

        public Form1()
        {
            InitializeComponent();

            txtUsuario.Multiline = false;
            txtUsuario.AutoSize = false;
            txtUsuario.Height = 41;

            textContrasena.Multiline = false;
            textContrasena.AutoSize = false;
            textContrasena.Height = 41;

            // Evita eventos repetidos en el botón de inicio
            btnSesion.Click -= button1_Click;
            btnSesion.Click -= btnSesion_Click;
            btnSesion.Click += btnSesion_Click;

            // Eventos de los botones para mostrar u ocultar datos
            iconoUsuario.Click -= iconoUsuario_Click;
            iconoUsuario.Click += iconoUsuario_Click;

            iconoPassword.Click -= iconoPassword_Click;
            iconoPassword.Click += iconoPassword_Click;

            btnSalir.Click -= btnSalir_Click;
            btnSalir.Click += btnSalir_Click;

            // Permite iniciar sesión presionando Enter
            AcceptButton = btnSesion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepararRol("Administrador");
        }

        private void PrepararRol(string rol)
        {
            rolSeleccionado = rol;

            // Mantiene el título principal del diseño
            tntTitulo.Text = "¡Bienvenido de nuevo!";
            tntTitulo.TextAlign = ContentAlignment.MiddleCenter;

            lblUsuario.Text = "Ingrese su usuario";
            lblUsuario.Visible = true;

            lblPassword.Text = "Ingrese su contraseña";
            lblPassword.Visible = true;

            txtUsuario.Visible = true;
            textContrasena.Visible = true;

            // El usuario se muestra normalmente
            txtUsuario.UseSystemPasswordChar = false;

            // La contraseña comienza oculta
            textContrasena.UseSystemPasswordChar = true;

            txtUsuario.Clear();
            textContrasena.Clear();

            // Muestra el rol seleccionado en el título de la ventana
            Text = rol.ToUpper();

            // Marca visualmente el rol seleccionado
            lblAdministrador.LinkColor =
                rol == "Administrador" ? Color.DarkBlue : Color.Black;

            lblEmpleado.LinkColor =
                rol == "Empleado" ? Color.DarkBlue : Color.Black;

            lblDoctor.LinkColor =
                rol == "Doctor" ? Color.DarkBlue : Color.Black;

            txtUsuario.Focus();
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

        private bool ValidarCredenciales(
            string rol,
            string usuario,
            string contrasena)
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta;

                    if (rol == "Administrador")
                    {
                        consulta = @"
                            SELECT COUNT(*)
                            FROM Administrador
                            WHERE usuario = @usuario
                            AND contrasena = @contrasena;";
                    }
                    else if (rol == "Doctor")
                    {
                        consulta = @"
                            SELECT COUNT(*)
                            FROM Medico
                            WHERE usuario = @usuario
                            AND contrasena = @contrasena;";
                    }
                    else if (rol == "Empleado")
                    {
                        consulta = @"
                            SELECT COUNT(*)
                            FROM Empleado
                            WHERE usuario = @usuario
                            AND contrasena = @contrasena;";
                    }
                    else
                    {
                        return false;
                    }

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@usuario",
                            usuario);

                        comando.Parameters.AddWithValue(
                            "@contrasena",
                            contrasena);

                        int cantidad = Convert.ToInt32(
                            comando.ExecuteScalar());

                        return cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al conectar con la base de datos:\n" +
                    ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        private void btnSesion_Click(
            object sender,
            EventArgs e)
        {
            IniciarSesion();
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = textContrasena.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show(
                    "Favor de llenar todos los campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            bool accesoCorrecto = ValidarCredenciales(
                rolSeleccionado,
                usuario,
                contrasena);

            if (!accesoCorrecto)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textContrasena.Clear();
                textContrasena.Focus();
                return;
            }

            Form formularioDestino;

            if (rolSeleccionado == "Administrador")
            {
                formularioDestino = new FormAdministrador();
            }
            else if (rolSeleccionado == "Doctor")
            {
                formularioDestino = new FormDoctor();
            }
            else
            {
                formularioDestino = new FormEmpleado();
            }
            if (rolSeleccionado == "Doctor")
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string sql = "SELECT id_medico FROM Medico WHERE usuario=@usuario";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    Sesion.IdMedico = Convert.ToInt32(cmd.ExecuteScalar());
                }

                formularioDestino = new FormDoctor();
            }

            MessageBox.Show(
                "Bienvenido " +
                rolSeleccionado.ToLower() + ".",
                "Acceso correcto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            formularioDestino.FormClosed +=
                (s, argumentos) =>
                {
                    Show();

                    txtUsuario.Clear();
                    textContrasena.Clear();

                    txtUsuario.Focus();
                };

            formularioDestino.Show();
            Hide();
        }

        private void iconoUsuario_Click(
            object sender,
            EventArgs e)
        {
            txtUsuario.UseSystemPasswordChar =
                !txtUsuario.UseSystemPasswordChar;

            txtUsuario.Focus();

            txtUsuario.SelectionStart =
                txtUsuario.Text.Length;
        }

        private void iconoPassword_Click(
            object sender,
            EventArgs e)
        {
            textContrasena.UseSystemPasswordChar =
                !textContrasena.UseSystemPasswordChar;

            textContrasena.Focus();

            textContrasena.SelectionStart =
                textContrasena.Text.Length;
        }

        private void btnSalir_Click(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de querer salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblPassword_Click(
            object sender,
            EventArgs e)
        {
        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void iconPictureBox1_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}