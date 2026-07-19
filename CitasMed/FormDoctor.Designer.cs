namespace CitasMed
{
    partial class FormDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoctor));
            label10 = new Label();
            label9 = new Label();
            label18 = new Label();
            label19 = new Label();
            label21 = new Label();
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            btnGuardar = new Button();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1285, 50);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 50;
            label10.Text = "DOCTOR";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 362);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 56;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(326, 239);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(477, 282);
            label19.Name = "label19";
            label19.Size = new Size(0, 20);
            label19.TabIndex = 54;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(402, 146);
            label21.Name = "label21";
            label21.Size = new Size(0, 20);
            label21.TabIndex = 53;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(565, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(296, 47);
            panel7.TabIndex = 67;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(47, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 20);
            textBox1.TabIndex = 0;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(3, 0);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(40, 40);
            iconPictureBox4.TabIndex = 65;
            iconPictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 639);
            panel1.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 69;
            label1.Text = "Registro de datalles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 313);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 69;
            label2.Text = "Tratamiento :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 336);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 284);
            textBox2.TabIndex = 69;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 60);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 238);
            textBox3.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 37);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 69;
            label3.Text = "Diagnostico :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(381, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1036, 490);
            dataGridView1.TabIndex = 69;
            // 
            // Column1
            // 
            Column1.HeaderText = "Curp";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 180;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido_Paterno";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // Column4
            // 
            Column4.HeaderText = "Apellido_Materno";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 180;
            // 
            // Column5
            // 
            Column5.HeaderText = "Enfermedades_Cronicas";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Fecha";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(389, 84);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 70;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(133, 210, 208);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(389, 591);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 52);
            btnGuardar.TabIndex = 71;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1429, 655);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel7);
            Controls.Add(label9);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(label10);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormDoctor";
            Text = "FormDoctor";
            Load += FormDoctor_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label23;
        private Label label22;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnGuardar;
        private Button button2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label20;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnInicio_Doc;
        private PictureBox pictureBox3;
        private Label label10;
        private Panel panel4;
        private Label label17;
        private Label label12;
        private Panel panel3;
        private Label label16;
        private Label label3;
        private Panel panel2;
        private Label label13;
        private Label label14;
        private Label label2;
        private Label label15;
        private Label label11;
        private Label label9;
        private Label label18;
        private Label label19;
        private Label label21;
        private Panel panel7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}