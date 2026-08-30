using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class FLYING_FISH:SWIM,FLY1
    {
        public void Fly()
        {
            Console.WriteLine($"THE FLYING FISH CAN FLY");

        }
        public void Swim()
        {
            Console.WriteLine($"THE FLYING FISH CAN SWIM");

        }

    }
}
