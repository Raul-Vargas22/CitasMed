namespace CitasMed
{
    partial class FormCitas_programadas_admin
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
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            lblPacientes = new Label();
            lblRegistrar = new Label();
            lblProgramadas = new Label();
            lblConsultas = new Label();
            lblMedicos_especialidades = new Label();
            ucMenuAdministrador1 = new UcMenuAdministrador();
            pictureBox1 = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(622, 18);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 64);
            panel7.TabIndex = 96;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(59, 18);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 24);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 50;
            iconPictureBox4.Location = new Point(4, 10);
            iconPictureBox4.Margin = new Padding(4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(50, 50);
            iconPictureBox4.TabIndex = 65;
            iconPictureBox4.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(622, 750);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(175, 62);
            button3.TabIndex = 95;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(420, 750);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(175, 62);
            button2.TabIndex = 94;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(420, 89);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1291, 639);
            dataGridView1.TabIndex = 93;
            // 
            // Column1
            // 
            Column1.HeaderText = "CLAVE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "PACIENTE";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "TELÉFONO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "ESPECIALIDAD";
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
            Column6.HeaderText = "FECHA";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "HORA";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "MOTIVÓ ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(551, 631);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 524);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 86;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(507, 370);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 85;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 424);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(601, 253);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 83;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1428, 31);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 92;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(646, 163);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(155, 179, 232);
            label10.Location = new Point(1546, 47);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(229, 27);
            label10.TabIndex = 91;
            label10.Text = "ADMINSTRADOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(622, 671);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 88;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.FromArgb(155, 179, 232);
            lblPacientes.Location = new Point(44, 554);
            lblPacientes.Margin = new Padding(4, 0, 4, 0);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(147, 25);
            lblPacientes.TabIndex = 102;
            lblPacientes.Text = "PACIENTES";
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.FromArgb(155, 179, 232);
            lblRegistrar.Location = new Point(44, 245);
            lblRegistrar.Margin = new Padding(4, 0, 4, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(180, 25);
            lblRegistrar.TabIndex = 101;
            lblRegistrar.Text = "> NUEVA CITA";
            // 
            // lblProgramadas
            // 
            lblProgramadas.AutoSize = true;
            lblProgramadas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramadas.ForeColor = Color.FromArgb(155, 179, 232);
            lblProgramadas.Location = new Point(44, 343);
            lblProgramadas.Margin = new Padding(4, 0, 4, 0);
            lblProgramadas.Name = "lblProgramadas";
            lblProgramadas.Size = new Size(295, 25);
            lblProgramadas.TabIndex = 100;
            lblProgramadas.Text = "> CITAS PROGRAMADAS";
            lblProgramadas.Click += lblProgramadas_Click;
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.BackColor = Color.Transparent;
            lblConsultas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultas.ForeColor = Color.FromArgb(155, 179, 232);
            lblConsultas.Location = new Point(44, 397);
            lblConsultas.Margin = new Padding(4, 0, 4, 0);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(205, 50);
            lblConsultas.TabIndex = 99;
            lblConsultas.Text = "> HISTORIAL DE \r\nCONSULTAS";
            // 
            // lblMedicos_especialidades
            // 
            lblMedicos_especialidades.AutoSize = true;
            lblMedicos_especialidades.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos_especialidades.ForeColor = Color.FromArgb(155, 179, 232);
            lblMedicos_especialidades.Location = new Point(44, 462);
            lblMedicos_especialidades.Margin = new Padding(4, 0, 4, 0);
            lblMedicos_especialidades.Name = "lblMedicos_especialidades";
            lblMedicos_especialidades.Size = new Size(220, 50);
            lblMedicos_especialidades.TabIndex = 98;
            lblMedicos_especialidades.Text = "> MEDICOS Y  \r\nESPECIALIDADES";
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(26, 28);
            ucMenuAdministrador1.Margin = new Padding(5);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(331, 782);
            ucMenuAdministrador1.TabIndex = 97;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(489, 31);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 103;
            pictureBox1.TabStop = false;
            // 
            // FormCitas_programadas_admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1790, 854);
            Controls.Add(pictureBox1);
            Controls.Add(lblPacientes);
            Controls.Add(lblRegistrar);
            Controls.Add(lblProgramadas);
            Controls.Add(lblConsultas);
            Controls.Add(lblMedicos_especialidades);
            Controls.Add(ucMenuAdministrador1);
            Controls.Add(panel7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Name = "FormCitas_programadas_admin";
            Text = "FormCitas_programadas_admin";
            Load += FormCitas_programadas_admin_Load_1;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label lblPacientes;
        private Label lblRegistrar;
        private Label lblProgramadas;
        private Label lblConsultas;
        private Label lblMedicos_especialidades;
        private UcMenuAdministrador ucMenuAdministrador1;
        private PictureBox pictureBox1;
    }
}