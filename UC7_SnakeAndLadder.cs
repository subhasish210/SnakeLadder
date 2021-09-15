using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    class UC7_SnakeAndLadder
    {
		public static int P1 = 0;
		public static int P2 = 0;
		public static int rollDice;
		public static int count = 0;
		public static int currentP = -1;
		public static int P;

		public static void Main(String[] args)
		{
			//Loop to check Player winning position=100
			while (P != 100)
			{
				getRoll();//calling function for rolling dice
				//Condition for switching between P alternative turn
				if (currentP == -1)
				{
					P1 = startGame(P1, rollDice);//Calling the method to start game for P-1.
					Console.WriteLine("P1 position: " + P1);
				}
				else
				{
					P2 = startGame(P2, rollDice);//Calling the method to start game for P-2.
					Console.WriteLine("P2 position: " + P2);

				}
				currentP = -currentP;//switching P position

			}
			Console.WriteLine("Total count is :" + count);//Total no. of time dice is rolled.
		}

		//Method for Rolling Dice
		public static int getRoll()
		{
			Random rNumber = new Random();
			rollDice = rNumber.Next(1, 7);
			count++;//Count the number of time die is roll
			return rollDice;
		}

		//Method to check for Option Play
		public static int startGame(int PScore, int rollDice)
		{
			P = PScore;
			Random opNumber = new Random();
			int optionNum = (opNumber.Next(0, 3));//Check the option play for each roll

			if (optionNum == 2)
			{
				//LADDER OPTION
				P = P + rollDice;
				if (P >= 100)
				{
					P = 100;
				}
			}
			else if (optionNum == 1)
			{
				//SNAKE OPTION
				P = P - rollDice;
				if (P < 0)
				{
					P = 0;
				}
			}
			else
			{
				//NO PLAY
			}
			return P;
		}
	}
}
