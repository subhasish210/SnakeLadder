using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class UC4_SnakeAndLadder
    {
		static int NUMBER_OF_P = 1;
		public static int P_SCORE = 0;
		static int rollDice;
        public static void Main(string[] args)
        {
            while (P_SCORE != 100)
            {
                optionPlay();// calling function to check the optionPlay
            }
        }

        //Method to check for Option Play
        public static void optionPlay()
		{
			Random rNumber = new Random();
			rollDice = rNumber.Next(1, 7);
			Random opNumber = new Random();
			int optionNum = opNumber.Next(0, 3);

			if (optionNum == 2)
			{
				P_SCORE = P_SCORE + rollDice;
				Console.WriteLine("Player position after getting Ladder: " + P_SCORE);
			}
			else if (optionNum == 1)
			{
				P_SCORE = P_SCORE - rollDice;
				if (P_SCORE < 0)
				{
					P_SCORE = 0;
				}
				Console.WriteLine("Player position after getting Snake: " + P_SCORE);
			}
			else
			{
				Console.WriteLine("Player position for No Play " + P_SCORE);
			}
		}
	}
}
