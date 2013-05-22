/* Write a boolean expression that returns if the bit at position p (counting from 0) 
 * in a given integer number v has value of 1. Example: v=5; p=1  false.*/

using System;

class IsBit1or0
{
    static void Main()
    {
        Console.Write("Enter a number v: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a number p (position of bit): ");
        int p = int.Parse(Console.ReadLine());
        v = v >> p;
        bool isBitPSet = v % 2 != 0; // The first bit of all odd number is always 1         
        Console.WriteLine("The bit at position p is 1: {0}", isBitPSet);
     }
}
