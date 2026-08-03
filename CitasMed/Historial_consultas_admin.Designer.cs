namespace CitasMed
{
    partial class Historial_consultas_admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtBuscarHistorial = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            txtTratamiento = new TextBox();
            txtDiagnostico = new TextBox();
            label28 = new Label();
            label27 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            lblPacientes = new Label();
            lblRegistrar = new Label();
            lblProgramadas = new Label();
            lblConsultas = new Label();
            lblMedicos_especialidades = new Label();
            ucMenuAdministrador1 = new UcMenuAdministrador();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 210, 208);
            panel1.Controls.Add(txtBuscarHistorial);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(518, -1);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 61);
            panel1.TabIndex = 74;
            // 
            // txtBuscarHistorial
            // 
            txtBuscarHistorial.BackColor = Color.FromArgb(133, 210, 208);
            txtBuscarHistorial.BorderStyle = BorderStyle.None;
            txtBuscarHistorial.Location = new Point(61, 15);
            txtBuscarHistorial.Margin = new Padding(4);
            txtBuscarHistorial.Name = "txtBuscarHistorial";
            txtBuscarHistorial.Size = new Size(271, 24);
            txtBuscarHistorial.TabIndex = 47;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 50;
            iconPictureBox1.Location = new Point(4, 4);
            iconPictureBox1.Margin = new Padding(4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(50, 50);
            iconPictureBox1.TabIndex = 61;
            iconPictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(364, 105);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1004, 409);
            dataGridView1.TabIndex = 72;
            // 
            // Column1
            // 
            Column1.HeaderText = "PACIENTE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "CLAVE";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "EDAD";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "TELÉFONO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "DOCTOR";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "ESPECIALIDAD";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(txtTratamiento);
            panel7.Controls.Add(txtDiagnostico);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label27);
            panel7.Location = new Point(364, 522);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1004, 269);
            panel7.TabIndex = 73;
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(508, 61);
            txtTratamiento.Margin = new Padding(4);
            txtTratamiento.Multiline = true;
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.ReadOnly = true;
            txtTratamiento.ScrollBars = ScrollBars.Vertical;
            txtTratamiento.Size = new Size(454, 179);
            txtTratamiento.TabIndex = 28;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(29, 61);
            txtDiagnostico.Margin = new Padding(4);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.ReadOnly = true;
            txtDiagnostico.ScrollBars = ScrollBars.Vertical;
            txtDiagnostico.Size = new Size(419, 179);
            txtDiagnostico.TabIndex = 27;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.SkyBlue;
            label28.Location = new Point(508, 32);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(195, 25);
            label28.TabIndex = 26;
            label28.Text = "TRATAMIENTO:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.SkyBlue;
            label27.Location = new Point(19, 32);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(193, 24);
            label27.TabIndex = 25;
            label27.Text = " DIAGNÓSTICO : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(557, 600);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(518, 493);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(513, 339);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(702, 393);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 63;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1020, 3);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(652, 132);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(628, 640);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1137, 14);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(238, 27);
            label10.TabIndex = 70;
            label10.Text = "ADMINSITRADOR";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.FromArgb(155, 179, 232);
            lblPacientes.Location = new Point(32, 531);
            lblPacientes.Margin = new Padding(4, 0, 4, 0);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(147, 25);
            lblPacientes.TabIndex = 108;
            lblPacientes.Text = "PACIENTES";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.FromArgb(155, 179, 232);
            lblRegistrar.Location = new Point(32, 222);
            lblRegistrar.Margin = new Padding(4, 0, 4, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(180, 25);
            lblRegistrar.TabIndex = 107;
            lblRegistrar.Text = "> NUEVA CITA";
            // 
            // lblProgramadas
            // 
            lblProgramadas.AutoSize = true;
            lblProgramadas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramadas.ForeColor = Color.FromArgb(155, 179, 232);
            lblProgramadas.Location = new Point(32, 320);
            lblProgramadas.Margin = new Padding(4, 0, 4, 0);
            lblProgramadas.Name = "lblProgramadas";
            lblProgramadas.Size = new Size(295, 25);
            lblProgramadas.TabIndex = 106;
            lblProgramadas.Text = "> CITAS PROGRAMADAS";
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.BackColor = Color.Transparent;
            lblConsultas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultas.ForeColor = Color.FromArgb(155, 179, 232);
            lblConsultas.Location = new Point(32, 374);
            lblConsultas.Margin = new Padding(4, 0, 4, 0);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(205, 50);
            lblConsultas.TabIndex = 105;
            lblConsultas.Text = "> HISTORIAL DE \r\nCONSULTAS";
            // 
            // lblMedicos_especialidades
            // 
            lblMedicos_especialidades.AutoSize = true;
            lblMedicos_especialidades.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos_especialidades.ForeColor = Color.FromArgb(155, 179, 232);
            lblMedicos_especialidades.Location = new Point(32, 439);
            lblMedicos_especialidades.Margin = new Padding(4, 0, 4, 0);
            lblMedicos_especialidades.Name = "lblMedicos_especialidades";
            lblMedicos_especialidades.Size = new Size(220, 50);
            lblMedicos_especialidades.TabIndex = 104;
            lblMedicos_especialidades.Text = "> MEDICOS Y  \r\nESPECIALIDADES";
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(14, 5);
            ucMenuAdministrador1.Margin = new Padding(5);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(331, 782);
            ucMenuAdministrador1.TabIndex = 103;
            ucMenuAdministrador1.Load += ucMenuAdministrador1_Load;
            // 
            // Historial_consultas_admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 778);
            Controls.Add(lblPacientes);
            Controls.Add(lblRegistrar);
            Controls.Add(lblProgramadas);
            Controls.Add(lblConsultas);
            Controls.Add(lblMedicos_especialidades);
            Controls.Add(ucMenuAdministrador1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label10);
            Name = "Historial_consultas_admin";
            Text = "Historial_consultas_admin";
            Load += Historial_consultas_admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtBuscarHistorial;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel7;
        private TextBox txtTratamiento;
        private TextBox txtDiagnostico;
        private Label label28;
        private Label label27;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label lblPacientes;
        private Label lblRegistrar;
        private Label lblProgramadas;
        private Label lblConsultas;
        private Label lblMedicos_especialidades;
        private UcMenuAdministrador ucMenuAdministrador1;
    }
}