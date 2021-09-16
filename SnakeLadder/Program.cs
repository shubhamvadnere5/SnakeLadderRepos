using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeLadder
    {
        //initializing instance variable
        public static int position = 0;
        //UC4 till player reaches 100 position in Snake ladder game 
        //Generating a random no using Random method()
        public static int CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 6);
            Console.WriteLine("Dice number:" + CheckDice);
            return CheckDice;
        }
        public static void CheckOption()
        {
            Random random = new Random();
            int checkOption = random.Next(0, 3);
            int dice = SnakeLadder.CheckDice();
            //switch selection statement
            switch (checkOption)
            {
                case 0:
                    Console.WriteLine("No play");
                    break;
                case 1:
                    Console.WriteLine("Snake");
                    position -= dice;
                    Console.WriteLine("Player current position" + position);
                    break;
                case 2:
                    Console.WriteLine("Ladder");
                    position += dice;
                    break;
            }
        }

        public static void WinningPosition()
        {
            //local variable
            int winPosition = 100;
            //Repetation loop till reach winposition
            while (position <= winPosition)
            {
                SnakeLadder.CheckOption();
                if (position == winPosition)
                {
                    Console.WriteLine("Player current position" + position);
                }

                else if (position < 0)
                {
                    Console.WriteLine("Restart the game");
                    Console.WriteLine("Player current position" + position);
                }
                else
                {
                    Console.WriteLine("Player current position" + position);
                }
            }
        }
        static void Main(string[] args)
        {
            SnakeLadder.WinningPosition();
            Console.ReadLine();
        }
    }
}
