using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMed
{
    internal class Contraste
    {
        public static bool AltoContraste = false;

        public static void Cambiar(Form formulario)
        {
            AltoContraste = !AltoContraste;

            if (AltoContraste)
            {
                Aplicar(formulario, Color.Black, Color.Yellow);
            }
            else
            {
                Restaurar(formulario);
            }
        }

        private static void Aplicar(Control control, Color fondo, Color texto)
        {
            control.BackColor = fondo;
            control.ForeColor = texto;

            if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = fondo;
                dgv.GridColor = texto;
                dgv.DefaultCellStyle.BackColor = fondo;
                dgv.DefaultCellStyle.ForeColor = texto;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = fondo;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = texto;
                dgv.EnableHeadersVisualStyles = false;
            }

            foreach (Control c in control.Controls)
            {
                Aplicar(c, fondo, texto);
            }
        }

        private static void Restaurar(Control control)
        {
            control.BackColor = SystemColors.Control;
            control.ForeColor = SystemColors.ControlText;

            if (control is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.GridColor = Color.LightGray;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv.EnableHeadersVisualStyles = false;
            }

            foreach (Control c in control.Controls)
            {
                Restaurar(c);
            }
        }
    }
}
