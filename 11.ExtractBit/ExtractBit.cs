// Write an expression that extracts from a given integer i the value of a given bit number b. 
// Example: i=5; b=2  value=1.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter an integer i: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit number b: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << b;
        bool valueOfBit = (i & mask) != 0;
        Console.WriteLine("The value of a bit is: {0}", valueOfBit ? 1 : 0);
     }
}  

