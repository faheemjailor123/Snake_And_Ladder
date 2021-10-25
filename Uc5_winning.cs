using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        public const int noplay = 0;
        public const int ladder = 1;
        public const int snake = 2;
        public const int final = 100;

        static void Main(string[] args)
        {

            int p = 0;
            int position = 0;

            Random die = new Random();
            Random options = new Random();
            Console.WriteLine("game starts");
            Random r = new Random();


            while (position < final)
            {
                int dice = die.Next(1, 7);
                Console.WriteLine("The number on this die roll is: " + dice);
                int opt = options.Next(0, 3);

                if (opt == noplay)
                {
                    Console.WriteLine("No play: Player in same position " + p);
                    Console.ReadLine();
                }
                else if (opt == ladder)
                {
                    p = p + dice;
                    if (p > 100)
                    {
                        Console.WriteLine("Try Again, throw exceeded 100 ");
                        p = p - dice;
                    }
                    else
                    {
                        Console.WriteLine("Ladder new postion is  " + p);
                        Console.ReadLine();
                    }

                }



            else
            {
                p = p - dice;
                Console.WriteLine("snake is in new position  " + p);
                Console.ReadLine();
            }

                if (position < 0)
                {
                    position = 0;
                }

            }
        }
    }
}
