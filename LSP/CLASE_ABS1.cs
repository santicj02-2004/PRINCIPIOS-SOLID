using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public Animal(string nombre)
        {
            Nombre=nombre;
        }
        public abstract void HacerSonido();
    }
}
