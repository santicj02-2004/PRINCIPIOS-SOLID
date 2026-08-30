using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo1ABS
{
    public abstract class ClassABS1
    {
        public string Magn{ get; set; }
        public abstract string magnitud();
        public abstract string MostrarColor();
        public abstract double CalcularArea();
    }

}
