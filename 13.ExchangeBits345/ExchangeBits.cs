// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int first3Bits = number & (7 << 3);
        int last3Bits = number & (7 << 23);
        int mask = number & (~((7 << 3) | (7 << 23)));
        int newNumber = mask | (first3Bits << 21);
        newNumber = newNumber | (last3Bits >> 21);

        Console.WriteLine("    The number is:{0,10}=>{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The new number is:{0,10}=>{1}", newNumber, Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}
        
