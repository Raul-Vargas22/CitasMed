using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CitasMed
{
    public partial class EditarCitas : Form
    {
        private int idCitaEditar = 0;

        public EditarCitas()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        public EditarCitas(int idCita)
        {
            InitializeComponent();

            idCitaEditar = idCita;

            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            Text = "Editar cita";

            btnRegistrarE.Text = "GUARDAR CAMBIOS";
            btnMenuprincipalE.Text = "CANCELAR";

            // Información que solo se mostrará
            txtPaciente.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtEspecialidad.ReadOnly = true;
            txtDoctor.ReadOnly = true;

            txtMotivo.Multiline = true;

            // Configurar fecha
            dtFecha_citaE.Format =
                DateTimePickerFormat.Short;

            dtFecha_citaE.MinDate =
                new DateTime(2000, 1, 1);

            dtFecha_citaE.MaxDate =
                new DateTime(2100, 12, 31);

            // Configurar hora
            dtHoraE.Format =
                DateTimePickerFormat.Custom;

            dtHoraE.CustomFormat = "HH:mm";
            dtHoraE.ShowUpDown = true;

            // Evitar eventos repetidos
            Load -= EditarCitas_Load;
            Load += EditarCitas_Load;

            btnRegistrarE.Click -= btnRegistrarE_Click;
            btnRegistrarE.Click += btnRegistrarE_Click;

            btnMenuprincipalE.Click -=
                btnMenuprincipalE_Click;

            btnMenuprincipalE.Click +=
                btnMenuprincipalE_Click;

            AcceptButton = btnRegistrarE;
            CancelButton = btnMenuprincipalE;
        }

        private void EditarCitas_Load(
            object sender,
            EventArgs e)
        {
            if (idCitaEditar <= 0)
            {
                MessageBox.Show(
                    "No se recibió una cita válida.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            CargarDatosCita();
        }

        private void CargarDatosCita()
        {
            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT
                            CONCAT_WS(
                                ' ',
                                p.nombre,
                                p.apellido_paterno,
                                p.apellido_materno
                            ) AS paciente,

                            p.telefono,

                            e.nombre AS especialidad,

                            CONCAT_WS(
                                ' ',
                                m.nombre,
                                m.apellido_paterno,
                                m.apellido_materno
                            ) AS doctor,

                            c.fecha,
                            c.hora,
                            c.motivo

                        FROM Cita c

                        INNER JOIN Paciente p
                            ON c.id_paciente =
                               p.id_paciente

                        INNER JOIN Medico m
                            ON c.id_medico =
                               m.id_medico

                        INNER JOIN Especialidad e
                            ON m.id_especialidad =
                               e.id_especialidad

                        WHERE c.id_cita = @idCita;";

                    using (MySqlCommand comando =
                           new MySqlCommand(
                               consulta,
                               conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@idCita",
                            idCitaEditar);

                        using (MySqlDataReader lector =
                               comando.ExecuteReader())
                        {
                            if (!lector.Read())
                            {
                                MessageBox.Show(
                                    "No se encontró la cita.",
                                    "Aviso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                Close();
                                return;
                            }

                            txtPaciente.Text =
                                Convert.ToString(
                                    lector["paciente"]);

                            txtTelefono.Text =
                                Convert.ToString(
                                    lector["telefono"]);

                            txtEspecialidad.Text =
                                Convert.ToString(
                                    lector["especialidad"]);

                            txtDoctor.Text =
                                Convert.ToString(
                                    lector["doctor"]);

                            txtMotivo.Text =
                                lector["motivo"] == DBNull.Value
                                ? ""
                                : Convert.ToString(
                                    lector["motivo"]);

                            dtFecha_citaE.Value =
                                Convert.ToDateTime(
                                    lector["fecha"]);

                            TimeSpan hora =
                                (TimeSpan)lector["hora"];

                            dtHoraE.Value =
                                DateTime.Today.Add(hora);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la cita:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarE_Click(
            object sender,
            EventArgs e)
        {
            if (txtMotivo.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Escribe el motivo de la cita.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMotivo.Focus();
                return;
            }

            DialogResult respuesta =
                MessageBox.Show(
                    "¿Deseas guardar los cambios?",
                    "Editar cita",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion =
                       ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        UPDATE Cita
                        SET
                            fecha = @fecha,
                            hora = @hora,
                            motivo = @motivo,
                            estado = 'Reagendada'
                        WHERE id_cita = @idCita;";

                    using (MySqlCommand comando =
                           new MySqlCommand(
                               consulta,
                               conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@fecha",
                            dtFecha_citaE.Value.Date);

                        comando.Parameters.Add(
                            "@hora",
                            MySqlDbType.Time
                        ).Value =
                            dtHoraE.Value.TimeOfDay;

                        comando.Parameters.AddWithValue(
                            "@motivo",
                            txtMotivo.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@idCita",
                            idCitaEditar);

                        int filas =
                            comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show(
                                "Cita actualizada correctamente.",
                                "Cambios guardados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No se pudo actualizar la cita.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "El médico ya tiene otra cita " +
                        "registrada en esa fecha y hora.",
                        "Horario ocupado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Error al actualizar la cita:\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnMenuprincipalE_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}