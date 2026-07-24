using System;
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
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
            ucMenuAdministrador1.InicioClick += btnInicio_admin_Click;
            ucMenuAdministrador1.PersonalMedicoClick += lblPersonalMedico_Click;
            ucMenuAdministrador1.HistorialCitasClick += lblHistorialCitas_Click;
            ucMenuAdministrador1.SeleccionarInicio();
            RedondearPanel(panel7, 20);

        }

        private void btnInicio_admin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }
        private void lblPersonalMedico_Click(object sender, EventArgs e)
        {
            FormPersonalMedico personal = new FormPersonalMedico();
            personal.Show();
            this.Hide();

        }
        private void lblHistorialCitas_Click(object sender, EventArgs e)
        {
            FormHistorialCitas historial = new FormHistorialCitas();
            historial.Show();
            this.Hide();

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

        private void ucMenuAdministrador1_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            FormPaciente registro = new FormPaciente();
            registro.Show();
            this.Hide();
        }

        private void lblProgramadas_Click(object sender, EventArgs e)
        {
            FormPaciente registro = new FormPaciente();
            registro.Show();
            this.Close();
        }

        private void lblConsultas_Click(object sender, EventArgs e)
        {

        }

        private void lblMedicos_especialidades_Click(object sender, EventArgs e)
        {

        }
    }
}