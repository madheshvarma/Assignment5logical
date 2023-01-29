using System;
using System.Reflection;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            // Check if year is a 4-digit number
            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Invalid input. Please enter a 4-digit year.");
                return;
            }

            // Determine if year is a leap year
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}




