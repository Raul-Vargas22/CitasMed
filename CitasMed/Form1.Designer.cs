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
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            lblPassword = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            lblDoctor = new LinkLabel();
            lblEmpleado = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblAdministrador = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tntTitulo
            // 
            tntTitulo.Font = new Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tntTitulo.Location = new Point(285, 27);
            tntTitulo.Name = "tntTitulo";
            tntTitulo.Size = new Size(470, 80);
            tntTitulo.TabIndex = 0;
            tntTitulo.Text = "Asministrador";
            tntTitulo.TextAlign = ContentAlignment.TopCenter;
            tntTitulo.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 168);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            lblPassword.Font = new Font("Century Gothic", 22F);
            lblPassword.Location = new Point(332, 338);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(408, 44);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Ingresa la contraseña";
            lblPassword.Click += lblPassword_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(408, 443);
            button1.Name = "button1";
            button1.Size = new Size(215, 92);
            button1.TabIndex = 5;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 507);
            pictureBox2.MaximumSize = new Size(28, 28);
            pictureBox2.MinimumSize = new Size(28, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 599);
            pictureBox3.MaximumSize = new Size(28, 28);
            pictureBox3.MinimumSize = new Size(28, 28);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 555);
            pictureBox4.MaximumSize = new Size(28, 28);
            pictureBox4.MinimumSize = new Size(28, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // lblAdministrador
            // 
            lblAdministrador.AutoSize = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 646);
            Controls.Add(lblAdministrador);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblEmpleado);
            Controls.Add(lblDoctor);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(tntTitulo);
            Name = "Form1";
            Text = "ADMIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tntTitulo;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label lblPassword;
        private TextBox textBox1;
        private Button button1;
        private LinkLabel lblDoctor;
        private LinkLabel lblEmpleado;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private LinkLabel lblAdministrador;
    }
}
