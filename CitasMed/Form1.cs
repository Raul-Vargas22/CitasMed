using System;
using System.Drawing;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class Form1 : Form
    {
        private const string CONTRASENA = "faul";

        public Form1()
        {
            InitializeComponent();

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
            textContrasena.PasswordChar = '\0';

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

        private void btnIniciarSesion_Click(
            object sender,
            EventArgs e)
        {
            string datoIngresado = textContrasena.Text.Trim();
            string rolSeleccionado = tntTitulo.Text.Trim();

            if (datoIngresado == "")
            {
                MessageBox.Show(
                    "Ingrese la contraseña.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textContrasena.Focus();
                return;
            }

            if (datoIngresado != CONTRASENA)
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
            Application.Exit();
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
    }
}