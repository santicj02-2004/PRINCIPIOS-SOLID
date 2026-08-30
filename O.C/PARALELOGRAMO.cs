using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class PARALELOGRAMO:Shape
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            double area = 0;
            area = this.Base * this.Altura;
            return area;
        }
    }
}
