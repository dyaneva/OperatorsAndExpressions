// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n <= 100)
        {
            bool dividedBy2 = n % 2 > 0;
            bool dividedBy3 = n % 3 > 0;
            bool dividedBy5 = n % 5 > 0;
            bool dividedBy7 = n % 7 > 0;
            bool primeNumber = dividedBy2 && dividedBy3 && dividedBy5 && dividedBy7;
            Console.WriteLine("This is prime number: {0}", primeNumber);
        }
        else
        {
            Console.WriteLine("The number does not satisfy the condition!");
        }
    }
}
