using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();

            RedondearPanel(panel7, 20);
            RedondearBoton(btnGuardar, 20);

            // Conectar NUEVA CITA
            lblNuevaCitaD.Click -= lblNuevaCitaD_Click;
            lblNuevaCitaD.Click += lblNuevaCitaD_Click;

            // Conectar PACIENTES
            lblPacientesD.Click -= lblPacientesD_Click;
            lblPacientesD.Click += lblPacientesD_Click;
        }

        private void CargarCitasDoctor()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                    SELECT
                    c.id_cita AS ID_CITA,
                    p.curp AS CURP,
                    p.nombre AS NOMBRE,
                    p.apellido_paterno AS APELLIDO_PATERNO,
                    p.apellido_materno AS APELLIDO_MATERNO,
                    p.enfermedad_cronica AS ENFERMEDADES_CRONICAS,
                    DATE_FORMAT(c.fecha,'%d/%m/%Y') AS FECHA
                    FROM Cita c
                    INNER JOIN Paciente p
                    ON c.id_paciente = p.id_paciente
                    WHERE c.id_medico = @idMedico
                    AND c.estado IN ('Programada', 'Reagendada')
                    ORDER BY c.fecha,c.hora;";
                   
                    
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    comando.Parameters.AddWithValue(
                        "@idMedico",
                        Sesion.IdMedico);

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(comando);

                    adaptador.SelectCommand.Parameters.AddWithValue(
                    "@idMedico",
                    Sesion.IdUsuario);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView1.AutoGenerateColumns = false;

                    dataGridView1.Columns[0].DataPropertyName = "CURP";
                    dataGridView1.Columns[1].DataPropertyName = "NOMBRE";
                    dataGridView1.Columns[2].DataPropertyName = "APELLIDO_PATERNO";
                    dataGridView1.Columns[3].DataPropertyName = "APELLIDO_MATERNO";
                    dataGridView1.Columns[4].DataPropertyName = "ENFERMEDADES_CRONICAS";
                    dataGridView1.Columns[5].DataPropertyName = "FECHA";

                    dataGridView1.DataSource = tabla;

                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                    dataGridView1.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las citas:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {
            CargarCitasDoctor();
        }

        // Abre el registro de paciente que ya utiliza Empleado
        private void lblNuevaCitaD_Click(
            object sender,
            EventArgs e)
        {
            using (Registro_de_paciente registro =
                   new Registro_de_paciente())
            {
                registro.ShowDialog(this);
            }
        }

        // Abre la tabla de pacientes que ya utiliza Empleado
        private void lblPacientesD_Click(
            object sender,
            EventArgs e)
        {
            FormPaciente pacientes = new FormPaciente();
            pacientes.Show();
            this.Hide();
        }

        // Regresar al login
        private void btnInicio_Doc_Click(
            object sender,
            EventArgs e)
        {
            Form1? login = Application.OpenForms
                .OfType<Form1>()
                .FirstOrDefault();

            if (login == null)
            {
                login = new Form1();
            }

            login.Show();
            login.WindowState = FormWindowState.Normal;
            login.BringToFront();
            login.Activate();

            this.Close();
        }

        private void RedondearPanel(
            Panel panel,
            int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(
                new Rectangle(
                    0,
                    0,
                    radio,
                    radio),
                180,
                90);

            path.AddArc(
                new Rectangle(
                    panel.Width - radio,
                    0,
                    radio,
                    radio),
                270,
                90);

            path.AddArc(
                new Rectangle(
                    panel.Width - radio,
                    panel.Height - radio,
                    radio,
                    radio),
                0,
                90);

            path.AddArc(
                new Rectangle(
                    0,
                    panel.Height - radio,
                    radio,
                    radio),
                90,
                90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void RedondearBoton(
            Button boton,
            int radio)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();

            path.AddArc(
                new Rectangle(
                    0,
                    0,
                    radio,
                    radio),
                180,
                90);

            path.AddArc(
                new Rectangle(
                    boton.Width - radio,
                    0,
                    radio,
                    radio),
                270,
                90);

            path.AddArc(
                new Rectangle(
                    boton.Width - radio,
                    boton.Height - radio,
                    radio,
                    radio),
                0,
                90);

            path.AddArc(
                new Rectangle(
                    0,
                    boton.Height - radio,
                    radio,
                    radio),
                90,
                90);

            path.CloseFigure();

            boton.Region = new Region(path);
        }

        private void btnRegresar_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }
}