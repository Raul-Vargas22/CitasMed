namespace CitasMed
{
    partial class FormMédicos_y_Especialidades
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            btnRegresar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label16 = new Label();
            textBox6 = new TextBox();
            label15 = new Label();
            textBox5 = new TextBox();
            label14 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            textBox3 = new TextBox();
            label12 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(439, 138);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1004, 719);
            dataGridView1.TabIndex = 72;
            // 
            // Column1
            // 
            Column1.HeaderText = "NOMBRE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "APELLIDO PATERNO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "APELLIDO MATERNO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "CARGO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "ESPECIALIDAD";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "CÉDULA ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label26);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(label24);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(label22);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(48, 32);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 824);
            panel1.TabIndex = 66;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ActiveCaption;
            label26.Location = new Point(16, 550);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(164, 25);
            label26.TabIndex = 31;
            label26.Text = "> PACIENTES";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.SkyBlue;
            label25.Location = new Point(14, 459);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(232, 50);
            label25.TabIndex = 30;
            label25.Text = "> MÉDICOS Y \r\n  ESPECIALIDADES";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ActiveCaption;
            label24.Location = new Point(16, 371);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(205, 50);
            label24.TabIndex = 29;
            label24.Text = "> HISTORIAL DE \r\n  CONSULTAS";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ActiveCaption;
            label23.Location = new Point(16, 305);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(295, 25);
            label23.TabIndex = 28;
            label23.Text = "> CITAS PROGRAMADAS";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaption;
            label22.Location = new Point(16, 234);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(180, 25);
            label22.TabIndex = 27;
            label22.Text = "> NUEVA CITA";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Turquoise;
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.Location = new Point(16, 634);
            btnRegresar.Margin = new Padding(4, 4, 4, 4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(118, 36);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 18);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(116, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 24);
            label1.TabIndex = 2;
            label1.Text = "CITASMED";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 612);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 505);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 351);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(710, 405);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(615, 234);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 60;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1399, 12);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
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
            label9.Location = new Point(660, 144);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 69;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(568, 26);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(615, 28);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 67;
            textBox1.Text = "BUSCAR DOCTOR POR CLAVE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1516, 28);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(238, 27);
            label10.TabIndex = 70;
            label10.Text = "ADMINISTRADOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(636, 652);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 65;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(1475, 191);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 681);
            panel2.TabIndex = 73;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(21, 615);
            textBox7.Margin = new Padding(4, 4, 4, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(214, 31);
            textBox7.TabIndex = 86;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaption;
            label16.Location = new Point(21, 569);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(198, 25);
            label16.TabIndex = 85;
            label16.Text = "ESPECIALIDAD:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(21, 506);
            textBox6.Margin = new Padding(4, 4, 4, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(214, 31);
            textBox6.TabIndex = 84;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaption;
            label15.Location = new Point(21, 460);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(104, 25);
            label15.TabIndex = 83;
            label15.Text = "CARGO:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 389);
            textBox5.Margin = new Padding(4, 4, 4, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(214, 31);
            textBox5.TabIndex = 82;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaption;
            label14.Location = new Point(21, 342);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(118, 25);
            label14.TabIndex = 81;
            label14.Text = "CÉDULA:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 285);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 31);
            textBox4.TabIndex = 80;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaption;
            label13.Location = new Point(21, 239);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(264, 25);
            label13.TabIndex = 79;
            label13.Text = "APELLIDO MATERNO:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 174);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 31);
            textBox3.TabIndex = 78;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(21, 128);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(260, 25);
            label12.TabIndex = 77;
            label12.Text = "APELLIDO PATERNO:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 68);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 31);
            textBox2.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(21, 21);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(121, 25);
            label11.TabIndex = 75;
            label11.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1481, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(282, 32);
            label3.TabIndex = 74;
            label3.Text = "Agregar empleado:";
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(1549, 910);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(175, 62);
            button2.TabIndex = 75;
            button2.Text = "REGISTRAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(461, 896);
            button3.Margin = new Padding(4, 4, 4, 4);
            button3.Name = "button3";
            button3.Size = new Size(175, 62);
            button3.TabIndex = 76;
            button3.Text = "EDITAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Turquoise;
            button4.Location = new Point(660, 896);
            button4.Margin = new Padding(4, 4, 4, 4);
            button4.Name = "button4";
            button4.Size = new Size(175, 62);
            button4.TabIndex = 77;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormMédicos_y_Especialidades
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1834, 1050);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label8);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMédicos_y_Especialidades";
            Text = "FormMédicos_y_Especialidades";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button btnRegresar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
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
        private Panel panel2;
        private Label label3;
        private TextBox textBox7;
        private Label label16;
        private TextBox textBox6;
        private Label label15;
        private TextBox textBox5;
        private Label label14;
        private TextBox textBox4;
        private Label label13;
        private TextBox textBox3;
        private Label label12;
        private TextBox textBox2;
        private Label label11;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}