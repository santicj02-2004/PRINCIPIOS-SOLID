using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo1Interfaz
{
    public class Class1:Interface1,Interface2
    {
        public string Marca { get; set; }
        public string Comb { get; set; }
        public void Encender()
        {
            Console.WriteLine($"El automóvil {Marca} ha encendido el motor.");
        }
        public void Combustible(string comb)
        {
            Comb = comb;
            Console.WriteLine($"El automóvil {Marca} usa {Comb} de combustible.");

        }



    }
}
