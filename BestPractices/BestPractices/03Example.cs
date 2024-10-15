using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestPractices.Utils;

namespace BestPractices.BestPractices
{

    public class GeneralConstants {
        public const string GERENTE = "gerente";
        public const string PROGRAMADOR = "programador";

        public const string FORMATO_CORREO_GERENTE = "d:/formatos/correoGerente.html";
        public const string FORMATO_CORREO_PROGRAMADOR = "d:/formatos/correoProgramador.html";
        public const string FORMATO_CORREO_GENERICO = "d:/formatos/formatoGenerico.html";

    }

    public class _03Example
    {
        /*
         * MALA PRACTICA = FALTA DE MANEJO DE EXCEPCIONES
         */
        public void EnviarCorreo(string asunto, string cargoDestinatario, string destinatario)
        {
            string formatoCorreo = string.Empty;
            switch (cargoDestinatario) { 
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
    }
}
