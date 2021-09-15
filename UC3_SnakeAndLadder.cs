using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class UC3_SnakeAndLadder
    {
		static int P_SCORE = 0;
		static int rollDice;

		//Method to check for Option Play
		public static void optionPlay()
		{
			Random rNumber = new Random();
			rollDice = rNumber.Next(1, 7);
			//Console.WriteLine(rollDice);
			Random opNumber = new Random();
			int optionNum = (opNumber.Next(0,3));

			if (optionNum == 2)
			{
				P_SCORE = P_SCORE + rollDice;
				Console.WriteLine("P position after getting Ladder: " + P_SCORE);
			}
			else if (optionNum == 1)
			{
				P_SCORE = P_SCORE - rollDice;
				Console.WriteLine("P position after getting Snake: " + P_SCORE);
			}
			else
			{
				Console.WriteLine("No Move: " + P_SCORE);
			}
		}
	}
}
