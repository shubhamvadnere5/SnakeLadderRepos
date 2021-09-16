using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeLadder
    {
        public static void Position()
        {
            int position = 0;
            Console.WriteLine("Player is at start position:" + position);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Single player");
            SnakeLadder.Position();
            Console.ReadLine();
        }
    }
}
