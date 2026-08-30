using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class TRAPECIO1:Shape
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            double area = 0;
            area = ((this.BaseMayor + this.BaseMenor) * Altura) / 2;
            return area;
        }
    }
}
