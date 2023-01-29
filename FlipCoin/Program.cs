using System;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numFlips;
            int heads = 0;
            int tails = 0;

            Console.WriteLine("Enter the number of times to flip the coin: ");
            numFlips = Convert.ToInt32(Console.ReadLine());

            if (numFlips < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
            else
            {
                Random rnd = new Random();

                for (int i = 0; i < numFlips; i++)
                {
                    double coin = rnd.NextDouble();
                    if (coin < 0.5)
                    {
                        tails++;
                    }
                    else
                    {
                        heads++;
                    }
                }

                double headPercent = (heads * 100.0) / numFlips;
                double tailPercent = (tails * 100.0) / numFlips;

                Console.WriteLine("Heads: " + headPercent + "%");
                Console.WriteLine("Tails: " + tailPercent + "%");
            }
        }
    }
}
