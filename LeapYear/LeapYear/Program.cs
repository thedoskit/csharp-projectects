// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] years = { 1923, 2022, 2000, 500 };
        int currentYear = DateTime.Now.Year;

        Console.WriteLine("Leap years:");
        int leapYearCount = 0;
        foreach (int year in years)
        {
            if (year <= currentYear)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine(year);
                    leapYearCount++;
                }
            }
            else
            {
                Console.WriteLine($"Error: {year} is beyond the current year.");
            }
        }
        Console.WriteLine($"Total leap years: {leapYearCount}");

        Console.WriteLine("\nCentury:");
        foreach (int year in years)
        {
            if (year <= currentYear)
            {
                int century = (year - 1) / 100 + 1;
                Console.WriteLine($"{year} is in the {century} century");
            }
            else
            {
                Console.WriteLine($"Error: {year} is beyond the current year.");
            }
        }
    }
}
