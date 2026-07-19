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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();

            ucMenuEmpleado1.InicioClick += btnInicio_empleado_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNuevaCita_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramadas_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Especialidades_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;


            RedondearPanel(panel6, 25);
            RedondearPanel(panel5, 25);
            RedondearPanel(panel7, 25);

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
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_empleado_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

        private void lblNuevaCita_Click(object sender, EventArgs e)
        {
            Registro_de_paciente registro = new Registro_de_paciente();
            registro.Show();
            this.Hide();
        }
        //Funcional
        private void lblProgramadas_Click(object sender, EventArgs e)
        {
            FormCitas_programadas programadas = new FormCitas_programadas();
            programadas.Show();
            this.Hide();
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial_de_consultas historial = new FormHistorial_de_consultas();
            historial.Show();
            this.Hide();
        }

        private void lblMedicos_Especialidades_Click(object sender, EventArgs e)
        {
            FormMédicos_y_Especialidades Medicos_especialidades = new FormMédicos_y_Especialidades();
            Medicos_especialidades.Show();
            this.Hide();
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
            this.Hide();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }
    }
}
