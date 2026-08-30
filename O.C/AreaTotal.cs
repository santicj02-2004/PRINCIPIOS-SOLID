using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploOCInter_Abstract
{
    public class AreaTotal
    {
        public double TotalArea(List <Shape> Shapes)
        {
         double Suma = 0;
         foreach (Shape Shape in Shapes){
                Suma += Shape.Area();
            }
            return Suma;
        }
    }
}
