using System;
using System.Collections.Generic;
using System.Text;

namespace DIP2
{
    public class MOTOGASO: IMOTOR
    {
        public void Arrancar()
        {
            Console.WriteLine($"   CARRO 4 TIEMPOS LISTO   ");
            Console.WriteLine($"Gasolina lista para arracar");
            Console.WriteLine($"    ");
        }
    }
}
