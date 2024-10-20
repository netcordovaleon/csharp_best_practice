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
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class Manager : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    public class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }


    /*
    DESPUES DE APLICAR PRINCIPIO 
    */

    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class ManagerSegregation : IWorkable, IEatable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    public class RobotSegregation : IWorkable
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
