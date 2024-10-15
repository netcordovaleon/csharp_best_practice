using BestPractices.Utils;

namespace BestPractices.BestPractices
{
    public class _02Example
    {
        /*
         * MALA PRACTICA = VALORES MAGICOS (HardCode)
         */
        public void EnviarCorreo(string asunto, string cargoDestinatario, string destinatario) {
            string formatoCorreo = string.Empty;
            if (cargoDestinatario == "gerente")
            {
                formatoCorreo = "d:/formatos/correoGerente.html";
            }
            else if (cargoDestinatario == "programador")
            {
                formatoCorreo = "d:/formatos/correoProgramador.html";
            }
            else {
                formatoCorreo = "d:/formatos/formatoGenerico.html";
            }
            Correo correo = new Correo();
            correo.Enviar(asunto, formatoCorreo, destinatario);
        }
    }
}
