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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tntTitulo
            // 
            tntTitulo.AutoSize = true;
            tntTitulo.Font = new Font("Century Gothic", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tntTitulo.Location = new Point(398, 26);
            tntTitulo.Name = "tntTitulo";
            tntTitulo.Size = new Size(260, 80);
            tntTitulo.TabIndex = 0;
            tntTitulo.Text = "ADMIN";
            tntTitulo.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 172);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22F);
            label1.Location = new Point(332, 338);
            label1.Name = "label1";
            label1.Size = new Size(408, 44);
            label1.TabIndex = 3;
            label1.Text = "Ingresa la contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 399);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 27);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 454);
            button1.Name = "button1";
            button1.Size = new Size(172, 66);
            button1.TabIndex = 5;
            button1.Text = "Iniciar sesión";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(47, 507);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(73, 28);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Doctor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 646);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(tntTitulo);
            Name = "Form1";
            Text = "ADMIN";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tntTitulo;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private LinkLabel linkLabel2;
    }
}
