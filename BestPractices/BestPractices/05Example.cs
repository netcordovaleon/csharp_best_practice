using System.Net.Mail;
using BestPractices.Utils;

namespace BestPractices.BestPractices
{
    public class _05Example
    {
        public class GeneralConstants
        {
            public const string GERENTE = "gerente";
            public const string PROGRAMADOR = "programador";

            public const string FORMATO_CORREO_GERENTE = "d:/formatos/correoGerente.html";
            public const string FORMATO_CORREO_PROGRAMADOR = "d:/formatos/correoProgramador.html";
            public const string FORMATO_CORREO_GENERICO = "d:/formatos/formatoGenerico.html";

        }
        /*
        * MALA PRACTICA = SEPARAR ACCIONES
        */
        public void EnviarCorreo(string asunto, string cargoDestinatario, string destinatario)
        {
            try
            {
                string formatoCorreo = string.Empty;
                switch (cargoDestinatario)
                {
                    case GeneralConstants.GERENTE:
                        formatoCorreo = GeneralConstants.FORMATO_CORREO_GERENTE;
                        break;
                    case GeneralConstants.PROGRAMADOR:
                        formatoCorreo = GeneralConstants.FORMATO_CORREO_PROGRAMADOR;
                        break;
                    default:
                        formatoCorreo = GeneralConstants.FORMATO_CORREO_GENERICO;
                        break;
                }
                Correo correo = new Correo();
                correo.Enviar(asunto, formatoCorreo, destinatario);
            }
            catch (DirectoryNotFoundException ex)
            {
                //Error con el directorio de formato de correos (Enviar correo a SOPORTE)
                Correo correo = new Correo();
                correo.NotificarError(ex);
            }
            catch (SmtpException ex)
            {
                //Error con el servidor de Correos (Enviar correo a MICROSOFT)
                Correo correo = new Correo();
                correo.NotificarError(ex);
            }
            catch (Exception ex)
            {
                //Error Generico (Enviar correo a los PROGRAMADORES)
                Correo correo = new Correo();
                correo.NotificarError(ex);
            }
        }
    }
}
