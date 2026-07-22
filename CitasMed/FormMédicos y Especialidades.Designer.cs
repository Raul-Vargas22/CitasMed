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
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            ucMenuEmpleado1 = new UcMenuEmpleado();
            panel1 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column6 });
            dataGridView1.Location = new Point(299, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1123, 540);
            dataGridView1.TabIndex = 72;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(452, 490);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(421, 404);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 281);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 324);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 187);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 60;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(776, 12);
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
            label9.Location = new Point(528, 115);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 69;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(881, 29);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 70;
            label10.Text = "EMPLEADO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(509, 522);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 65;
            // 
            // ucMenuEmpleado1
            // 
            ucMenuEmpleado1.Location = new Point(2, 4);
            ucMenuEmpleado1.Name = "ucMenuEmpleado1";
            ucMenuEmpleado1.Size = new Size(281, 647);
            ucMenuEmpleado1.TabIndex = 78;
            ucMenuEmpleado1.Load += ucMenuEmpleado1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 210, 208);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(466, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 49);
            panel1.TabIndex = 79;
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
            // FormMédicos_y_Especialidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 658);
            Controls.Add(panel1);
            Controls.Add(ucMenuEmpleado1);
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
            Name = "FormMédicos_y_Especialidades";
            Text = "FormMédicos_y_Especialidades";
            Load += FormMédicos_y_Especialidades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label9;
        private Label label10;
        private Label label8;
        private UcMenuEmpleado ucMenuEmpleado1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Panel panel1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}