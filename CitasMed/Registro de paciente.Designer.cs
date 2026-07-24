namespace CitasMed
{
    partial class Registro_de_paciente
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMunicipio = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtColonia = new TextBox();
            txtCalle = new TextBox();
            txtCurp = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cmbGenero = new ComboBox();
            cmbEspecialidad = new ComboBox();
            txtEnfermedadCronica = new RichTextBox();
            button1 = new Button();
            btnMenu_empleado = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            dtFecha_cita = new DateTimePicker();
            panel13 = new Panel();
            numEdad = new NumericUpDown();
            textBox1 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(685, 55);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DEL PACIENTE";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(146, 15);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(158, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(512, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 3;
            label3.Text = "Apellido paterno:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(871, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 32);
            label4.TabIndex = 4;
            label4.Text = "Apellidos materno:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(133, 210, 208);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Location = new Point(15, 10);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(190, 42);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.BackColor = Color.FromArgb(133, 210, 208);
            txtApellidoPaterno.BorderStyle = BorderStyle.None;
            txtApellidoPaterno.Location = new Point(18, 10);
            txtApellidoPaterno.Margin = new Padding(4);
            txtApellidoPaterno.Multiline = true;
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(232, 42);
            txtApellidoPaterno.TabIndex = 6;
            txtApellidoPaterno.TextChanged += txtApellidoPaterno_TextChanged;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.BackColor = Color.FromArgb(133, 210, 208);
            txtApellidoMaterno.BorderStyle = BorderStyle.None;
            txtApellidoMaterno.Location = new Point(18, 10);
            txtApellidoMaterno.Margin = new Padding(4);
            txtApellidoMaterno.Multiline = true;
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(221, 42);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(133, 210, 208);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Location = new Point(19, 8);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 42);
            txtCorreo.TabIndex = 13;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(133, 210, 208);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.Location = new Point(18, 8);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 42);
            txtTelefono.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(871, 311);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 32);
            label5.TabIndex = 10;
            label5.Text = "Correo Electrónico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(512, 311);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 32);
            label6.TabIndex = 9;
            label6.Text = "Telefono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(158, 311);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 8;
            label7.Text = "Genero:";
            label7.Click += label7_Click;
            // 
            // txtMunicipio
            // 
            txtMunicipio.BackColor = Color.FromArgb(133, 210, 208);
            txtMunicipio.BorderStyle = BorderStyle.None;
            txtMunicipio.Location = new Point(79, 14);
            txtMunicipio.Margin = new Padding(4);
            txtMunicipio.Multiline = true;
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(190, 42);
            txtMunicipio.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(112, 754);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(271, 32);
            label8.TabIndex = 16;
            label8.Text = "Enfermedades crónicas :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(860, 608);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(255, 32);
            label9.TabIndex = 15;
            label9.Text = "Especialidad solicitada:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(506, 608);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 32);
            label10.TabIndex = 14;
            label10.Text = "Municipio:";
            // 
            // txtColonia
            // 
            txtColonia.BackColor = Color.FromArgb(133, 210, 208);
            txtColonia.BorderStyle = BorderStyle.None;
            txtColonia.Location = new Point(19, 11);
            txtColonia.Margin = new Padding(4);
            txtColonia.Multiline = true;
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(221, 42);
            txtColonia.TabIndex = 25;
            // 
            // txtCalle
            // 
            txtCalle.BackColor = Color.FromArgb(133, 210, 208);
            txtCalle.BorderStyle = BorderStyle.None;
            txtCalle.Location = new Point(14, 11);
            txtCalle.Margin = new Padding(4);
            txtCalle.Multiline = true;
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(232, 42);
            txtCalle.TabIndex = 24;
            // 
            // txtCurp
            // 
            txtCurp.BackColor = Color.FromArgb(133, 210, 208);
            txtCurp.BorderStyle = BorderStyle.None;
            txtCurp.Location = new Point(15, 15);
            txtCurp.Margin = new Padding(4);
            txtCurp.Multiline = true;
            txtCurp.Name = "txtCurp";
            txtCurp.Size = new Size(192, 42);
            txtCurp.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(132, 608);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 32);
            label11.TabIndex = 22;
            label11.Text = "Colonia:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(882, 452);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(71, 32);
            label12.TabIndex = 21;
            label12.Text = "Calle:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(499, 455);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(70, 32);
            label13.TabIndex = 20;
            label13.Text = "Curp:";
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.FromArgb(133, 210, 208);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(18, 12);
            cmbGenero.Margin = new Padding(4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(188, 33);
            cmbGenero.TabIndex = 26;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.BackColor = Color.FromArgb(133, 210, 208);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(24, 23);
            cmbEspecialidad.Margin = new Padding(4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(232, 33);
            cmbEspecialidad.TabIndex = 27;
            // 
            // txtEnfermedadCronica
            // 
            txtEnfermedadCronica.BackColor = Color.FromArgb(133, 210, 208);
            txtEnfermedadCronica.Location = new Point(20, 10);
            txtEnfermedadCronica.Margin = new Padding(4);
            txtEnfermedadCronica.Name = "txtEnfermedadCronica";
            txtEnfermedadCronica.Size = new Size(243, 45);
            txtEnfermedadCronica.TabIndex = 28;
            txtEnfermedadCronica.Text = "";
            txtEnfermedadCronica.TextChanged += txtEnfermedadCronica_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(133, 210, 208);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(673, 878);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(219, 36);
            button1.TabIndex = 29;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMenu_empleado
            // 
            btnMenu_empleado.BackColor = Color.FromArgb(133, 210, 208);
            btnMenu_empleado.FlatStyle = FlatStyle.Flat;
            btnMenu_empleado.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu_empleado.Location = new Point(392, 878);
            btnMenu_empleado.Margin = new Padding(4);
            btnMenu_empleado.Name = "btnMenu_empleado";
            btnMenu_empleado.Size = new Size(219, 36);
            btnMenu_empleado.TabIndex = 30;
            btnMenu_empleado.Text = "Menu principal";
            btnMenu_empleado.UseVisualStyleBackColor = false;
            btnMenu_empleado.Click += btnMenu_empleado_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(133, 210, 208);
            panel1.Controls.Add(txtNombre);
            panel1.Location = new Point(114, 211);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 69);
            panel1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(133, 210, 208);
            panel2.Controls.Add(txtApellidoPaterno);
            panel2.Location = new Point(481, 211);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 69);
            panel2.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(133, 210, 208);
            panel3.Controls.Add(txtApellidoMaterno);
            panel3.Location = new Point(854, 211);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(256, 69);
            panel3.TabIndex = 33;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(133, 210, 208);
            panel4.Controls.Add(cmbGenero);
            panel4.Location = new Point(114, 355);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 69);
            panel4.TabIndex = 34;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(133, 210, 208);
            panel5.Controls.Add(txtTelefono);
            panel5.Location = new Point(481, 355);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(265, 69);
            panel5.TabIndex = 35;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(133, 210, 208);
            panel6.Controls.Add(txtCorreo);
            panel6.Location = new Point(854, 355);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(261, 69);
            panel6.TabIndex = 36;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(txtCurp);
            panel7.Location = new Point(484, 491);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(222, 69);
            panel7.TabIndex = 37;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(133, 210, 208);
            panel8.Controls.Add(txtCalle);
            panel8.Location = new Point(851, 494);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(265, 65);
            panel8.TabIndex = 38;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(133, 210, 208);
            panel9.Controls.Add(txtColonia);
            panel9.Location = new Point(115, 650);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(261, 65);
            panel9.TabIndex = 39;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(133, 210, 208);
            panel10.Controls.Add(txtMunicipio);
            panel10.Location = new Point(481, 647);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(265, 69);
            panel10.TabIndex = 40;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(133, 210, 208);
            panel11.Controls.Add(cmbEspecialidad);
            panel11.Location = new Point(854, 647);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(261, 69);
            panel11.TabIndex = 41;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(133, 210, 208);
            panel12.Controls.Add(txtEnfermedadCronica);
            panel12.Location = new Point(112, 790);
            panel12.Margin = new Padding(4);
            panel12.Name = "panel12";
            panel12.Size = new Size(276, 69);
            panel12.TabIndex = 42;
            // 
            // dtFecha_cita
            // 
            dtFecha_cita.Location = new Point(465, 814);
            dtFecha_cita.Name = "dtFecha_cita";
            dtFecha_cita.Size = new Size(345, 31);
            dtFecha_cita.TabIndex = 44;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(133, 210, 208);
            panel13.Controls.Add(numEdad);
            panel13.Controls.Add(textBox1);
            panel13.Location = new Point(112, 491);
            panel13.Margin = new Padding(4);
            panel13.Name = "panel13";
            panel13.Size = new Size(224, 69);
            panel13.TabIndex = 46;
            // 
            // numEdad
            // 
            numEdad.Location = new Point(17, 15);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(180, 31);
            numEdad.TabIndex = 47;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(15, 15);
            textBox1.Margin = new Padding(4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 42);
            textBox1.TabIndex = 23;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(146, 452);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(71, 32);
            label14.TabIndex = 47;
            label14.Text = "Edad:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(481, 754);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(179, 32);
            label15.TabIndex = 48;
            label15.Text = "Fecha de la cita";
            // 
            // Registro_de_paciente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1289, 975);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(panel13);
            Controls.Add(dtFecha_cita);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnMenu_empleado);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Registro_de_paciente";
            Text = "Registro_de_paciente";
            Load += Registro_de_paciente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMunicipio;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtColonia;
        private TextBox txtCalle;
        private TextBox txtCurp;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cmbGenero;
        private ComboBox cmbEspecialidad;
        private RichTextBox txtEnfermedadCronica;
        private Button button1;
        private Button btnMenu_empleado;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private DateTimePicker dtFecha_cita;
        private Panel panel13;
        private NumericUpDown numEdad;
        private TextBox textBox1;
        private Label label14;
        private Label label15;
    }
}