namespace CitasMed
{
    partial class FormHistorial_de_consultas
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
            label31 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            label30 = new Label();
            label28 = new Label();
            label27 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            label10 = new Label();
            ucMenuEmpleado1 = new UcMenuEmpleado();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.SkyBlue;
            label31.Location = new Point(333, 96);
            label31.Name = "label31";
            label31.Size = new Size(242, 21);
            label31.TabIndex = 29;
            label31.Text = " CITAS RELACIONADAS:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(298, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 327);
            dataGridView1.TabIndex = 57;
            // 
            // Column1
            // 
            Column1.HeaderText = "PACIENTES";
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
            panel7.Controls.Add(label31);
            panel7.Controls.Add(label30);
            panel7.Controls.Add(label28);
            panel7.Controls.Add(label27);
            panel7.Location = new Point(298, 430);
            panel7.Name = "panel7";
            panel7.Size = new Size(803, 215);
            panel7.TabIndex = 59;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.SkyBlue;
            label30.Location = new Point(333, 25);
            label30.Name = "label30";
            label30.Size = new Size(178, 21);
            label30.TabIndex = 28;
            label30.Text = "SIGNOS VITALES:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.SkyBlue;
            label28.Location = new Point(15, 96);
            label28.Name = "label28";
            label28.Size = new Size(162, 21);
            label28.TabIndex = 26;
            label28.Text = "TRATAMIENTO:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.SkyBlue;
            label27.Location = new Point(15, 26);
            label27.Name = "label27";
            label27.Size = new Size(157, 20);
            label27.TabIndex = 25;
            label27.Text = " DIAGNÓSTICO : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 493);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 407);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 284);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 327);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 190);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 40;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(822, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(528, 118);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(49, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 20);
            textBox1.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 525);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(916, 24);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 50;
            label10.Text = "EMPLEADO";
            // 
            // ucMenuEmpleado1
            // 
            ucMenuEmpleado1.Dock = DockStyle.Left;
            ucMenuEmpleado1.Location = new Point(0, 0);
            ucMenuEmpleado1.Name = "ucMenuEmpleado1";
            ucMenuEmpleado1.Size = new Size(281, 657);
            ucMenuEmpleado1.TabIndex = 60;
            ucMenuEmpleado1.Load += ucMenuEmpleado1_Load;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 61;
            iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 210, 208);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(421, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 49);
            panel1.TabIndex = 62;
            // 
            // FormHistorial_de_consultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 657);
            Controls.Add(panel1);
            Controls.Add(ucMenuEmpleado1);
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
            Name = "FormHistorial_de_consultas";
            Text = "FormHistorial_de_consultas";
            Load += FormHistorial_de_consultas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label31;
        private DataGridView dataGridView1;
        private Panel panel7;
        private Label label30;
        private Label label28;
        private Label label27;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private UcMenuEmpleado ucMenuEmpleado1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel1;
    }
}