using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class UC2_SnakeAndLadder
    {
        public static void getRoll()
        {
            Random rNumber = new Random();
            int roll = rNumber.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}

