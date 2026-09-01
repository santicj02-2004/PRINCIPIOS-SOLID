using System;
using System.Collections.Generic;
using System.Text;

namespace DIP2
{
    public class MOTORELE:IMOTOR
    {
        public void Arrancar()
        {
            Console.WriteLine($"   CARRO ELECTRICO LISTO   ");
            Console.WriteLine($"Carga lista para arrancar");
            Console.WriteLine($"    ");
        }
    }
}
