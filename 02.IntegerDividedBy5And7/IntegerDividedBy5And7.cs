/*Write a boolean expression that checks for given integer if it can be divided (without remainder) 
 * by 7 and 5 in the same time.*/

using System;

class IntegerDividedBy5And7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool dividedBy5 = number % 5 == 0;
        bool dividedBy7 = number % 7 == 0;
        bool dividedBy5And7 = dividedBy5 && dividedBy7;
        
        Console.WriteLine("This number can be divided by 7 and 5 in the same time: {0}", dividedBy5And7);     
    }    
}

