using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CitasMed
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Evita que los eventos se conecten dos veces
            this.Load -= Form2_Load;
            this.Load += Form2_Load;

            btnRegistrarA.Click -= btnRegistrarA_Click;
            btnRegistrarA.Click += btnRegistrarA_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        private void CargarEspecialidades()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = @"
                        SELECT id_especialidad, nombre
                        FROM Especialidad
                        ORDER BY nombre;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    cmbEspecialidadA.DataSource = tabla;
                    cmbEspecialidadA.DisplayMember = "nombre";
                    cmbEspecialidadA.ValueMember = "id_especialidad";
                    cmbEspecialidadA.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar las especialidades.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarA_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    if (MedicoYaRegistrado(conexion))
                    {
                        MessageBox.Show(
                            "La cédula o el usuario ya están registrados.",
                            "Registro existente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    string consulta = @"
                        INSERT INTO Medico
                        (
                            nombre,
                            apellido_paterno,
                            apellido_materno,
                            cargo,
                            cedula,
                            usuario,
                            contrasena,
                            id_especialidad
                        )
                        VALUES
                        (
                            @nombre,
                            @apellidoPaterno,
                            @apellidoMaterno,
                            @cargo,
                            @cedula,
                            @usuario,
                            @contrasena,
                            @idEspecialidad
                        );";

                    using (MySqlCommand comando =
                           new MySqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@nombre",
                            txtnombreA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidoPaterno",
                            txtApellidoPaternoA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@apellidoMaterno",
                            txtApellidoMaternoA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@cargo",
                            txtCargoA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@cedula",
                            txtCedulaA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@usuario",
                            txtUsuario.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@contrasena",
                            txtContraseñaA.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@idEspecialidad",
                            Convert.ToInt32(
                                cmbEspecialidadA.SelectedValue));

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Médico registrado correctamente.",
                    "Registro completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el médico.\n\n" +
                    ex.Message,
                    "Error de base de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtnombreA.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaternoA.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaternoA.Text) ||
                string.IsNullOrWhiteSpace(txtCargoA.Text) ||
                cmbEspecialidadA.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtCedulaA.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñaA.Text))
            {
                MessageBox.Show(
                    "Completa todos los campos.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        private bool MedicoYaRegistrado(MySqlConnection conexion)
        {
            string consulta = @"
                SELECT COUNT(*)
                FROM Medico
                WHERE cedula = @cedula
                   OR usuario = @usuario;";

            using (MySqlCommand comando =
                   new MySqlCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue(
                    "@cedula",
                    txtCedulaA.Text.Trim());

                comando.Parameters.AddWithValue(
                    "@usuario",
                    txtUsuario.Text.Trim());

                int cantidad =
                    Convert.ToInt32(comando.ExecuteScalar());

                return cantidad > 0;
            }
        }
    }
}