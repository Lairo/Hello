using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal static class HelloGame
    {
        public const int MAXIMUM = 10;
        static Random random = new Random(10);
        static private int currentNumber = random.Next(1, 10);
        static private int nextNumber = random.Next(1, 10);
        static private int pot = 10;

        internal static int GetPot()
        {
            int newPot = pot;
            return newPot;
        }

        internal static void Guess(bool higher)
        {
            if ((nextNumber >= currentNumber && higher) || (nextNumber <= currentNumber && !higher))
            {
                Console.WriteLine("\nYou guessed right!");
                pot++;
            
            } else
            {
                Console.WriteLine("\nBad luck, you guessed wrong.");
                pot--;
            }

            currentNumber = nextNumber;
            nextNumber = random.Next(1, 10);
            Console.WriteLine($"\nThe current number is {currentNumber}.");
        }

        internal static void Hint()
        {
            float half = (float)nextNumber / 2;
            Console.WriteLine($"\nThe current number is {currentNumber}, the next is at least {half}.");
            pot--;
        }
    }
}
