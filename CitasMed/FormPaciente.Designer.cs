namespace CitasMed
{
    partial class FormPaciente
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lblPacientes = new Label();
            lblMedicos = new Label();
            lblHistorial = new Label();
            lblProgramada = new Label();
            lblNueva = new Label();
            btnRegresar = new Button();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(93, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "CITASMED";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridView1.Location = new Point(329, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1428, 561);
            dataGridView1.TabIndex = 109;
            // 
            // Column1
            // 
            Column1.HeaderText = "CLAVE";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "CURP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "NOMBRE";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "APELLIDO PATERNO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "APELLIDO MATERNO";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "TELÉFONO ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "CALLE";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "COLONIA";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "MUNICIPIO";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "ENFERMEDADES CRONICAS";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "ESPECIALIDAD SOLICITADA";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(lblPacientes);
            panel1.Controls.Add(lblMedicos);
            panel1.Controls.Add(lblHistorial);
            panel1.Controls.Add(lblProgramada);
            panel1.Controls.Add(lblNueva);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 664);
            panel1.TabIndex = 103;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.SkyBlue;
            lblPacientes.Location = new Point(13, 440);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(135, 21);
            lblPacientes.TabIndex = 31;
            lblPacientes.Text = "> PACIENTES";
            lblPacientes.Click += lblPacientes_Click;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos.ForeColor = SystemColors.ActiveCaption;
            lblMedicos.Location = new Point(11, 367);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(188, 42);
            lblMedicos.TabIndex = 30;
            lblMedicos.Text = "> MÉDICOS Y \r\n  ESPECIALIDADES";
            lblMedicos.Click += lblMedicos_Click;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.ForeColor = SystemColors.ActiveCaption;
            lblHistorial.Location = new Point(13, 297);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(167, 42);
            lblHistorial.TabIndex = 29;
            lblHistorial.Text = "> HISTORIAL DE \r\n  CONSULTAS";
            lblHistorial.Click += lblHistorial_Click;
            // 
            // lblProgramada
            // 
            lblProgramada.AutoSize = true;
            lblProgramada.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramada.ForeColor = SystemColors.ActiveCaption;
            lblProgramada.Location = new Point(13, 244);
            lblProgramada.Name = "lblProgramada";
            lblProgramada.Size = new Size(244, 21);
            lblProgramada.TabIndex = 28;
            lblProgramada.Text = "> CITAS PROGRAMADAS";
            lblProgramada.Click += lblProgramada_Click;
            // 
            // lblNueva
            // 
            lblNueva.AutoSize = true;
            lblNueva.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNueva.ForeColor = SystemColors.ActiveCaption;
            lblNueva.Location = new Point(13, 187);
            lblNueva.Name = "lblNueva";
            lblNueva.Size = new Size(148, 21);
            lblNueva.TabIndex = 27;
            lblNueva.Text = "> NUEVA CITA";
            lblNueva.Click += lblNueva_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Turquoise;
            btnRegresar.BackgroundImageLayout = ImageLayout.None;
            btnRegresar.Location = new Point(13, 512);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1537, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 108;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(504, 511);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 101;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 425);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 100;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 302);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 99;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(620, 345);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(544, 208);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(580, 136);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 106;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(400, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 105;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 104;
            textBox1.Text = "BUSCAR PACIENTE POR CURP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1631, 32);
            label10.Name = "label10";
            label10.Size = new Size(132, 23);
            label10.TabIndex = 107;
            label10.Text = "EMPLEADO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(561, 543);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 102;
            // 
            // button3
            // 
            button3.BackColor = Color.Turquoise;
            button3.Location = new Point(743, 695);
            button3.Name = "button3";
            button3.Size = new Size(140, 50);
            button3.TabIndex = 112;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Turquoise;
            button2.Location = new Point(580, 695);
            button2.Name = "button2";
            button2.Size = new Size(140, 50);
            button2.TabIndex = 111;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Turquoise;
            button4.Location = new Point(415, 695);
            button4.Name = "button4";
            button4.Size = new Size(140, 50);
            button4.TabIndex = 110;
            button4.Text = "NUEVA CITA";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 811);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(label8);
            Name = "FormPaciente";
            Text = "FormPaciente";
            Load += FormPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Panel panel1;
        private Label lblPacientes;
        private Label lblMedicos;
        private Label lblHistorial;
        private Label lblProgramada;
        private Label lblNueva;
        private Button btnRegresar;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label9;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label8;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}