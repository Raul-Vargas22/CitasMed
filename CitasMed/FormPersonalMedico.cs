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
    public partial class FormPersonalMedico : Form
    {
        public FormPersonalMedico()
        {
            InitializeComponent();
            ucMenuAdministrador1.InicioClick += btnInicio_Click;
            ucMenuAdministrador1.PersonalMedicoClick += lblPersonalMedico_Click;
            ucMenuAdministrador1.HistorialCitasClick += lblHistorialCitas_Click;
            ucMenuAdministrador1.SeleccionarPersonalMedico();
            RedondearPanel(panel7, 20);

            ConfigurarAccesibilidadVoz();
        }
        private void ConfigurarAccesibilidadVoz()
        {
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AsistenteVoz.Decir(
                        "Pantalla de personal médico. Use el menú lateral para navegar.");
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPersonalMedico_Load(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Pantalla de personal médico.");

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Regresando al inicio.");
            FormAdministrador administardor = new FormAdministrador();
            administardor.Show();
            this.Hide();

        }
        private void lblPersonalMedico_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Actualmente se encuentra en esta sección");
        }
        private void lblHistorialCitas_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Historial de citas");
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

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Registrar paciente");
            Registro_de_paciente registro = new Registro_de_paciente();
            registro.Show();
            this.Hide();
        }

        private void lblProgramadas_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Citas programadas");
            FormPaciente registro = new FormPaciente();
            registro.Show();
            this.Close();
        }

        private void lblConsultas_Click(object sender, EventArgs e)
        {
            FormCitas_programadas programadas = new FormCitas_programadas();
            programadas.Show();
            this.Close();
        }

        private void lblMedicos_especialidades_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Médicos y especialidades");
            FormMédicos_y_Especialidades especialidades = new FormMédicos_y_Especialidades();
            especialidades.Show();
            this.Close();
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Pacientes");
            FormPaciente pacientes = new FormPaciente();
            pacientes.Show();
            this.Close();
        }
    }
}
