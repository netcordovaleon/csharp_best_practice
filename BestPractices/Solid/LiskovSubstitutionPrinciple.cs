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
    public class Bird
    {
        public virtual void Fly() { /* implementation */ }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins can't fly!");
        }
    }


    /*
    DESPUES DE APLICAR PRINCIPIO 
    */
    public interface IFlyable
    {
        void Fly();
    }

    public class BirdLisvok : IFlyable
    {
        public void Fly()
        {
            // implementation specific to Bird
        }
    }

    public class PenguinLisvok : IFlyable
    {
        public void Fly()
        {
            // implementation specific to Penguins
            throw new NotImplementedException("Penguins can't fly!");
        }
    }
}
