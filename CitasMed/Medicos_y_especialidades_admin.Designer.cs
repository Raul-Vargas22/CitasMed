namespace CitasMed
{
    partial class Medicos_y_espcialidades_admin
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
            textBox1 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 210, 208);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(434, 3);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 61);
            panel1.TabIndex = 88;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(61, 15);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 24);
            textBox1.TabIndex = 47;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6 });
            dataGridView1.Location = new Point(438, 105);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1404, 675);
            dataGridView1.TabIndex = 87;
            // 
            // Column1
            // 
            Column1.HeaderText = "NOMBRE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "APELLIDO PATERNO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 240;
            // 
            // Column3
            // 
            Column3.HeaderText = "APELLIDO MATERNO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 240;
            // 
            // Column5
            // 
            Column5.HeaderText = "ESPECIALIDAD";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 240;
            // 
            // Column6
            // 
            Column6.HeaderText = "CÉDULA ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(378, 493);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 339);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 80;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(822, 3);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 86;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(512, 132);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(953, 24);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(238, 27);
            label10.TabIndex = 85;
            label10.Text = "ADMINISTRADOR";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.FromArgb(155, 179, 232);
            lblPacientes.Location = new Point(32, 533);
            lblPacientes.Margin = new Padding(4, 0, 4, 0);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(147, 25);
            lblPacientes.TabIndex = 94;
            lblPacientes.Text = "PACIENTES";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.FromArgb(155, 179, 232);
            lblRegistrar.Location = new Point(32, 224);
            lblRegistrar.Margin = new Padding(4, 0, 4, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(180, 25);
            lblRegistrar.TabIndex = 93;
            lblRegistrar.Text = "> NUEVA CITA";
            // 
            // lblProgramadas
            // 
            lblProgramadas.AutoSize = true;
            lblProgramadas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramadas.ForeColor = Color.FromArgb(155, 179, 232);
            lblProgramadas.Location = new Point(32, 322);
            lblProgramadas.Margin = new Padding(4, 0, 4, 0);
            lblProgramadas.Name = "lblProgramadas";
            lblProgramadas.Size = new Size(295, 25);
            lblProgramadas.TabIndex = 92;
            lblProgramadas.Text = "> CITAS PROGRAMADAS";
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.BackColor = Color.Transparent;
            lblConsultas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultas.ForeColor = Color.FromArgb(155, 179, 232);
            lblConsultas.Location = new Point(32, 376);
            lblConsultas.Margin = new Padding(4, 0, 4, 0);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(205, 50);
            lblConsultas.TabIndex = 91;
            lblConsultas.Text = "> HISTORIAL DE \r\nCONSULTAS";
            // 
            // lblMedicos_especialidades
            // 
            lblMedicos_especialidades.AutoSize = true;
            lblMedicos_especialidades.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos_especialidades.ForeColor = Color.FromArgb(155, 179, 232);
            lblMedicos_especialidades.Location = new Point(32, 441);
            lblMedicos_especialidades.Margin = new Padding(4, 0, 4, 0);
            lblMedicos_especialidades.Name = "lblMedicos_especialidades";
            lblMedicos_especialidades.Size = new Size(220, 50);
            lblMedicos_especialidades.TabIndex = 90;
            lblMedicos_especialidades.Text = "> MEDICOS Y  \r\nESPECIALIDADES";
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(14, 7);
            ucMenuAdministrador1.Margin = new Padding(5);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(331, 782);
            ucMenuAdministrador1.TabIndex = 89;
            // 
            // Medicos_y_espcialidades_admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1661, 671);
            Controls.Add(lblPacientes);
            Controls.Add(lblRegistrar);
            Controls.Add(lblProgramadas);
            Controls.Add(lblConsultas);
            Controls.Add(lblMedicos_especialidades);
            Controls.Add(ucMenuAdministrador1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(label10);
            Name = "Medicos_y_espcialidades_admin";
            Text = "Medicos_y_espcialidades_admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label6;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label10;
        private Label lblPacientes;
        private Label lblRegistrar;
        private Label lblProgramadas;
        private Label lblConsultas;
        private Label lblMedicos_especialidades;
        private UcMenuAdministrador ucMenuAdministrador1;
    }
}