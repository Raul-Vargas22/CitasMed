namespace CitasMed
{
    partial class UcMenuAdministrador
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMenuAdministrador));
            panel1 = new Panel();
            label1 = new Label();
            lblHistorialCitas = new Label();
            lblPersonalMedico = new Label();
            btnInicio = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblHistorialCitas);
            panel1.Controls.Add(lblPersonalMedico);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 647);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(139, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 4;
            label1.Text = "CITASMED";
            // 
            // lblHistorialCitas
            // 
            lblHistorialCitas.AutoSize = true;
            lblHistorialCitas.BackColor = Color.Transparent;
            lblHistorialCitas.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorialCitas.ForeColor = Color.FromArgb(155, 179, 232);
            lblHistorialCitas.Location = new Point(12, 395);
            lblHistorialCitas.Name = "lblHistorialCitas";
            lblHistorialCitas.Size = new Size(218, 20);
            lblHistorialCitas.TabIndex = 3;
            lblHistorialCitas.Text = "> HISTORIAL  DE CITAS";
            lblHistorialCitas.Click += lblHistorialCitas_Click;
            // 
            // lblPersonalMedico
            // 
            lblPersonalMedico.AutoSize = true;
            lblPersonalMedico.BackColor = Color.Transparent;
            lblPersonalMedico.Font = new Font("Cooper Black", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersonalMedico.ForeColor = Color.FromArgb(155, 179, 232);
            lblPersonalMedico.Location = new Point(12, 219);
            lblPersonalMedico.Name = "lblPersonalMedico";
            lblPersonalMedico.Size = new Size(199, 20);
            lblPersonalMedico.TabIndex = 2;
            lblPersonalMedico.Text = "> PERSONAL MEDICO";
            lblPersonalMedico.Click += lblPersonalMedico_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(133, 210, 208);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(71, 114);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // UcMenuAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UcMenuAdministrador";
            Size = new Size(281, 647);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblHistorialCitas;
        private Label lblPersonalMedico;
        private Button btnInicio;
        private Label label1;
    }
}
