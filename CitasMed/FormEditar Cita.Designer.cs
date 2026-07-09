namespace CitasMed
{
    partial class FormEditar_Cita
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
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(1219, 705);
            button3.Name = "button3";
            button3.Size = new Size(140, 50);
            button3.TabIndex = 96;
            button3.Text = "REGRESAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(1042, 705);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 95;
            button2.Text = "MODIFICAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(326, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1033, 561);
            dataGridView1.TabIndex = 93;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 664);
            panel1.TabIndex = 87;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ActiveCaption;
            label26.Location = new Point(13, 440);
            label26.Name = "label26";
            label26.Size = new Size(135, 21);
            label26.TabIndex = 31;
            label26.Text = "> PACIENTES";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ActiveCaption;
            label25.Location = new Point(11, 367);
            label25.Name = "label25";
            label25.Size = new Size(188, 42);
            label25.TabIndex = 30;
            label25.Text = "> MÉDICOS Y \r\n  ESPECIALIDADES";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaption;
            label24.Location = new Point(13, 297);
            label24.Name = "label24";
            label24.Size = new Size(167, 42);
            label24.TabIndex = 29;
            label24.Text = "> HISTORIAL DE \r\n  CONSULTAS";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.SkyBlue;
            label23.Location = new Point(13, 244);
            label23.Name = "label23";
            label23.Size = new Size(244, 21);
            label23.TabIndex = 28;
            label23.Text = "> CITAS PROGRAMADAS";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaption;
            label22.Location = new Point(13, 187);
            label22.Name = "label22";
            label22.Size = new Size(148, 21);
            label22.TabIndex = 27;
            label22.Text = "> NUEVA CITA";
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(25, 127);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Image.FromFile(@"Resources\Captura de pantalla 2026-07-07 224942.png");
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
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(93, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "CITASMED";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Image.FromFile(@"Resources\Captura de pantalla 2026-07-9 100743.png");
            pictureBox3.Location = new Point(1133, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 92;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 527);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 441);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 84;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 318);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 83;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 361);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 82;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 224);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(577, 152);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 90;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Image.FromFile(@"Resources\Captura de pantalla 2026-07-07 230124.png");
            pictureBox2.Location = new Point(397, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 89;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(435, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 88;
            textBox1.Text = "EDITAR";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1227, 35);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 91;
            label10.Text = "EMPLEADO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(558, 559);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 86;
            // 
            // Column1
            // 
            Column1.HeaderText = "CLAVE DE LA CITA";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "CÓDIGO DEL PACIENTE";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "NOMBRE COMPLETO DEL PACIENTE";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = " TELÉFONO ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "CURP";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "ESPECIALIDAD QUE ASISTIRA";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "FECHA DE CITA";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "NUEVA CITA";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // FormEditar_Cita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 786);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label8);
            Name = "FormEditar_Cita";
            Text = "FormEditar_Cita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label9;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}