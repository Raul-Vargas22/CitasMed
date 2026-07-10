

namespace CitasMed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tntTitulo.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void lblAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Administrador";
            lblPassword.Visible = true;
            textBox1.Visible = true;

            lblPassword.Text = "ingrese contraseña";
        }

        private void label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Empleado";
            lblPassword.Visible = false;
            textBox1.Visible = false;

        }

        private void lblDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tntTitulo.Text = "Doctor";
            lblPassword.Visible=true; 
            textBox1.Visible=true;
            lblPassword.Text = "ingrese su usuario";
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
