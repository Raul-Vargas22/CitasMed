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
    public partial class FormHistorialCitas : Form
    {
        public FormHistorialCitas()
        {
            InitializeComponent();
            ucMenuAdministrador1.InicioClick += btnInicio_Click;
            ucMenuAdministrador1.PersonalMedicoClick += lblPersonalMedico_Click;
            ucMenuAdministrador1.HistorialCitasClick += lblHistorialCitas_Click;
            ucMenuAdministrador1.SeleccionarHistorialCitas();
            RedondearPanel(panel7, 20);
        }

        private void FormHistorialCitas_Load(object sender, EventArgs e)
        {

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormAdministrador administrador = new FormAdministrador();
            administrador.Show();
            this.Hide();
        }
        private void lblPersonalMedico_Click(object sender, EventArgs e)
        {
            FormPersonalMedico personal = new FormPersonalMedico();
            personal.Show();
            this.Hide();
        }
        private void lblHistorialCitas_Click(object sender, EventArgs e)
        {
           
        }

        private void ucMenuAdministrador1_Load(object sender, EventArgs e)
        {

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
    }
}
