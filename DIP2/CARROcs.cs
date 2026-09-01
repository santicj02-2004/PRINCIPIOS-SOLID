using System;
using System.Collections.Generic;
using System.Text;

namespace DIP2
{
    public class CARRO
    {
        private readonly IMOTOR _motor;


        public  CARRO (IMOTOR motor)
        {

            _motor = motor;

        }
        public void Encendido()
        {
            _motor.Arrancar();
        }

    }
}
