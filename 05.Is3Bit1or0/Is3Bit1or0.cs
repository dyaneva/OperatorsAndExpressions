// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class Is3Bit1or0
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        number = number >> 3;
        bool is3BitZero = number % 2 == 0; // The first bit of all even number is always 0 
        Console.WriteLine("The bit 3 is 0: {0}", is3BitZero);

        /*// Variant 2
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        // if using a bitwise "AND" with number that has 1 in the third bit and 
        // the result is other than 0, then the third bit of given integer is 1.
        int checkNumber = 8; 
        int result = number & checkNumber;
        bool is3BitSet = result != 0;
        Console.WriteLine("The bit 3 is 1: {0}", is3BitSet);*/
    }
}

