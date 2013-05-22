// Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} 
// of given 32-bit unsigned integer.

using System;

class ExchangeBitsPQ
{
    static void Main()
    {
        int p, q, k;
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter the bit number p: ");
            p = int.Parse(Console.ReadLine());
            Console.Write("Enter the bit number q: ");
            q = int.Parse(Console.ReadLine());
            Console.Write("Enter the bit number k: ");
            k = int.Parse(Console.ReadLine());
        }
        while ((p + k > 32) || (q + k > 32) || ((p < q) && (q < p + k)) || ((q < p) && (p < q + k)));

        int numberK = Convert.ToInt32(Math.Pow(2, k)) - 1;
        int firstKBits = number & (numberK << p);
        int lastKBits = number & (numberK << q);
        int mask = number & (~((numberK << p) | (numberK << q)));
        int newNumber = mask | (firstKBits << (q - p));
        newNumber = newNumber | (lastKBits >> (q - p));

        Console.WriteLine("    The number is:{0,10}=>{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The new number is:{0,10}=>{1}", newNumber, Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}


