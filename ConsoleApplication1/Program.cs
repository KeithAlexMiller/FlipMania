using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);
            Console.ReadKey();
        }

        static void FlipCoins(int numberOfFlips)
        {
            //Declaring variables
            int numberOfHeads = 0;
            int numberOfTails = 0;

            //Random variable
            Random flip = new Random();

            //For loop that flips coins
            for (int i = 0; i < numberOfFlips; i++)
            {
                //coin flip
                int headOrTails = flip.Next(0, 2);
                //compares for heads and tails
                if (headOrTails == 0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }
            //Print the results
            Console.WriteLine("We flipped a coin {0} times.", numberOfFlips);
            Console.WriteLine("Number of Heads: " + numberOfHeads);
            Console.WriteLine("Number of Tails: " + numberOfTails);
        }

        static void FlipForHeads(int numberOfHeads)
        {
            //declares the totalFlip variable
            int totalFlips = 0;
            //declares the numberOfHeadsFlipped variable
            int numberOfHeadsFlipped = 0;
            //new Random coin flip
            Random flip = new Random();

            //loop continues until numberOfHeadsFlipped is the same as numberOfHeads
            while (numberOfHeadsFlipped < numberOfHeads)
            {
                //increment totalFlips
                totalFlips++;

                //coin flip
                int flipResult = flip.Next(0, 2);

                //determines heads or tails and increments numberOfHeadsFlipped if result is 0
                if (flipResult == 0)
                {
                    numberOfHeadsFlipped++;
                }
            }

            //print the results
            Console.WriteLine("We are flipping a coin until we get {0} heads.", numberOfHeads);
            Console.WriteLine("It took {0} to find {1} heads.", totalFlips, numberOfHeads);
        }
    }
}