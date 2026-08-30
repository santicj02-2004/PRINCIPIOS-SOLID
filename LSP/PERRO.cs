using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class PERRO:Animal
    {
        public override void Sonido()
        {
            Console.WriteLine($"The dog barks");
        }
    }
}
