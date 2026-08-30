using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class CROCODILE: WALK,SWIM
    {
        public void Walk()
        {
            Console.WriteLine($"THE CROCODILE CAN WALK");

        }
        public void Swim()
        {
           Console.WriteLine($"THE CROCODILE CAN SWIM");

        }

    }
}
