using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Drawing;

namespace CitasMed
{
    public static class AsistenteVoz
    {
        private static readonly SpeechSynthesizer sintetizador = new SpeechSynthesizer();

        // Interruptor global: true = voz activada, false = silenciada
        public static bool Activada { get; private set; } = true;

        static AsistenteVoz()
        {
            sintetizador.SetOutputToDefaultAudioDevice();
            sintetizador.Rate = 0;
            sintetizador.Volume = 100;

            foreach (var voz in sintetizador.GetInstalledVoices())
            {
                if (voz.VoiceInfo.Culture.Name.StartsWith("es"))
                {
                    sintetizador.SelectVoice(voz.VoiceInfo.Name);
                    break;
                }
            }
        }

        public static void Decir(string texto)
        {
            if (!Activada) return;
            if (string.IsNullOrWhiteSpace(texto)) return;

            sintetizador.SpeakAsyncCancelAll();
            sintetizador.SpeakAsync(texto);
        }

        public static void Detener()
        {
            sintetizador.SpeakAsyncCancelAll();
        }

        public static void Alternar()
        {
            Activada = !Activada;

            if (Activada)
            {
                // Solo anuncia al activarla (si la desactivamos, obviamente no habla)
                Decir("Accesibilidad de voz activada.");
            }
            else
            {
                Detener();
            }
        }

        // --- Botón reutilizable para agregar a cualquier formulario ---
        public static Button CrearBotonToggle()
        {
            Button boton = new Button
            {
                Text = "🔊 Voz: ON",
                Size = new Size(140, 36),
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.FromArgb(230, 240, 255),
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };

            boton.FlatAppearance.BorderSize = 1;

            boton.Click += (s, e) =>
            {
                Alternar();
                ActualizarTextoBoton(boton);
            };

            return boton;
        }

        private static void ActualizarTextoBoton(Button boton)
        {
            if (Activada)
            {
                boton.Text = "🔊 Voz: ON";
                boton.BackColor = Color.FromArgb(230, 240, 255);
            }
            else
            {
                boton.Text = "🔇 Voz: OFF";
                boton.BackColor = Color.FromArgb(255, 235, 235);
            }
        }

        // Agrega el botón a un formulario, en la esquina superior derecha
        public static void AgregarBotonToggle(Form formulario)
        {
            Button boton = CrearBotonToggle();
            boton.Location = new Point(formulario.ClientSize.Width - boton.Width - 15, 10);
            boton.BringToFront();
            formulario.Controls.Add(boton);
        }
    }
}