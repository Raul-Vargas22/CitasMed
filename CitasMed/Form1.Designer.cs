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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tntTitulo = new Label();
            linkLabel1 = new LinkLabel();
            lblPassword = new Label();
            textContrasena = new TextBox();
            btnSesion = new Button();
            lblDoctor = new LinkLabel();
            lblEmpleado = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblAdministrador = new LinkLabel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tntTitulo
            // 
            tntTitulo.Font = new Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tntTitulo.Location = new Point(356, 34);
            tntTitulo.Margin = new Padding(4, 0, 4, 0);
            tntTitulo.Name = "tntTitulo";
            tntTitulo.Size = new Size(588, 100);
            tntTitulo.TabIndex = 0;
            tntTitulo.Text = "Asministrador";
            tntTitulo.TextAlign = ContentAlignment.TopCenter;
            tntTitulo.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(638, 554);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 25);
            linkLabel1.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 22F);
            lblPassword.Location = new Point(415, 422);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(490, 55);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Ingresa la contraseña";
            lblPassword.Click += lblPassword_Click;
            // 
            // textContrasena
            // 
            textContrasena.Location = new Point(356, 499);
            textContrasena.Margin = new Padding(4, 4, 4, 4);
            textContrasena.Name = "textContrasena";
            textContrasena.Size = new Size(602, 31);
            textContrasena.TabIndex = 4;
            textContrasena.TextChanged += textBox1_TextChanged;
            // 
            // btnSesion
            // 
            btnSesion.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSesion.Location = new Point(510, 554);
            btnSesion.Margin = new Padding(4, 4, 4, 4);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(269, 115);
            btnSesion.TabIndex = 5;
            btnSesion.Text = "Iniciar sesión";
            btnSesion.UseVisualStyleBackColor = true;
            btnSesion.Click += button1_Click;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDoctor.LinkColor = Color.Black;
            lblDoctor.Location = new Point(59, 694);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(108, 32);
            lblDoctor.TabIndex = 7;
            lblDoctor.TabStop = true;
            lblDoctor.Text = "DOCTOR";
            lblDoctor.LinkClicked += lblDoctor_LinkClicked;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.LinkColor = Color.Black;
            lblEmpleado.Location = new Point(59, 749);
            lblEmpleado.Margin = new Padding(4, 0, 4, 0);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(134, 32);
            lblEmpleado.TabIndex = 8;
            lblEmpleado.TabStop = true;
            lblEmpleado.Text = "EMPLEADO";
            lblEmpleado.LinkClicked += label4_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 634);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.MaximumSize = new Size(35, 35);
            pictureBox2.MinimumSize = new Size(35, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 749);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.MaximumSize = new Size(35, 35);
            pictureBox3.MinimumSize = new Size(35, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 694);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.MaximumSize = new Size(35, 35);
            pictureBox4.MinimumSize = new Size(35, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
            lblAdministrador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdministrador.LinkColor = Color.Black;
            lblAdministrador.Location = new Point(59, 634);
            lblAdministrador.Margin = new Padding(4, 0, 4, 0);
            lblAdministrador.Name = "lblAdministrador";
            lblAdministrador.Size = new Size(92, 32);
            lblAdministrador.TabIndex = 12;
            lblAdministrador.TabStop = true;
            lblAdministrador.Text = "ADMIN";
            lblAdministrador.LinkClicked += lblAdministrador_LinkClicked;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SkyBlue;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 811;
            iconPictureBox1.Location = new Point(-5, -1);
            iconPictureBox1.Margin = new Padding(4, 4, 4, 4);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(1272, 811);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 13;
            iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.Control;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Circle;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 281;
            iconPictureBox2.Location = new Point(494, 138);
            iconPictureBox2.Margin = new Padding(4, 4, 4, 4);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(341, 281);
            iconPictureBox2.TabIndex = 15;
            iconPictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 808);
            Controls.Add(iconPictureBox2);
            Controls.Add(lblAdministrador);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblEmpleado);
            Controls.Add(lblDoctor);
            Controls.Add(btnSesion);
            Controls.Add(textContrasena);
            Controls.Add(lblPassword);
            Controls.Add(linkLabel1);
            Controls.Add(tntTitulo);
            Controls.Add(iconPictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "ADMIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel lblAdministrador;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
