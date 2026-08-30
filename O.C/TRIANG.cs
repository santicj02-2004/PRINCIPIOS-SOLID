using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class TRIANG:Shape
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double Area(){

            double area = (this.Base * this.Altura)/2;
            return area;
        
        }
    }
}
