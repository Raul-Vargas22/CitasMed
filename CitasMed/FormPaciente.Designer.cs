namespace CitasMed
{
    partial class FormPaciente
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
            dgvPacientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            ucMenuEmpleado1 = new UcMenuEmpleado();
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.BackgroundColor = Color.PaleTurquoise;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dgvPacientes.Location = new Point(381, 85);
            dgvPacientes.Margin = new Padding(4, 4, 4, 4);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(1785, 619);
            dgvPacientes.TabIndex = 109;
            dgvPacientes.CellContentClick += dataGridView1_CellContentClick;
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
            Column2.HeaderText = "CURP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "NOMBRE";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "APELLIDO PATERNO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "APELLIDO MATERNO";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "TELÉFONO ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "CALLE";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "COLONIA";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "MUNICIPIO";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "ENFERMEDADES CRONICAS";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "ESPECIALIDAD SOLICITADA";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1715, 15);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 108;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(630, 639);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 101;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 531);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 378);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(775, 431);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(680, 260);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(725, 170);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 106;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1862, 36);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 27);
            label10.TabIndex = 107;
            label10.Text = "EMPLEADO";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(701, 679);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 102;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(570, 734);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(175, 62);
            button3.TabIndex = 112;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(381, 734);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(175, 62);
            button2.TabIndex = 111;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ucMenuEmpleado1
            // 
            ucMenuEmpleado1.Location = new Point(2, 5);
            ucMenuEmpleado1.Margin = new Padding(5, 5, 5, 5);
            ucMenuEmpleado1.Name = "ucMenuEmpleado1";
            ucMenuEmpleado1.Size = new Size(351, 809);
            ucMenuEmpleado1.TabIndex = 113;
            ucMenuEmpleado1.Load += ucMenuEmpleado1_Load;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(566, 5);
            panel7.Margin = new Padding(4, 4, 4, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 60);
            panel7.TabIndex = 114;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(59, 18);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 24);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 50;
            iconPictureBox4.Location = new Point(4, 4);
            iconPictureBox4.Margin = new Padding(4, 4, 4, 4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(50, 50);
            iconPictureBox4.TabIndex = 65;
            iconPictureBox4.TabStop = false;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 821);
            Controls.Add(panel7);
            Controls.Add(ucMenuEmpleado1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dgvPacientes);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormPaciente";
            Text = "FormPaciente";
            Load += FormPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvPacientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Panel panel1;
        private Label lblPacientes;
        private Label lblMedicos;
        private Label lblHistorial;
        private Label lblProgramada;
        private Label lblNueva;
        private Button btnRegresar;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label label10;
        private Label label8;
        private Button button3;
        private Button button2;
        private UcMenuEmpleado ucMenuEmpleado1;
        private Panel panel7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
    }
}