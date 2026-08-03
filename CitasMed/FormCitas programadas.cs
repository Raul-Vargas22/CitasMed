using System;
using MySql.Data.MySqlClient;
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
    public partial class FormCitas_programadas : Form
    {
        private DataTable tablaCitas = new DataTable();

        private void CargarCitas()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                SELECT
                    c.id_cita AS CLAVE,

                    CONCAT(
                        p.nombre, ' ',
                        p.apellido_paterno, ' ',
                        IFNULL(p.apellido_materno, '')
                    ) AS PACIENTE,

                    p.telefono AS TELEFONO,

                    e.nombre AS ESPECIALIDAD,

                    CONCAT(
                        m.nombre, ' ',
                        m.apellido_paterno, ' ',
                        IFNULL(m.apellido_materno, '')
                    ) AS DOCTOR,

                    DATE_FORMAT(c.fecha, '%d/%m/%Y') AS FECHA,
                    TIME_FORMAT(c.hora, '%H:%i') AS HORA,
                    c.motivo AS MOTIVO

                FROM Cita c

                INNER JOIN Paciente p
                    ON c.id_paciente = p.id_paciente

                INNER JOIN Medico m
                    ON c.id_medico = m.id_medico

                INNER JOIN Especialidad e
                    ON m.id_especialidad = e.id_especialidad

                WHERE c.estado IN ('Programada', 'Reagendada')

                ORDER BY c.fecha, c.hora;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    tablaCitas.Clear();
                    tablaCitas.Columns.Clear();

                    adaptador.Fill(tablaCitas);

                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = tablaCitas;

                    // Evitar modificaciones directas
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AllowUserToDeleteRows = false;
                    dataGridView1.EditMode =
                        DataGridViewEditMode.EditProgrammatically;

                    dataGridView1.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridView1.MultiSelect = false;
                    dataGridView1.RowHeadersVisible = false;

                    dataGridView1.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las citas:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public FormCitas_programadas()
        {
            InitializeComponent();

            AsistenteVoz.AgregarBotonToggle(this);

            ucMenuEmpleado1.SeleccionarProgramadas();
            ucMenuEmpleado1.InicioClick += btnRegresar_Click;
            ucMenuEmpleado1.NuevaCitaClick += lblNueva_Click;
            ucMenuEmpleado1.ProgramadasClick += lblProgramada_Click;
            ucMenuEmpleado1.HistorialClick += lblHistorial_Click;
            ucMenuEmpleado1.MedicosClick += lblMedicos_Click;
            ucMenuEmpleado1.PacientesClick += lblPacientes_Click;
            
            ConfigurarAccesibilidadVoz();
        }
        private void ConfigurarAccesibilidadVoz()
        {
            textBox1.Enter += (s, e) => AsistenteVoz.Decir("Buscar cita, por paciente, doctor, especialidad o motivo");
            button2.Enter += (s, e) => AsistenteVoz.Decir("Botón editar cita");
            button3.Enter += (s, e) => AsistenteVoz.Decir("Botón eliminar cita");

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.F1)
                {
                    AsistenteVoz.Decir(
                        $"Pantalla de citas programadas. {dataGridView1.Rows.Count} citas en la lista. " +
                        "Use las flechas para navegar la tabla, o el buscador para filtrar.");
                }
            };
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
                return;

            string paciente = Convert.ToString(dataGridView1.CurrentRow.Cells["PACIENTE"].Value);
            string doctor = Convert.ToString(dataGridView1.CurrentRow.Cells["DOCTOR"].Value);
            string fecha = Convert.ToString(dataGridView1.CurrentRow.Cells["FECHA"].Value);
            string hora = Convert.ToString(dataGridView1.CurrentRow.Cells["HORA"].Value);

            AsistenteVoz.Decir($"Cita de {paciente} con el doctor {doctor}, el {fecha} a las {hora}");
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Sesion.AbrirFormularioSegunRol();
            this.Close();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void lblNueva_Click(object sender, EventArgs e)
        {
            using (Registro_de_paciente registro =
                   new Registro_de_paciente())
            {
                registro.ShowDialog(this);
            }
        }

        private void lblProgramada_Click(object sender, EventArgs e)
        {
            AsistenteVoz.Decir("Actualmente se encuentra en esta sección");
            MessageBox.Show("Actualmente se encuentra en esta sección");
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial_de_consultas historial = new FormHistorial_de_consultas();
            historial.Show();
            this.Hide();
        }

        private void lblMedicos_Click(object sender, EventArgs e)
        {
            FormMédicos_y_Especialidades medicos = new FormMédicos_y_Especialidades();
            medicos.Show();
            this.Hide();
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.Show();
            this.Hide();
        }

        private void FormCitas_programadas_Load(object sender, EventArgs e)
        {


            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;


            RedondearPanel(panel7, 20);

            RedondearBoton(button2, 20);
            RedondearBoton(button3, 20);

            CargarCitas();
            if (Sesion.perfil == "Doctor")
            {
                button2.Visible = false;
                button3.Visible = false; 
            }
            AsistenteVoz.Decir($"Pantalla de citas programadas. {dataGridView1.Rows.Count} citas en la lista.");
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texto = textBox1.Text
                .Trim()
                .Replace("'", "''");

            tablaCitas.DefaultView.RowFilter =
                "PACIENTE LIKE '%" + texto + "%' OR " +
                "DOCTOR LIKE '%" + texto + "%' OR " +
                "ESPECIALIDAD LIKE '%" + texto + "%' OR " +
                "MOTIVO LIKE '%" + texto + "%'";


            if (!string.IsNullOrWhiteSpace(texto))
            {
                int resultados = tablaCitas.DefaultView.Count;
                AsistenteVoz.Decir($"{resultados} resultado" + (resultados == 1 ? "" : "s") + " encontrado" + (resultados == 1 ? "" : "s"));
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucMenuEmpleado1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                AsistenteVoz.Decir("Selecciona una cita para eliminar.");
                MessageBox.Show( "Selecciona una cita para eliminar.");
                return;
            }

            int idCita = Convert.ToInt32( dataGridView1.CurrentRow.Cells["CLAVE"].Value);

            string paciente = Convert.ToString(dataGridView1.CurrentRow.Cells["PACIENTE"].Value);
            AsistenteVoz.Decir($"¿Confirma eliminar la cita de {paciente}?");


            DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar la cita de " +  paciente + "?", "Eliminar cita", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (respuesta != DialogResult.Yes)
            {
                AsistenteVoz.Decir("Eliminación cancelada.");
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                DELETE FROM Cita
                WHERE id_cita = @idCita;";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idCita", idCita);

                        comando.ExecuteNonQuery();
                    }
                }
               
                AsistenteVoz.Decir("Cita eliminada correctamente.");
                MessageBox.Show( "Cita eliminada correctamente.");

                CargarCitas();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    AsistenteVoz.Decir("No se puede eliminar porque esta cita ya tiene una consulta registrada.");
                    MessageBox.Show( "No se puede eliminar porque esta cita ya tiene una consulta registrada.");
                }
                else
                {
                    AsistenteVoz.Decir("Error al eliminar la cita.");
                    MessageBox.Show("Error al eliminar la cita:\n" +ex.Message);
                }
            }
        }

        private void button2_Click( object sender,  EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                AsistenteVoz.Decir("Selecciona una cita para editar.");
                MessageBox.Show( "Selecciona una cita para editar.");
                return;
            }

            int idCita = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CLAVE"].Value);
            AsistenteVoz.Decir("Abriendo formulario de edición de cita.");


            using (EditarCitas formulario =
                   new EditarCitas(idCita))
            {
                formulario.ShowDialog(this);
            }

            CargarCitas();
        }
    }
}