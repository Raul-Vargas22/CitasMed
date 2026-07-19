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
    public partial class UcMenuEmpleado : UserControl
    {
        public event EventHandler InicioClick;
        public event EventHandler NuevaCitaClick;
        public event EventHandler ProgramadasClick;
        public event EventHandler HistorialClick;
        public event EventHandler MedicosClick;
        public event EventHandler PacientesClick;
        public UcMenuEmpleado()
        {
            InitializeComponent();
            btnInicio_empleado.FlatStyle = FlatStyle.Flat;
            btnInicio_empleado.FlatAppearance.BorderSize = 0;
            btnInicio_empleado.TabStop = false;

            RedondearBoton(btnInicio_empleado, 20);
            RedondearPanel(panel1, 20);
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_empleado_Click(object sender, EventArgs e)
        {
            InicioClick?.Invoke(this, EventArgs.Empty);
        }
        private void lblNuevaCita_Click(object sender, EventArgs e)
        {
            NuevaCitaClick?.Invoke(this, EventArgs.Empty);
        }
        private void lblProgramadas_Click(object sender, EventArgs e)
        {
            ProgramadasClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            HistorialClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblMedicos_Especialidades_Click(object sender, EventArgs e)
        {
            MedicosClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            PacientesClick?.Invoke(this, EventArgs.Empty);
        }
        private void LimpiarSeleccion()
        {
            btnInicio_empleado.BackColor = Color.Transparent;
            lblNuevaCita.BackColor = Color.Transparent;
            lblProgramadas.BackColor = Color.Transparent;
            lblHistorial.BackColor = Color.Transparent;
            lblMedicos_Especialidades.BackColor = Color.Transparent;
            lblPacientes.BackColor = Color.Transparent;
            
            
        }
        public void SeleccionarInicio()
        {
            LimpiarSeleccion();
            btnInicio_empleado.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarNuevaCita()
        {
            LimpiarSeleccion();
            lblNuevaCita.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarProgramadas()
        {
            LimpiarSeleccion();
            lblProgramadas.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarHistorial()
        {
            LimpiarSeleccion();
            lblHistorial.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarMedicos()
        {
            LimpiarSeleccion();
            lblMedicos_Especialidades.BackColor = Color.FromArgb(133, 210, 208);
        }

        public void SeleccionarPacientes()
        {
            LimpiarSeleccion();
            lblPacientes.BackColor = Color.FromArgb(133, 210, 208);
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
