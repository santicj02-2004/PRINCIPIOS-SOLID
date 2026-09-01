using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class EAGLE:Animal,IVolar
    {
        public EAGLE(string nombre) : base(nombre) { }

        public override void HacerSonido()
        {
            Console.WriteLine($"EL ÁGUILA CHILLA");
        }
        public void FLY()
        {
            Console.WriteLine($"EL AGUILA TAMBIÉN VUELA");
        }
    }
}
