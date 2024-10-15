using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractices.Solid
{
    /*
    ANTES DE APLICAR PRINCIPIO 
    */
    public class Empleado
    {
        public void GenerarReporteEmpleado() { }
        public void RegistrarEmpleado() { }
    }

    /*
    DESPUES DE APLICAR PRINCIPIO
    */

    public class EmpleadoRepository
    {
        public void Registrar() { }
    }

    public class EmpleadoReport
    {
        public void Generar() { }
    }

}
