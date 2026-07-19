namespace CitasMed
{
    partial class FormPersonalMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalMedico));
            ucMenuAdministrador1 = new UcMenuAdministrador();
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido_Paterno = new DataGridViewTextBoxColumn();
            Apellido_Materno = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnRegistar = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(2, 0);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(259, 647);
            ucMenuAdministrador1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(457, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(296, 47);
            panel7.TabIndex = 65;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido_Paterno, Apellido_Materno, Cargo, Especialidad, Cedula });
            dataGridView1.Location = new Point(267, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(891, 452);
            dataGridView1.TabIndex = 66;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido_Paterno
            // 
            Apellido_Paterno.HeaderText = "Apellido_paterno";
            Apellido_Paterno.MinimumWidth = 6;
            Apellido_Paterno.Name = "Apellido_Paterno";
            Apellido_Paterno.Width = 170;
            // 
            // Apellido_Materno
            // 
            Apellido_Materno.HeaderText = "Apellido_Materno";
            Apellido_Materno.MinimumWidth = 6;
            Apellido_Materno.Name = "Apellido_Materno";
            Apellido_Materno.Width = 170;
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 125;
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad";
            Especialidad.MinimumWidth = 6;
            Especialidad.Name = "Especialidad";
            Especialidad.Width = 125;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.MinimumWidth = 6;
            Cedula.Name = "Cedula";
            Cedula.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnRegistar);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1175, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 594);
            panel1.TabIndex = 67;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.FromArgb(133, 210, 208);
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.Location = new Point(85, 501);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(135, 52);
            btnRegistar.TabIndex = 68;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(17, 428);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(244, 27);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 347);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(19, 269);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(242, 27);
            textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(17, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(155, 179, 232);
            label7.Location = new Point(17, 405);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 5;
            label7.Text = "Especialidad :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(155, 179, 232);
            label6.Location = new Point(19, 324);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 4;
            label6.Text = "Cargo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(155, 179, 232);
            label5.Location = new Point(19, 246);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 3;
            label5.Text = "Cedula :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(155, 179, 232);
            label4.Location = new Point(19, 164);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 2;
            label4.Text = "Apellido Materno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(155, 179, 232);
            label3.Location = new Point(17, 87);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 1;
            label3.Text = "Apellido Paterno :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(155, 179, 232);
            label2.Location = new Point(17, 10);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(155, 179, 232);
            label1.Location = new Point(1226, 26);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EMPLEADO";
            label1.Click += label1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(133, 210, 208);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(267, 607);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(105, 40);
            btnEditar.TabIndex = 68;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(133, 210, 208);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(430, 607);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 40);
            btnEliminar.TabIndex = 69;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FormPersonalMedico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1475, 659);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel7);
            Controls.Add(ucMenuAdministrador1);
            Name = "FormPersonalMedico";
            Text = "FormPersonalMedico";
            Load += FormPersonalMedico_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UcMenuAdministrador ucMenuAdministrador1;
        private Panel panel7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Button btnRegistar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido_Paterno;
        private DataGridViewTextBoxColumn Apellido_Materno;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn Cedula;
    }
}