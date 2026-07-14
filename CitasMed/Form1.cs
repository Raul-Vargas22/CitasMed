using System;
using System.Drawing;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Busca automáticamente el botón que dice "Iniciar sesión"
            Button botonIniciar = BuscarBotonIniciar(this);

            if (botonIniciar != null)
            {
                botonIniciar.Click -= btnIniciarSesion_Click;
                botonIniciar.Click += btnIniciarSesion_Click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tntTitulo.TextAlign = ContentAlignment.MiddleCenter;
            tntTitulo.Text = "Administrador";

            lblPassword.Text = "Ingrese la contraseña";
            lblPassword.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = true;
        }

        private void lblAdministrador_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Administrador";

            lblPassword.Text = "Ingrese la contraseña";
            lblPassword.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = true;
            textContrasena.Clear();
            textContrasena.Focus();
        }

        private void lblDoctor_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Doctor";

            lblPassword.Text = "Ingrese la contraseña";
            lblPassword.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = false;
            textContrasena.Clear();
            textContrasena.Focus();
        }

        private void label4_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Empleado";

            lblPassword.Text = "Ingrese la contraseña";
            lblPassword.Visible = true;

            textContrasena.Visible = true;
            textContrasena.UseSystemPasswordChar = false;
            textContrasena.Clear();
            textContrasena.Focus();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string datoIngresado = textContrasena.Text.Trim();

            if (tntTitulo.Text == "Administrador")
            {
                if (datoIngresado == "")
                {
                    MessageBox.Show(
                        "Ingrese la contraseña.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    textContrasena.Focus();
                }
                else if (datoIngresado == "webiwabo(musica de pvz)")
                {
                    MessageBox.Show(
                        "Bienvenido administrador del sistema.",
                        "Acceso correcto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Contraseña incorrecta.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textContrasena.Clear();
                    textContrasena.Focus();
                }
            }
            else if (tntTitulo.Text == "Doctor")
            {
                if (datoIngresado == "")
                {
                    MessageBox.Show("Ingrese la contraseña.");
                    textContrasena.Focus();
                }
                else
                {
                    MessageBox.Show("Bienvenido doctor: " + datoIngresado);
                }
            }
            else if (tntTitulo.Text == "Empleado")
            {
                if (datoIngresado == "")
                {
                    MessageBox.Show("Ingrese la contraseña.");
                    textContrasena.Focus();
                }
                else
                {
                    MessageBox.Show("Bienvenido doctor: " + datoIngresado);
                }
            }
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

        // Estos métodos se conservan porque pueden estar conectados
        // desde el diseñador de Windows Forms.

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
    }
}
