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
            txtEspecialidad = new TextBox();
            txtCargo = new TextBox();
            txtCedula = new TextBox();
            txtA_Materno = new TextBox();
            txtA_Paterno = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            lblPacientes = new Label();
            lblRegistrar = new Label();
            lblProgramadas = new Label();
            lblConsultas = new Label();
            lblMedicos_especialidades = new Label();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(2, 0);
            ucMenuAdministrador1.Margin = new Padding(5);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(324, 809);
            ucMenuAdministrador1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(571, 15);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(370, 59);
            panel7.TabIndex = 65;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(133, 210, 208);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(59, 18);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 24);
            textBox1.TabIndex = 0;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.ForeColor = SystemColors.ControlText;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox4.IconColor = SystemColors.ControlText;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 50;
            iconPictureBox4.Location = new Point(4, 0);
            iconPictureBox4.Margin = new Padding(4);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(50, 50);
            iconPictureBox4.TabIndex = 65;
            iconPictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido_Paterno, Apellido_Materno, Cargo, Especialidad, Cedula });
            dataGridView1.Location = new Point(334, 175);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1114, 565);
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
            panel1.Controls.Add(txtEspecialidad);
            panel1.Controls.Add(txtCargo);
            panel1.Controls.Add(txtCedula);
            panel1.Controls.Add(txtA_Materno);
            panel1.Controls.Add(txtA_Paterno);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1469, 66);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 742);
            panel1.TabIndex = 67;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.FromArgb(133, 210, 208);
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.Location = new Point(106, 626);
            btnRegistar.Margin = new Padding(4);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(169, 65);
            btnRegistar.TabIndex = 68;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(21, 534);
            txtEspecialidad.Margin = new Padding(4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(304, 31);
            txtEspecialidad.TabIndex = 11;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(21, 434);
            txtCargo.Margin = new Padding(4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(304, 31);
            txtCargo.TabIndex = 10;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(24, 336);
            txtCedula.Margin = new Padding(4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(302, 31);
            txtCedula.TabIndex = 9;
            // 
            // txtA_Materno
            // 
            txtA_Materno.Location = new Point(21, 234);
            txtA_Materno.Margin = new Padding(4);
            txtA_Materno.Name = "txtA_Materno";
            txtA_Materno.Size = new Size(304, 31);
            txtA_Materno.TabIndex = 8;
            // 
            // txtA_Paterno
            // 
            txtA_Paterno.Location = new Point(24, 139);
            txtA_Paterno.Margin = new Padding(4);
            txtA_Paterno.Name = "txtA_Paterno";
            txtA_Paterno.Size = new Size(302, 31);
            txtA_Paterno.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 41);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(304, 31);
            txtNombre.TabIndex = 6;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.None;
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(155, 179, 232);
            label7.Location = new Point(21, 506);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(177, 24);
            label7.TabIndex = 5;
            label7.Text = "ID_especialidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(155, 179, 232);
            label6.Location = new Point(24, 405);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 24);
            label6.TabIndex = 4;
            label6.Text = "Cargo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(155, 179, 232);
            label5.Location = new Point(24, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 3;
            label5.Text = "Cedula :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(155, 179, 232);
            label4.Location = new Point(24, 205);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 24);
            label4.TabIndex = 2;
            label4.Text = "Apellido Materno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(155, 179, 232);
            label3.Location = new Point(21, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 24);
            label3.TabIndex = 1;
            label3.Text = "Apellido Paterno :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(155, 179, 232);
            label2.Location = new Point(21, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 0;
            label2.Text = "Nombre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(155, 179, 232);
            label1.Location = new Point(1532, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 24);
            label1.TabIndex = 0;
            label1.Text = "AGREGAR EMPLEADO";
            label1.Click += label1_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(133, 210, 208);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(334, 759);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 50);
            btnEditar.TabIndex = 68;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(133, 210, 208);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(538, 759);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 50);
            btnEliminar.TabIndex = 69;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPacientes.ForeColor = Color.CornflowerBlue;
            lblPacientes.Location = new Point(13, 536);
            lblPacientes.Margin = new Padding(4, 0, 4, 0);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(147, 25);
            lblPacientes.TabIndex = 78;
            lblPacientes.Text = "PACIENTES";
            lblPacientes.Click += lblPacientes_Click;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrar.ForeColor = Color.CornflowerBlue;
            lblRegistrar.Location = new Point(13, 233);
            lblRegistrar.Margin = new Padding(4, 0, 4, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(180, 25);
            lblRegistrar.TabIndex = 77;
            lblRegistrar.Text = "> NUEVA CITA";
            lblRegistrar.Click += lblRegistrar_Click;
            // 
            // lblProgramadas
            // 
            lblProgramadas.AutoSize = true;
            lblProgramadas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgramadas.ForeColor = Color.CornflowerBlue;
            lblProgramadas.Location = new Point(13, 306);
            lblProgramadas.Margin = new Padding(4, 0, 4, 0);
            lblProgramadas.Name = "lblProgramadas";
            lblProgramadas.Size = new Size(295, 25);
            lblProgramadas.TabIndex = 76;
            lblProgramadas.Text = "> CITAS PROGRAMADAS";
            lblProgramadas.Click += lblProgramadas_Click;
            // 
            // lblConsultas
            // 
            lblConsultas.AutoSize = true;
            lblConsultas.BackColor = Color.Transparent;
            lblConsultas.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConsultas.ForeColor = Color.CornflowerBlue;
            lblConsultas.Location = new Point(13, 348);
            lblConsultas.Margin = new Padding(4, 0, 4, 0);
            lblConsultas.Name = "lblConsultas";
            lblConsultas.Size = new Size(205, 50);
            lblConsultas.TabIndex = 75;
            lblConsultas.Text = "> HISTORIAL DE \r\nCONSULTAS";
            lblConsultas.Click += lblConsultas_Click;
            // 
            // lblMedicos_especialidades
            // 
            lblMedicos_especialidades.AutoSize = true;
            lblMedicos_especialidades.Font = new Font("Cooper Black", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMedicos_especialidades.ForeColor = Color.CornflowerBlue;
            lblMedicos_especialidades.Location = new Point(13, 421);
            lblMedicos_especialidades.Margin = new Padding(4, 0, 4, 0);
            lblMedicos_especialidades.Name = "lblMedicos_especialidades";
            lblMedicos_especialidades.Size = new Size(220, 50);
            lblMedicos_especialidades.TabIndex = 74;
            lblMedicos_especialidades.Text = "> MEDICOS Y  \r\nESPECIALIDADES";
            lblMedicos_especialidades.Click += lblMedicos_especialidades_Click;
            // 
            // FormPersonalMedico
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1844, 824);
            Controls.Add(lblPacientes);
            Controls.Add(lblRegistrar);
            Controls.Add(lblProgramadas);
            Controls.Add(lblConsultas);
            Controls.Add(lblMedicos_especialidades);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel7);
            Controls.Add(ucMenuAdministrador1);
            Margin = new Padding(4);
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
        private TextBox txtEspecialidad;
        private TextBox txtCargo;
        private TextBox txtCedula;
        private TextBox txtA_Materno;
        private TextBox txtA_Paterno;
        private TextBox txtNombre;
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
        private Label lblPacientes;
        private Label lblRegistrar;
        private Label lblProgramadas;
        private Label lblConsultas;
        private Label lblMedicos_especialidades;
    }
}