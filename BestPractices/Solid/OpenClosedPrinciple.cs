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
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class AreaCalculator
    {
        public double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }


    /*
    DESPUES DE APLICAR PRINCIPIO 
    */
    public interface IShape
    {
        double CalculateArea();
    }

    public class RectangleOpenClosed : IShape
    {
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }

    public class CircleOpenClosed : IShape
    {
        public double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
