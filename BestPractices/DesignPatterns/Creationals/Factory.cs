using System.Diagnostics;

namespace BestPractices.DesignPatterns.Creationals
{
    public class WithoutFactory
    {
        //Calcular promedio notas
        public int CalculateAverage(string instituto, int nota1, int nota2, int nota3) {
            if (instituto == "IDAT")
            {
                var puntosNota1 = nota1 * 0.3;
                var puntosNota2 = nota2 * 0.3;
                var puntosNota3 = nota3 * 0.4;
                return Convert.ToInt32(puntosNota1 + puntosNota2 + puntosNota3);
            }
            else if (instituto == "CIBERTEC")
            {
                var puntosNota1 = nota1 * 0.2;
                var puntosNota2 = nota2 * 0.2;
                var puntosNota3 = nota3 * 0.6;
                return Convert.ToInt32(puntosNota1 + puntosNota2 + puntosNota3);
            }
            else if (instituto == "ISIL")
            {
                return (nota1 + nota2 + nota3) / 3;
            }
            else { 
                throw new NotImplementedException();
            }
        }
    }

    // IMPLEMENTACION FACTORY PATTERN
    public interface ICalculateAverage {
        int Average(int nota1, int nota2, int nota3);
    }

    public class IDATAverages : ICalculateAverage
    {
        public int Average(int nota1, int nota2, int nota3)
        {
            var puntosNota1 = nota1 * 0.3;
            var puntosNota2 = nota2 * 0.3;
            var puntosNota3 = nota3 * 0.4;
            return Convert.ToInt32(puntosNota1 + puntosNota2 + puntosNota3);
        }
    }

    public class CIBERTECAverages : ICalculateAverage
    {
        public int Average(int nota1, int nota2, int nota3)
        {
            var puntosNota1 = nota1 * 0.2;
            var puntosNota2 = nota2 * 0.2;
            var puntosNota3 = nota3 * 0.6;
            return Convert.ToInt32(puntosNota1 + puntosNota2 + puntosNota3);
        }
    }

    public class ISILAverages : ICalculateAverage
    {
        public int Average(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }


    public class InstituteFactory {
        public enum Institutes { 
            IDAT,
            CIBERTEC,
            ISIL
        }

        private ICalculateAverage _instance;
        
        public ICalculateAverage Buid(Institutes institute) {

            switch (institute) {

                case Institutes.IDAT:
                    _instance = new IDATAverages();
                    break;
                case Institutes.CIBERTEC:
                    _instance = new CIBERTECAverages();
                    break;
                case Institutes.ISIL:
                    _instance = new ISILAverages();
                    break;
            }
            return _instance;
        }

    }

}

