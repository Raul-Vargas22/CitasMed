using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class Form1 : Form
    {
        private const string CONTRASENA = "faul";
        private const string USUARIO = "Raul";
        public Form1()
        {
            InitializeComponent();

            //btnVerPassword.Click -= btnVerPassword_Click;
            // btnVerPassword.Click += btnVerPassword_Click;

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

            lblPassword.Text = "Ingrese su Contraseña";
            lblPassword.Visible = true;
            lblUsuario.Text = "Ingrese su Usuario";
            lblUsuario.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = false;
            textContrasena.PasswordChar = '*';

            textContrasena.Clear();
            textContrasena.Focus();
            txtUsuario.Clear();
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string datopassword = textContrasena.Text.Trim();
            string datousuario = txtUsuario.Text.Trim();
            string rolSeleccionado = tntTitulo.Text.Trim();

            if (datopassword == "" && datousuario == "")
            {
                MessageBox.Show(
                    "Favor de llenar todos los campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textContrasena.Focus();
                return;
            }

            if (datopassword != CONTRASENA || datousuario != USUARIO)
            {
                MessageBox.Show(
                    "Contraseña incorrecta.",
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

            MessageBox.Show(
                "Bienvenido " + rolSeleccionado.ToLower() + ".",
                "Acceso correcto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            formularioDestino.FormClosed += (s, args) =>
            {
                this.Show();
                textContrasena.Clear();
                textContrasena.Focus();
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

                Button botonEncontrado = BuscarBotonIniciar(control);

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
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

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

        private void iconoUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.UseSystemPasswordChar == false)
            {
                txtUsuario.UseSystemPasswordChar = true;
                txtUsuario.PasswordChar = '●';
            }
            else
            {
                txtUsuario.UseSystemPasswordChar = false;
            }

        }

        private void iconoPassword_Click(object sender, EventArgs e)
        {
            if (textContrasena.UseSystemPasswordChar == false)
            {
                textContrasena.UseSystemPasswordChar = true;
                textContrasena.PasswordChar = '●';
            }
            else
            {
                textContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}