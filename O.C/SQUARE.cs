using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class SQUARE:Shape
    {
        public double Lado { get; set; }

        public override double Area()
        {
            double area = this.Lado * this.Lado;
            return area;
        }

    }
}
