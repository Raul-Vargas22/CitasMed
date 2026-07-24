namespace CitasMed
{
    partial class FormCitas_programadas
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
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            ucMenuEmpleado1 = new UcMenuEmpleado();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(326, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1033, 511);
            dataGridView1.TabIndex = 72;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            label7.Location = new Point(431, 498);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 412);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 289);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 332);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 195);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 60;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1133, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(507, 123);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 69;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(382, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(155, 179, 232);
            label10.Location = new Point(1227, 30);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 70;
            label10.Text = "EMPLEADO";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 530);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 65;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(326, 593);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 79;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(488, 593);
            button3.Name = "button3";
            button3.Size = new Size(140, 50);
            button3.TabIndex = 80;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(488, 7);
            panel7.Name = "panel7";
            panel7.Size = new Size(296, 51);
            panel7.TabIndex = 81;
            panel7.Paint += panel7_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(47, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 20);
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
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(3, 8);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 65;
            iconPictureBox4.TabStop = false;
            // 
            // ucMenuEmpleado1
            // 
            ucMenuEmpleado1.Location = new Point(2, 4);
            ucMenuEmpleado1.Name = "ucMenuEmpleado1";
            ucMenuEmpleado1.Size = new Size(281, 647);
            ucMenuEmpleado1.TabIndex = 82;
            ucMenuEmpleado1.Load += ucMenuEmpleado1_Load;
            // 
            // FormCitas_programadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1371, 655);
            Controls.Add(ucMenuEmpleado1);
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
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label8);
            Name = "FormCitas_programadas";
            Text = "FormCitas_programadas";
            Load += FormCitas_programadas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
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
        private Label label10;
        private Label label8;
        private Button button2;
        private Button button3;
        private Panel panel7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private UcMenuEmpleado ucMenuEmpleado1;
    }
}