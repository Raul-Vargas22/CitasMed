namespace CitasMed
{
    partial class UcMenuEmpleado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMenuEmpleado));
            panel1 = new Panel();
            lblNuevaCita = new Label();
            btnInicio_empleado = new Button();
            lblPacientes = new Label();
            lblMedicos_Especialidades = new Label();
            lblHistorial = new Label();
            lblProgramadas = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblNuevaCita);
            panel1.Controls.Add(btnInicio_empleado);
            panel1.Controls.Add(lblPacientes);
            panel1.Controls.Add(lblMedicos_Especialidades);
            panel1.Controls.Add(lblHistorial);
            panel1.Controls.Add(lblProgramadas);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 643);
            panel1.TabIndex = 45;
            panel1.Paint += panel1_Paint_2;
            // 
            // lblNuevaCita
            // 
            lblNuevaCita.AutoSize = true;
            lblNuevaCita.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaCita.ForeColor = Color.FromArgb(155, 179, 232);
            lblNuevaCita.Location = new Point(13, 176);
            lblNuevaCita.Name = "lblNuevaCita";
            lblNuevaCita.Size = new Size(148, 21);
            lblNuevaCita.TabIndex = 33;
            lblNuevaCita.Text = "> NUEVA CITA";
            lblNuevaCita.Click += lblNuevaCita_Click;
            // 
            // btnInicio_empleado
            // 
            btnInicio_empleado.BackColor = Color.FromArgb(133, 210, 208);
            btnInicio_empleado.BackgroundImageLayout = ImageLayout.None;
            btnInicio_empleado.FlatStyle = FlatStyle.Flat;
            btnInicio_empleado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio_empleado.ForeColor = Color.Black;
            btnInicio_empleado.Location = new Point(54, 108);
            btnInicio_empleado.Name = "btnInicio_empleado";
            btnInicio_empleado.Size = new Size(126, 38);
            btnInicio_empleado.TabIndex = 32;
            btnInicio_empleado.Text = "INICIO";
            btnInicio_empleado.UseVisualStyleBackColor = false;
            btnInicio_empleado.Click += btnInicio_empleado_Click;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.BackColor = Color.Transparent;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.FromArgb(155, 179, 232);
            lblPacientes.Location = new Point(13, 481);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(135, 21);
            lblPacientes.TabIndex = 31;
            lblPacientes.Text = "> PACIENTES";
            lblPacientes.Click += lblPacientes_Click;
            // 
            // lblMedicos_Especialidades
            // 
            lblMedicos_Especialidades.AutoSize = true;
            lblMedicos_Especialidades.BackColor = Color.Transparent;
            lblMedicos_Especialidades.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos_Especialidades.ForeColor = Color.FromArgb(155, 179, 232);
            lblMedicos_Especialidades.Location = new Point(13, 388);
            lblMedicos_Especialidades.Name = "lblMedicos_Especialidades";
            lblMedicos_Especialidades.Size = new Size(188, 42);
            lblMedicos_Especialidades.TabIndex = 30;
            lblMedicos_Especialidades.Text = "> MÉDICOS Y \r\n  ESPECIALIDADES";
            lblMedicos_Especialidades.Click += lblMedicos_Especialidades_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.Transparent;
            lblHistorial.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = Color.FromArgb(155, 179, 232);
            lblHistorial.Location = new Point(13, 299);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(167, 42);
            lblHistorial.TabIndex = 29;
            lblHistorial.Text = "> HISTORIAL DE \r\n  CONSULTAS";
            lblHistorial.Click += lblHistorial_Click;
            // 
            // lblProgramadas
            // 
            lblProgramadas.AutoSize = true;
            lblProgramadas.BackColor = Color.Transparent;
            lblProgramadas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramadas.ForeColor = Color.FromArgb(155, 179, 232);
            lblProgramadas.Location = new Point(13, 241);
            lblProgramadas.Name = "lblProgramadas";
            lblProgramadas.Size = new Size(244, 21);
            lblProgramadas.TabIndex = 28;
            lblProgramadas.Text = "> CITAS PROGRAMADAS";
            lblProgramadas.Click += lblProgramadas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(93, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "CITASMED";
            // 
            // UcMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcMenuEmpleado";
            Size = new Size(281, 643);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNuevaCita;
        private Button btnInicio_empleado;
        private Label lblPacientes;
        private Label lblMedicos_Especialidades;
        private Label lblHistorial;
        private Label lblProgramadas;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
