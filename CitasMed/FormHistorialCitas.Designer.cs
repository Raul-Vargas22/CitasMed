namespace CitasMed
{
    partial class FormHistorialCitas
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
            ucMenuAdministrador1 = new UcMenuAdministrador();
            panel7 = new Panel();
            textBox1 = new TextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            btnImprimirReporte = new Button();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ucMenuAdministrador1
            // 
            ucMenuAdministrador1.Location = new Point(2, 0);
            ucMenuAdministrador1.Name = "ucMenuAdministrador1";
            ucMenuAdministrador1.Size = new Size(259, 647);
            ucMenuAdministrador1.TabIndex = 0;
            ucMenuAdministrador1.Load += ucMenuAdministrador1_Load;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(133, 210, 208);
            panel7.Controls.Add(textBox1);
            panel7.Controls.Add(iconPictureBox4);
            panel7.Location = new Point(432, 22);
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(268, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1115, 469);
            dataGridView1.TabIndex = 68;
            // 
            // Column1
            // 
            Column1.HeaderText = "Paciente";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Edad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 80;
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefono";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Doctor";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 180;
            // 
            // Column5
            // 
            Column5.HeaderText = "Especialidad";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado_de_Cita";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "fecha";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(1051, 22);
            label10.Name = "label10";
            label10.Size = new Size(202, 23);
            label10.TabIndex = 69;
            label10.Text = "ADMINISTRADOR";
            // 
            // btnImprimirReporte
            // 
            btnImprimirReporte.BackColor = Color.FromArgb(133, 210, 208);
            btnImprimirReporte.FlatStyle = FlatStyle.Flat;
            btnImprimirReporte.Location = new Point(281, 599);
            btnImprimirReporte.Name = "btnImprimirReporte";
            btnImprimirReporte.Size = new Size(152, 29);
            btnImprimirReporte.TabIndex = 70;
            btnImprimirReporte.Text = " IMPRIMIR REPORTE";
            btnImprimirReporte.UseVisualStyleBackColor = false;
            // 
            // FormHistorialCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 654);
            Controls.Add(btnImprimirReporte);
            Controls.Add(label10);
            Controls.Add(dataGridView1);
            Controls.Add(panel7);
            Controls.Add(ucMenuAdministrador1);
            Name = "FormHistorialCitas";
            Text = "FormHistorialCitas";
            Load += FormHistorialCitas_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UcMenuAdministrador ucMenuAdministrador1;
        private Panel panel7;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private DataGridView dataGridView1;
        private Label label10;
        private Button btnImprimirReporte;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}