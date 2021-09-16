using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeLadder
    {
        //UC2 Rolls a Dice
        public static void CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 6);
            Console.WriteLine("The player rolls a dice:" + CheckDice);
        }

        static void Main(string[] args)
        {
            SnakeLadder.CheckDice();
            Console.ReadLine();
        }
    }
}
