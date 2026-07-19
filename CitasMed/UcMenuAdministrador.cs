using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class UcMenuAdministrador : UserControl
    {
        public event EventHandler InicioClick;
        public event EventHandler PersonalMedicoClick;
        public event EventHandler HistorialCitasClick;

        public UcMenuAdministrador()
        {
            InitializeComponent();
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.TabStop = false;

            RedondearBoton(btnInicio, 20);
            RedondearPanel(panel1,20);

        }
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(boton.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(boton.Width - radio, boton.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, boton.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            InicioClick?.Invoke(this, EventArgs.Empty);
        }
        private void lblPersonalMedico_Click(object sender, EventArgs e)
        {
            PersonalMedicoClick?.Invoke(this, EventArgs.Empty);
        }
        private void lblHistorialCitas_Click(object sender, EventArgs e)
        {
            HistorialCitasClick?.Invoke(this, EventArgs.Empty);
        }
        private void LimpiarSeleccion()
        {
            
            lblPersonalMedico.BackColor = Color.Transparent;
            lblHistorialCitas.BackColor = Color.Transparent;
        }
        public void SeleccionarInicio()
        {
            LimpiarSeleccion();
            btnInicio.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarPersonalMedico()
        {
            LimpiarSeleccion();
            lblPersonalMedico.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarHistorialCitas()
        {
            LimpiarSeleccion();
            lblHistorialCitas.BackColor = Color.FromArgb(133, 210, 208);
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
    
