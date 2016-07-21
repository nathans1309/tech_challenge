using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of items you have to pack:");
            int numOfItems = 0;

            while( !inputIsValid(Console.ReadLine(), ref numOfItems) )
            {
                Console.WriteLine("Input not valid. Please enter a positive number:");
            }


            //We have a valid number
            int bigBoxCount = numOfItems / 5;
            int smallBoxCount = numOfItems % 5;
            int totalBoxCount = bigBoxCount + smallBoxCount;

            Console.WriteLine($"{numOfItems} products = {totalBoxCount} boxes ({bigBoxCount} large boxes + {smallBoxCount} small boxes)");

            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }

        private static bool inputIsValid(string input, ref int numOfItems)
        {
            return (int.TryParse(input, out numOfItems) && numOfItems >= 0);
        }
    }
}
