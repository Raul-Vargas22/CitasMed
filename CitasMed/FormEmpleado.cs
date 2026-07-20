using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CitasMed
{
    public partial class FormEmpleado : Form
    {
        private UcMenuEmpleado menuEmpleado = null!;

        private TextBox? txtBusquedaCitas;
        private Control? controlBuscar;
        private Control? controlEditar;
        private Control? controlEliminar;

        private bool accionesConfiguradas = false;

        public FormEmpleado()
        {
            InitializeComponent();

            CrearMenuEmpleado();
            ConectarEventosMenu();

            RedondearPanel(panel6, 25);
            RedondearPanel(panel5, 25);
            RedondearPanel(panel7, 25);

            menuEmpleado.SeleccionarInicio();

            Shown -= FormEmpleado_Shown;
            Shown += FormEmpleado_Shown;
        }

        private void CrearMenuEmpleado()
        {
            menuEmpleado = new UcMenuEmpleado
            {
                Dock = DockStyle.Left,
                Width = 270
            };

            Controls.Add(menuEmpleado);
            menuEmpleado.BringToFront();
        }

        private void FormEmpleado_Shown(object? sender, EventArgs e)
        {
            ConfigurarAccionesCitas();
        }

        private void ConfigurarAccionesCitas()
        {
            if (accionesConfiguradas)
            {
                return;
            }

            txtBusquedaCitas = ObtenerControles(this)
                .OfType<TextBox>()
                .Where(textBox => textBox.Visible)
                .OrderByDescending(textBox => textBox.Width)
                .FirstOrDefault();

            controlBuscar = BuscarControlPorTexto(
                this,
                "Buscar por paciente"
            );

            controlEditar = BuscarControlPorTexto(
                this,
                "Editar cita"
            );

            controlEliminar = BuscarControlPorTexto(
                this,
                "Eliminar cita"
            );

            if (txtBusquedaCitas != null)
            {
                txtBusquedaCitas.KeyDown -= txtBusquedaCitas_KeyDown;
                txtBusquedaCitas.KeyDown += txtBusquedaCitas_KeyDown;

                Control? lupaSuperior =
                    BuscarIconoCercaDelTextBox(txtBusquedaCitas);

                if (lupaSuperior != null)
                {
                    lupaSuperior.Click -= controlBuscar_Click;
                    lupaSuperior.Click += controlBuscar_Click;
                    lupaSuperior.Cursor = Cursors.Hand;
                }
            }

            if (controlBuscar != null)
            {
                controlBuscar.Click -= controlBuscar_Click;
                controlBuscar.Click += controlBuscar_Click;
                controlBuscar.Cursor = Cursors.Hand;
            }

            if (controlEditar != null)
            {
                controlEditar.Click -= controlEditar_Click;
                controlEditar.Click += controlEditar_Click;
                controlEditar.Cursor = Cursors.Hand;
            }

            if (controlEliminar != null)
            {
                controlEliminar.Click -= controlEliminar_Click;
                controlEliminar.Click += controlEliminar_Click;
                controlEliminar.Cursor = Cursors.Hand;
            }

            accionesConfiguradas = true;
        }

        private void txtBusquedaCitas_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarCitas();
            }
        }

        private void controlBuscar_Click(
            object? sender,
            EventArgs e)
        {
            BuscarCitas();
        }

        private void controlEditar_Click(
            object? sender,
            EventArgs e)
        {
            EditarCita();
        }

        private void controlEliminar_Click(
            object? sender,
            EventArgs e)
        {
            EliminarCita();
        }

        private void BuscarCitas()
        {
            string textoBusqueda =
                txtBusquedaCitas?.Text.Trim() ?? "";

            if (textoBusqueda == "")
            {
                MessageBox.Show(
                    "Escribe el nombre de un paciente o médico.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBusquedaCitas?.Focus();
                return;
            }

            try
            {
                using MySqlConnection conexion =
                    ConexionBD.ObtenerConexion();

                conexion.Open();

                string columnaEstado =
                    ObtenerColumnaEstado(conexion);

                string consulta = $@"
                    SELECT
                        c.id_cita AS ID,
                        CONCAT_WS(
                            ' ',
                            p.nombre,
                            p.apellido_paterno,
                            p.apellido_materno
                        ) AS Paciente,
                        CONCAT_WS(
                            ' ',
                            m.nombre,
                            m.apellido_paterno,
                            m.apellido_materno
                        ) AS Medico,
                        c.fecha AS Fecha,
                        c.hora AS Hora,
                        c.motivo AS Motivo,
                        c.{columnaEstado} AS Estado
                    FROM Cita c
                    INNER JOIN Paciente p
                        ON c.id_paciente = p.id_paciente
                    INNER JOIN Medico m
                        ON c.id_medico = m.id_medico
                    WHERE
                        CONCAT_WS(
                            ' ',
                            p.nombre,
                            p.apellido_paterno,
                            p.apellido_materno
                        ) LIKE @texto
                        OR
                        CONCAT_WS(
                            ' ',
                            m.nombre,
                            m.apellido_paterno,
                            m.apellido_materno
                        ) LIKE @texto
                        OR
                        CAST(c.id_cita AS CHAR) LIKE @texto
                    ORDER BY c.fecha, c.hora;";

                using MySqlCommand comando =
                    new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@texto",
                    "%" + textoBusqueda + "%"
                );

                using MySqlDataAdapter adaptador =
                    new MySqlDataAdapter(comando);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron citas con ese nombre.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                MostrarResultados(
                    "Resultados de búsqueda",
                    tabla
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible buscar las citas.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MostrarResultados(
            string titulo,
            DataTable tabla)
        {
            Form ventanaResultados = new Form
            {
                Text = titulo,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(950, 430),
                MinimumSize = new Size(750, 350)
            };

            DataGridView tablaResultados =
                new DataGridView
                {
                    Dock = DockStyle.Fill,
                    DataSource = tabla,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AllowUserToResizeRows = false,
                    AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill,
                    SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect,
                    MultiSelect = false
                };

            Button btnCerrar = new Button
            {
                Text = "Cerrar",
                Dock = DockStyle.Right,
                Width = 110
            };

            btnCerrar.Click += (sender, e) =>
                ventanaResultados.Close();

            Panel panelInferior = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 45,
                Padding = new Padding(5)
            };

            panelInferior.Controls.Add(btnCerrar);

            ventanaResultados.Controls.Add(tablaResultados);
            ventanaResultados.Controls.Add(panelInferior);

            ventanaResultados.ShowDialog(this);
        }

        private void EditarCita()
        {
            string resultado = PedirDato(
                "Editar cita",
                "Escribe el ID de la cita que deseas editar:"
            );

            if (resultado == "")
            {
                return;
            }

            if (!int.TryParse(resultado, out int idCita))
            {
                MessageBox.Show(
                    "El ID debe ser un número.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using MySqlConnection conexion =
                    ConexionBD.ObtenerConexion();

                conexion.Open();

                string columnaEstado =
                    ObtenerColumnaEstado(conexion);

                string consulta = $@"
                    SELECT
                        fecha,
                        hora,
                        motivo,
                        {columnaEstado}
                    FROM Cita
                    WHERE id_cita = @idCita;";

                using MySqlCommand comando =
                    new MySqlCommand(consulta, conexion);

                comando.Parameters.AddWithValue(
                    "@idCita",
                    idCita
                );

                DateTime fecha;
                TimeSpan hora;
                string motivo;
                string estado;

                using (MySqlDataReader lector =
                    comando.ExecuteReader())
                {
                    if (!lector.Read())
                    {
                        MessageBox.Show(
                            "No existe una cita con ese ID.",
                            "Cita no encontrada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    fecha = Convert.ToDateTime(
                        lector["fecha"]
                    );

                    hora = (TimeSpan)lector["hora"];

                    motivo =
                        lector["motivo"]?.ToString() ?? "";

                    estado =
                        lector[columnaEstado]?.ToString() ?? "";
                }

                MostrarVentanaEditarCita(
                    conexion,
                    columnaEstado,
                    idCita,
                    fecha,
                    hora,
                    motivo,
                    estado
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible cargar la cita.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MostrarVentanaEditarCita(
            MySqlConnection conexion,
            string columnaEstado,
            int idCita,
            DateTime fecha,
            TimeSpan hora,
            string motivo,
            string estado)
        {
            Form ventana = new Form
            {
                Text = "Editar cita " + idCita,
                StartPosition =
                    FormStartPosition.CenterParent,
                ClientSize = new Size(420, 390),
                FormBorderStyle =
                    FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblFecha = new Label
            {
                Text = "Fecha:",
                Location = new Point(25, 25),
                AutoSize = true
            };

            DateTimePicker dtpFecha =
                new DateTimePicker
                {
                    Location = new Point(25, 50),
                    Width = 355,
                    Format =
                        DateTimePickerFormat.Short,
                    Value = fecha
                };

            Label lblHora = new Label
            {
                Text = "Hora:",
                Location = new Point(25, 90),
                AutoSize = true
            };

            DateTimePicker dtpHora =
                new DateTimePicker
                {
                    Location = new Point(25, 115),
                    Width = 355,
                    Format =
                        DateTimePickerFormat.Time,
                    ShowUpDown = true,
                    Value =
                        DateTime.Today.Add(hora)
                };

            Label lblMotivo = new Label
            {
                Text = "Motivo:",
                Location = new Point(25, 155),
                AutoSize = true
            };

            TextBox txtMotivo = new TextBox
            {
                Location = new Point(25, 180),
                Size = new Size(355, 65),
                Multiline = true,
                Text = motivo
            };

            Label lblEstado = new Label
            {
                Text = "Estado:",
                Location = new Point(25, 260),
                AutoSize = true
            };

            ComboBox cmbEstado = new ComboBox
            {
                Location = new Point(25, 285),
                Width = 355,
                DropDownStyle =
                    ComboBoxStyle.DropDown
            };

            cmbEstado.Items.AddRange(
                new object[]
                {
                    "Programada",
                    "Reagendada",
                    "Atendida",
                    "Cancelada"
                }
            );

            cmbEstado.Text = estado;

            Button btnGuardar = new Button
            {
                Text = "Guardar cambios",
                Location = new Point(135, 330),
                Size = new Size(150, 38),
                DialogResult = DialogResult.OK
            };

            ventana.Controls.Add(lblFecha);
            ventana.Controls.Add(dtpFecha);
            ventana.Controls.Add(lblHora);
            ventana.Controls.Add(dtpHora);
            ventana.Controls.Add(lblMotivo);
            ventana.Controls.Add(txtMotivo);
            ventana.Controls.Add(lblEstado);
            ventana.Controls.Add(cmbEstado);
            ventana.Controls.Add(btnGuardar);

            ventana.AcceptButton = btnGuardar;

            if (ventana.ShowDialog(this) !=
                DialogResult.OK)
            {
                return;
            }

            if (txtMotivo.Text.Trim() == "" ||
                cmbEstado.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Completa el motivo y el estado.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                string actualizar = $@"
                    UPDATE Cita
                    SET
                        fecha = @fecha,
                        hora = @hora,
                        motivo = @motivo,
                        {columnaEstado} = @estado
                    WHERE id_cita = @idCita;";

                using MySqlCommand comando =
                    new MySqlCommand(actualizar, conexion);

                comando.Parameters.AddWithValue(
                    "@fecha",
                    dtpFecha.Value.Date
                );

                comando.Parameters.Add(
                    "@hora",
                    MySqlDbType.Time
                ).Value = dtpHora.Value.TimeOfDay;

                comando.Parameters.AddWithValue(
                    "@motivo",
                    txtMotivo.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@estado",
                    cmbEstado.Text.Trim()
                );

                comando.Parameters.AddWithValue(
                    "@idCita",
                    idCita
                );

                comando.ExecuteNonQuery();

                MessageBox.Show(
                    "Cita actualizada correctamente.",
                    "Edición completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible actualizar la cita.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void EliminarCita()
        {
            string resultado = PedirDato(
                "Eliminar cita",
                "Escribe el ID de la cita que deseas eliminar:"
            );

            if (resultado == "")
            {
                return;
            }

            if (!int.TryParse(resultado, out int idCita))
            {
                MessageBox.Show(
                    "El ID debe ser un número.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using MySqlConnection conexion =
                    ConexionBD.ObtenerConexion();

                conexion.Open();

                using MySqlCommand comprobarCita =
                    new MySqlCommand(
                        @"SELECT COUNT(*)
                          FROM Cita
                          WHERE id_cita = @idCita;",
                        conexion
                    );

                comprobarCita.Parameters.AddWithValue(
                    "@idCita",
                    idCita
                );

                int cantidadCitas =
                    Convert.ToInt32(
                        comprobarCita.ExecuteScalar()
                    );

                if (cantidadCitas == 0)
                {
                    MessageBox.Show(
                        "No existe una cita con ese ID.",
                        "Cita no encontrada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                using MySqlCommand comprobarConsulta =
                    new MySqlCommand(
                        @"SELECT COUNT(*)
                          FROM Consulta
                          WHERE id_cita = @idCita;",
                        conexion
                    );

                comprobarConsulta.Parameters.AddWithValue(
                    "@idCita",
                    idCita
                );

                int consultasRelacionadas =
                    Convert.ToInt32(
                        comprobarConsulta.ExecuteScalar()
                    );

                if (consultasRelacionadas > 0)
                {
                    MessageBox.Show(
                        "Esta cita ya tiene una consulta médica " +
                        "registrada y no puede eliminarse.",
                        "Eliminación no permitida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DialogResult confirmacion =
                    MessageBox.Show(
                        "¿Seguro que deseas eliminar la cita " +
                        idCita + "?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                using MySqlCommand eliminar =
                    new MySqlCommand(
                        @"DELETE FROM Cita
                          WHERE id_cita = @idCita;",
                        conexion
                    );

                eliminar.Parameters.AddWithValue(
                    "@idCita",
                    idCita
                );

                eliminar.ExecuteNonQuery();

                MessageBox.Show(
                    "Cita eliminada correctamente.",
                    "Eliminación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible eliminar la cita.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private string PedirDato(
            string titulo,
            string mensaje)
        {
            Form ventana = new Form
            {
                Text = titulo,
                StartPosition =
                    FormStartPosition.CenterParent,
                ClientSize = new Size(390, 160),
                FormBorderStyle =
                    FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label etiqueta = new Label
            {
                Text = mensaje,
                Location = new Point(20, 20),
                AutoSize = true
            };

            TextBox cajaTexto = new TextBox
            {
                Location = new Point(20, 50),
                Width = 345
            };

            Button aceptar = new Button
            {
                Text = "Aceptar",
                Location = new Point(100, 100),
                Size = new Size(85, 32),
                DialogResult = DialogResult.OK
            };

            Button cancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(205, 100),
                Size = new Size(85, 32),
                DialogResult = DialogResult.Cancel
            };

            ventana.Controls.Add(etiqueta);
            ventana.Controls.Add(cajaTexto);
            ventana.Controls.Add(aceptar);
            ventana.Controls.Add(cancelar);

            ventana.AcceptButton = aceptar;
            ventana.CancelButton = cancelar;

            return ventana.ShowDialog(this) ==
                   DialogResult.OK
                ? cajaTexto.Text.Trim()
                : "";
        }

        private Control? BuscarControlPorTexto(
            Control contenedor,
            string texto)
        {
            foreach (Control control
                in contenedor.Controls)
            {
                if (!string.IsNullOrWhiteSpace(control.Text) &&
                    control.Text.Contains(
                        texto,
                        StringComparison.OrdinalIgnoreCase))
                {
                    return control;
                }

                if (control.HasChildren)
                {
                    Control? encontrado =
                        BuscarControlPorTexto(
                            control,
                            texto
                        );

                    if (encontrado != null)
                    {
                        return encontrado;
                    }
                }
            }

            return null;
        }

        private IEnumerable<Control> ObtenerControles(
            Control contenedor)
        {
            foreach (Control control
                in contenedor.Controls)
            {
                yield return control;

                if (control.HasChildren)
                {
                    foreach (Control controlHijo
                        in ObtenerControles(control))
                    {
                        yield return controlHijo;
                    }
                }
            }
        }

        private Control? BuscarIconoCercaDelTextBox(
            TextBox textBox)
        {
            Rectangle areaTextBox =
                textBox.RectangleToScreen(
                    textBox.ClientRectangle
                );

            Control? controlCercano = null;
            double menorDistancia = double.MaxValue;

            foreach (Control control
                in ObtenerControles(this))
            {
                if (!control.Visible ||
                    control == textBox)
                {
                    continue;
                }

                string nombreTipo =
                    control.GetType().Name;

                bool esIcono =
                    control is PictureBox ||
                    control is Button ||
                    nombreTipo.Contains(
                        "IconPictureBox"
                    ) ||
                    nombreTipo.Contains(
                        "IconButton"
                    );

                if (!esIcono)
                {
                    continue;
                }

                Rectangle areaControl =
                    control.RectangleToScreen(
                        control.ClientRectangle
                    );

                int diferenciaVertical =
                    Math.Abs(
                        areaControl.Top -
                        areaTextBox.Top
                    );

                int diferenciaHorizontal =
                    Math.Min(
                        Math.Abs(
                            areaControl.Right -
                            areaTextBox.Left
                        ),
                        Math.Abs(
                            areaControl.Left -
                            areaTextBox.Right
                        )
                    );

                if (diferenciaVertical > 45 ||
                    diferenciaHorizontal > 100)
                {
                    continue;
                }

                double distancia =
                    diferenciaVertical +
                    diferenciaHorizontal;

                if (distancia < menorDistancia)
                {
                    menorDistancia = distancia;
                    controlCercano = control;
                }
            }

            return controlCercano;
        }

        private string ObtenerColumnaEstado(
            MySqlConnection conexion)
        {
            using MySqlCommand comando =
                new MySqlCommand(
                    @"SHOW COLUMNS FROM Cita
                      LIKE 'estado_cita';",
                    conexion
                );

            object? resultado = comando.ExecuteScalar();

            return resultado != null
                ? "estado_cita"
                : "estado";
        }

        private void ConectarEventosMenu()
        {
            menuEmpleado.InicioClick +=
                btnInicio_empleado_Click;

            menuEmpleado.NuevaCitaClick +=
                lblNuevaCita_Click;

            menuEmpleado.ProgramadasClick +=
                lblProgramadas_Click;

            menuEmpleado.HistorialClick +=
                lblHistorial_Click;

            menuEmpleado.MedicosClick +=
                lblMedicos_Especialidades_Click;

            menuEmpleado.PacientesClick +=
                lblPacientes_Click;
        }

        private void AbrirFormulario(Form formulario)
        {
            Hide();

            formulario.FormClosed += (sender, e) =>
            {
                Show();
                BringToFront();
            };

            formulario.Show();
        }

        private void btnInicio_empleado_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarInicio();
            Show();
            BringToFront();
        }

        private void lblNuevaCita_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarNuevaCita();

            Registro_de_paciente registro =
                new Registro_de_paciente();

            AbrirFormulario(registro);
        }

        private void lblProgramadas_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarProgramadas();

            FormCitas_programadas programadas =
                new FormCitas_programadas();

            AbrirFormulario(programadas);
        }

        private void lblHistorial_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarHistorial();

            FormHistorial_de_consultas historial =
                new FormHistorial_de_consultas();

            AbrirFormulario(historial);
        }

        private void lblMedicos_Especialidades_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarMedicos();

            FormMédicos_y_Especialidades medicos =
                new FormMédicos_y_Especialidades();

            AbrirFormulario(medicos);
        }

        private void lblPacientes_Click(
            object? sender,
            EventArgs e)
        {
            menuEmpleado.SeleccionarPacientes();

            FormPaciente pacientes =
                new FormPaciente();

            AbrirFormulario(pacientes);
        }

        private void RedondearPanel(
            Panel panel,
            int radio)
        {
            if (panel.Width <= 0 ||
                panel.Height <= 0)
            {
                return;
            }

            using GraphicsPath path =
                new GraphicsPath();

            path.StartFigure();

            path.AddArc(
                new Rectangle(
                    0,
                    0,
                    radio,
                    radio
                ),
                180,
                90
            );

            path.AddArc(
                new Rectangle(
                    panel.Width - radio,
                    0,
                    radio,
                    radio
                ),
                270,
                90
            );

            path.AddArc(
                new Rectangle(
                    panel.Width - radio,
                    panel.Height - radio,
                    radio,
                    radio
                ),
                0,
                90
            );

            path.AddArc(
                new Rectangle(
                    0,
                    panel.Height - radio,
                    radio,
                    radio
                ),
                90,
                90
            );

            path.CloseFigure();

            panel.Region =
                new Region(path);
        }

        private void FormEmpleado_Load(
            object sender,
            EventArgs e)
        {
            RedondearPanel(panel6, 25);
            RedondearPanel(panel5, 25);
            RedondearPanel(panel7, 25);
        }

        private void label21_Click(
            object sender,
            EventArgs e)
        {
        }

        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(
            object sender,
            DateRangeEventArgs e)
        {
        }

        private void label20_Click(
            object sender,
            EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged_1(
            object sender,
            DateRangeEventArgs e)
        {
        }

        private void panel6_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void label16_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label3_Click(
            object sender,
            EventArgs e)
        {
        }

        private void ucMenuEmpleado1_Load(
            object sender,
            EventArgs e)
        {
        }

        private void panel7_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}