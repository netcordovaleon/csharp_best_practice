using BestPractices.Utils;

namespace BestPractices.BestPractices
{
    public class _01Example
    {
        /*
         * MALA PRACTICA = VARIABLES QUE REPRESENTAN NADA
         */
        public void Env(string a, string b, string c) {
            string f = string.Empty;
            if (b == "gerente")
            {
                f = "d:/formatos/correoGerente.html";
            }
            else if (b == "programador")
            {
                f = "d:/formatos/correoProgramador.html";
            }
            else
            {
                f = "d:/formatos/formatoGenerico.html";
            }
            Correo cor = new Correo();
            cor.Enviar(a, b, c);
        }
    }
}
