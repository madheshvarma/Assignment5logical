using System;

namespace powerof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, p = 1;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a value");
            if (num > 31)
            {
                Console.WriteLine("number should be less than given");
                return;
            }
            else
            {
                for (int j = 1; j <= num; j++)
                {
                    p = p * 2;
                    Console.WriteLine(p);
                }
            }
        }
    }
}
