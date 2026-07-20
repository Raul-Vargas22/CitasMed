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
            textContrasena = new TextBox();
            btnSesion = new Button();
            lblDoctor = new LinkLabel();
            lblEmpleado = new LinkLabel();
            lblAdministrador = new LinkLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnSalir = new Button();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tntTitulo
            // 
            tntTitulo.BackColor = Color.FromArgb(155, 179, 232);
            tntTitulo.Font = new Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tntTitulo.Location = new Point(308, 36);
            tntTitulo.Name = "tntTitulo";
            tntTitulo.Size = new Size(470, 80);
            tntTitulo.TabIndex = 0;
            tntTitulo.Text = "Asministrador";
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
            lblPassword.Font = new Font("Century Gothic", 22F);
            lblPassword.Location = new Point(332, 338);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(408, 44);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Ingresa la contraseña";
            lblPassword.Click += lblPassword_Click;
            // 
            // textContrasena
            // 
            textContrasena.Location = new Point(332, 385);
            textContrasena.Multiline = true;
            textContrasena.Name = "textContrasena";
            textContrasena.Size = new Size(393, 41);
            textContrasena.TabIndex = 4;
            textContrasena.TextChanged += textBox1_TextChanged;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.FromArgb(133, 210, 208);
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(408, 443);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(215, 92);
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
            lblDoctor.Location = new Point(47, 555);
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
            lblEmpleado.Location = new Point(47, 599);
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
            lblAdministrador.Location = new Point(47, 507);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(77, 28);
            lblAdministrador.TabIndex = 12;
            lblAdministrador.TabStop = true;
            lblAdministrador.Text = "ADMIN";
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
            iconPictureBox1.Location = new Point(-4, -1);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(1018, 649);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 13;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(133, 210, 208);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(850, 584);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 50);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox3.ForeColor = SystemColors.ControlText;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox3.IconColor = SystemColors.ControlText;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 195;
            iconPictureBox3.Location = new Point(430, 128);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(215, 195);
            iconPictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox3.TabIndex = 17;
            iconPictureBox3.TabStop = false;
            iconPictureBox3.Click += iconPictureBox3_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(155, 179, 232);
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 42;
            iconPictureBox2.Location = new Point(-4, 501);
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
            iconPictureBox4.Location = new Point(-4, 597);
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
            iconPictureBox5.Location = new Point(-4, 549);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(53, 42);
            iconPictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox5.TabIndex = 20;
            iconPictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1017, 646);
            Controls.Add(iconPictureBox5);
            Controls.Add(iconPictureBox4);
            Controls.Add(iconPictureBox2);
            Controls.Add(iconPictureBox3);
            Controls.Add(btnSalir);
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tntTitulo;
        private LinkLabel linkLabel1;
        private Label lblPassword;
        private TextBox textContrasena;
        private Button btnSesion;
        private LinkLabel lblDoctor;
        private LinkLabel lblEmpleado;
        private LinkLabel lblAdministrador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btnSalir;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
    }
}
