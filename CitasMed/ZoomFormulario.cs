using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMed
{
    public class ZoomFormulario
    {
        private readonly Form formulario;
        private readonly Dictionary<Control, Rectangle> controlesOriginales =
        new Dictionary<Control, Rectangle>();
        private readonly Dictionary<Control, float> fuentesOriginales =
        new Dictionary<Control, float>();
        private float zoom = 1.0f;
        private const float ZoomMin = 0.8f;
        private const float ZoomMax = 2.0f;
        public ZoomFormulario(Form formulario)
        {
            this.formulario = formulario;
            GuardarControles(formulario);
        }
        private void GuardarControles(Control padre)
        {
            foreach (Control control in padre.Controls)
            {
                controlesOriginales[control] = control.Bounds;
                fuentesOriginales[control] = control.Font.Size;

                if (control.Controls.Count > 0)
                    GuardarControles(control);
            }
        }
        private void AplicarZoom(float nuevoZoom)
        {
            if (nuevoZoom < ZoomMin || nuevoZoom > ZoomMax)
                return;

            float factor = nuevoZoom / zoom;
            zoom = nuevoZoom;

            // Cambiar el tamaño del formulario
            formulario.Width = (int)(formulario.Width * factor);
            formulario.Height = (int)(formulario.Height * factor);

            foreach (Control control in controlesOriginales.Keys)
            {
                Rectangle original = controlesOriginales[control];

                control.Left = (int)(original.Left * zoom);
                control.Top = (int)(original.Top * zoom);
                control.Width = (int)(original.Width * zoom);
                control.Height = (int)(original.Height * zoom);

                control.Font = new Font(
                    control.Font.FontFamily,
                    fuentesOriginales[control] * zoom,
                    control.Font.Style);
            }
        }
        public void ZoomMas()
        {
            AplicarZoom(zoom + 0.10f);
        }

        public void ZoomMenos()
        {
            AplicarZoom(zoom - 0.10f);
        }
    }
}
