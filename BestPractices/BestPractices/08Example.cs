using System.Net.Mail;
using BestPractices.Utils;

namespace BestPractices.BestPractices
{
    public class _08Example
    {

        public bool EsMayorDeEdad(int edad) {
            if (edad > 18)
            {
                return true;
            }
            else {
                return false;
            }
        }


        public int Operacion(int numero1, int numero2, int? numero3) {

            if (numero3 == null)
            {
                return numero1 + numero2;
            }
            else {
                return numero1 + numero2 + numero3.Value;
            }
        }

    }
}
