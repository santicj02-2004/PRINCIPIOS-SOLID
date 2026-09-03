using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class PERRO:Animal
    {
        public PERRO(string Nombre) : base(Nombre) {  }

        public override void HacerSonido()
        {
            Console.WriteLine($"EL PERRO {Nombre} LADRA MUCHO");
        }

    }
}
