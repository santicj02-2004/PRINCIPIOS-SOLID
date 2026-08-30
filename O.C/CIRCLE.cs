using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class CIRCLE : Shape
    {
        public double Radio { get; set; }

        public override double Area()
        {
            double Area = this.Radio * this.Radio * Math.PI;
            return Area;
        }
    }
}
