using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hello.");
            Console.WriteLine($"Guess numbers between 1 and {HelloGame.MAXIMUM}.");
            HelloGame.Hint();
            while (HelloGame.GetPot() > 0)
            {
                Console.WriteLine("\nPress h for a higher, l for lower, ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with {HelloGame.GetPot().ToString("c")}.");
                Console.WriteLine("or $ to cheat.");
                char key = Console.ReadKey().KeyChar;
                if (key == 'h') HelloGame.Guess(true);
                else if (key == 'l') HelloGame.Guess(false);
                else if (key == '?') HelloGame.Hint();
                else if (key == '$') Cheat();
                else return;
            }
            Console.WriteLine("The is empty. Bye!");
        }

        internal static void Cheat()
        {   HelloGame.random = new Random(1);
            Random cheatRandom = new Random(1);
            Console.WriteLine("The first 20 numbers will be: ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write(cheatRandom.Next(1, HelloGame.MAXIMUM +1) + " ");
            }
        }
    }
}
