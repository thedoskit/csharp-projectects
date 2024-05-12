// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Example array of integers

        // Count prime, even, and odd numbers
        int primeCount = 0;
        int evenCount = 0;
        int oddCount = 0;

        // Sum of prime, even, and odd numbers
        int primeSum = 0;
        int evenSum = 0;
        int oddSum = 0;

        foreach (int num in numbers)
        {
            if (IsPrime(num))
            {
                primeCount++;
                primeSum += num;
            }
            else if (num % 2 == 0)
            {
                evenCount++;
                evenSum += num;
            }
            else
            {
                oddCount++;
                oddSum += num;
            }
        }

        // Output results
        Console.WriteLine("Prime numbers count: " + primeCount);
        Console.WriteLine("Even numbers count: " + evenCount);
        Console.WriteLine("Odd numbers count: " + oddCount);
        Console.WriteLine("Sum of prime numbers: " + primeSum);
        Console.WriteLine("Sum of even numbers: " + evenSum);
        Console.WriteLine("Sum of odd numbers: " + oddSum);
    }

    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num <= 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;
        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true;
    }
}
