using BestPractices.Utils;

namespace BestPractices.BestPractices
{
    public class _04Example
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
        * MALA PRACTICA = GESTION DE ERROR INSUFICIENTE
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
            catch (Exception ex)
            {
                Correo correo = new Correo();
                correo.NotificarError(ex);
            }
        }
    }
}
