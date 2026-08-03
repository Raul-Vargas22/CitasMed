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
            ucMenuAdministrador1.RegistrarClick += lblRegistrar_Click;
            ucMenuAdministrador1.ProgramadasClick += lblProgramadas_Click;
            ucMenuAdministrador1.MedicosEspecialidadesClick += lblMedicos_especialidades_Click;
            ucMenuAdministrador1.SeleccionarInicio();
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
                        "Panel de administrador. Use el menú lateral para navegar entre inicio, " +
                        "personal médico, historial de citas, registrar, programadas y médicos y especialidades.");
                }
            };
        }

        private void btnInicio_admin_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Cerrando sesión.");
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Bienvenido al panel de administrador.");
        }
        private void lblPersonalMedico_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Personal médico");
            FormPersonalMedico personal = new FormPersonalMedico();
            personal.Show();
            this.Hide();

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

        private void ucMenuAdministrador1_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Registrar paciente");
            Registro_de_paciente_admin registro = new Registro_de_paciente_admin();
            registro.Show();
            this.Hide();
        }

        private void lblProgramadas_Click(object sender, EventArgs e)
        {

            AsistenteVoz.Decir("Citas programadas");
            FormCitas_programadas_admin programadas = new FormCitas_programadas_admin();
            programadas.Show();
            this.Close();
        }

        private void lblConsultas_Click(object sender, EventArgs e)
        {
            Historial_consultas_admin historial = new Historial_consultas_admin();
            historial.Show();
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