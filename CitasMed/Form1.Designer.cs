namespace CitasMed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tntTitulo = new Label();
            linkLabel1 = new LinkLabel();
            lblPassword = new Label();
            btnSesion = new Button();
            lblDoctor = new LinkLabel();
            lblEmpleado = new LinkLabel();
            lblAdministrador = new LinkLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnSalir = new Button();
            iconoPassword = new FontAwesome.Sharp.IconButton();
            textContrasena = new TextBox();
            iconoUsuario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tntTitulo
            // 
            tntTitulo.BackColor = Color.FromArgb(155, 179, 232);
            tntTitulo.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tntTitulo.Location = new Point(447, 32);
            tntTitulo.Name = "tntTitulo";
            tntTitulo.Size = new Size(535, 80);
            tntTitulo.TabIndex = 0;
            tntTitulo.Text = "¡Bienvenido de nuevo!";
            tntTitulo.TextAlign = ContentAlignment.TopCenter;
            tntTitulo.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(510, 443);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 20);
            linkLabel1.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(155, 179, 232);
            lblPassword.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(494, 288);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(333, 37);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Ingrese su contraseña";
            lblPassword.Click += lblPassword_Click;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.FromArgb(133, 210, 208);
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(576, 429);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(216, 43);
            btnSesion.TabIndex = 5;
            btnSesion.Text = "Iniciar sesión";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += button1_Click;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.BackColor = Color.FromArgb(155, 179, 232);
            lblDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.LinkColor = Color.Black;
            lblDoctor.Location = new Point(893, 614);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(89, 28);
            lblDoctor.TabIndex = 7;
            lblDoctor.TabStop = true;
            lblDoctor.Text = "DOCTOR";
            lblDoctor.LinkClicked += lblDoctor_LinkClicked;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.BackColor = Color.FromArgb(155, 179, 232);
            lblEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.LinkColor = Color.Black;
            lblEmpleado.Location = new Point(678, 614);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(112, 28);
            lblEmpleado.TabIndex = 8;
            lblEmpleado.TabStop = true;
            lblEmpleado.Text = "EMPLEADO";
            lblEmpleado.LinkClicked += label4_LinkClicked;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.BackColor = Color.FromArgb(155, 179, 232);
            lblAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdministrador.LinkColor = Color.Black;
            lblAdministrador.Location = new Point(423, 614);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(169, 28);
            lblAdministrador.TabIndex = 12;
            lblAdministrador.TabStop = true;
            lblAdministrador.Text = "ADMINISTRADOR";
            lblAdministrador.LinkClicked += lblAdministrador_LinkClicked;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 649;
            iconPictureBox1.Location = new Point(374, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(656, 649);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 13;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 42;
            iconPictureBox2.Location = new Point(475, 569);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(53, 42);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 18;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 42;
            iconPictureBox4.Location = new Point(906, 569);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(53, 42);
            iconPictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox4.TabIndex = 19;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 42;
            iconPictureBox5.Location = new Point(707, 569);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(53, 42);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 20;
            iconPictureBox5.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.FromArgb(155, 179, 232);
            lblUsuario.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(524, 137);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(272, 37);
            lblUsuario.TabIndex = 22;
            lblUsuario.Text = "Ingrese su usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(494, 211);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(393, 27);
            txtUsuario.TabIndex = 23;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 649);
            panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2026_07_22_192654;
            pictureBox1.Location = new Point(37, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 119, 182);
            label2.Location = new Point(37, 460);
            label2.Name = "label2";
            label2.Size = new Size(309, 69);
            label2.TabIndex = 0;
            label2.Text = "CitasMed";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(133, 210, 208);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(576, 493);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(216, 43);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // iconoPassword
            // 
            iconoPassword.BackColor = SystemColors.ButtonHighlight;
            iconoPassword.FlatStyle = FlatStyle.Flat;
            iconoPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconoPassword.IconColor = Color.Black;
            iconoPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoPassword.Location = new Point(838, 341);
            iconoPassword.Name = "iconoPassword";
            iconoPassword.Size = new Size(49, 41);
            iconoPassword.TabIndex = 28;
            iconoPassword.UseVisualStyleBackColor = false;
            iconoPassword.Click += iconoPassword_Click;
            // 
            // textContrasena
            // 
            textContrasena.Location = new Point(494, 341);
            textContrasena.Name = "textContrasena";
            textContrasena.Size = new Size(393, 27);
            textContrasena.TabIndex = 4;
            textContrasena.TextChanged += textBox1_TextChanged;
            // 
            // iconoUsuario
            // 
            iconoUsuario.BackColor = SystemColors.ButtonHighlight;
            iconoUsuario.FlatStyle = FlatStyle.Flat;
            iconoUsuario.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconoUsuario.IconColor = Color.Black;
            iconoUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconoUsuario.Location = new Point(838, 211);
            iconoUsuario.Name = "iconoUsuario";
            iconoUsuario.Size = new Size(49, 41);
            iconoUsuario.TabIndex = 27;
            iconoUsuario.UseVisualStyleBackColor = false;
            iconoUsuario.Click += iconoUsuario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1017, 646);
            Controls.Add(iconoPassword);
            Controls.Add(iconoUsuario);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(iconPictureBox5);
            Controls.Add(iconPictureBox4);
            Controls.Add(iconPictureBox2);
            Controls.Add(lblAdministrador);
            Controls.Add(lblEmpleado);
            Controls.Add(lblDoctor);
            Controls.Add(btnSesion);
            Controls.Add(textContrasena);
            Controls.Add(lblPassword);
            Controls.Add(linkLabel1);
            Controls.Add(tntTitulo);
            Controls.Add(iconPictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "ADMIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tntTitulo;
        private LinkLabel linkLabel1;
        private Label lblPassword;
        private Button btnSesion;
        private LinkLabel lblDoctor;
        private LinkLabel lblEmpleado;
        private LinkLabel lblAdministrador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnSalir;
        private FontAwesome.Sharp.IconButton iconoPassword;
        private TextBox textContrasena;
        private FontAwesome.Sharp.IconButton iconoUsuario;
    }
}
