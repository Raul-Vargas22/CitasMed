using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Speech.Synthesis;

namespace CitasMed
{
    public static class AsistenteVoz
    {
        private static readonly SpeechSynthesizer sintetizador = new SpeechSynthesizer();

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
            if (string.IsNullOrWhiteSpace(texto)) return;
            sintetizador.SpeakAsyncCancelAll();
            sintetizador.SpeakAsync(texto);
        }

        public static void Detener()
        {
            sintetizador.SpeakAsyncCancelAll();
        }
    }
}