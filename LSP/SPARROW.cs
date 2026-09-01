using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class SPARROW:Animal,IVolar
    {
        public SPARROW(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"EL GORREOON PÍA");
        }
        public void FLY()
        {
            Console.WriteLine($"EL GORREON TAMBIÉN VUELA");
        }

    }
}
