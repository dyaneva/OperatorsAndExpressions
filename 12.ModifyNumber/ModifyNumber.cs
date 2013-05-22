// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that 
// modifies n to hold the value v at the position p from the binary representation of n.
// Example: n = 5 (00000101), p=3, v=1  13 (00001101); n = 5 (00000101), p=2, v=0  1 (00000001)

using System;

class ModifyNumber
{
    static void Main()
    {
        Console.Write("Enter a number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a number p (position of bit): ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a value of the bit v: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        int valueOfBit = n & mask;
        if (valueOfBit != 0)
        {
            n = n & (~mask); // reset the bit at a position p
            Console.WriteLine("The new number is: {0}", n);
        }
        else
        {
            n = n | mask; // set the bit at a position p
            Console.WriteLine("The new number is: {0}", n);
        }
    }
}    

