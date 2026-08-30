using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo1ABS
{
    public class Class1:ClassABS1
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public string Color { get; set; }

        public override string magnitud()
        {
            return Magn;
        }
        public override string MostrarColor()
        {
            return Color;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
