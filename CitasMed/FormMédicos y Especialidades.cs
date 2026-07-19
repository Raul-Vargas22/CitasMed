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
    public partial class FormMédicos_y_Especialidades : Form
    {
        public FormMédicos_y_Especialidades()
        {
            InitializeComponent();
            ucMenuEmpleado1.SeleccionarMedicos();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;
            PanelRedondo(panel1);
        }
        private void PanelRedondo(Panel panel)
        {
            GraphicsPath ruta = new GraphicsPath();
            int radio = 20;
            ruta.StartFigure();
            ruta.AddArc(0, 0, radio, radio, 180, 90);
            ruta.AddArc(panel.Width - radio, 0, radio, radio, 270, 90);
            ruta.AddArc(panel.Width - radio, panel.Height - radio, radio, radio, 0, 90);
            ruta.AddArc(0, panel.Height - radio, radio, radio, 90, 90);
            ruta.CloseFigure();
            panel.Region = new Region(ruta);
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormEmpleado empleado = new FormEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void FormMédicos_y_Especialidades_Load(object sender, EventArgs e)
        {

        }
        private void lblNueva_Click(object sender, EventArgs e)
        {
            Registro_de_paciente registro = new Registro_de_paciente();
            registro.Show();
            this.Hide();
        }

        private void lblProgramada_Click(object sender, EventArgs e)
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

        private void lblMedicos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualmente se encuentra en esta sección");
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
            this.Hide();
        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }
    }
}
