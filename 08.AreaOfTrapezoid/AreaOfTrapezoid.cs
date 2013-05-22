// Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        Console.Write("Enter the side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the side b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the height h: ");
        int h = int.Parse(Console.ReadLine());
          
        decimal areaOfTrapezoid = (decimal)(a+b) * h/2;
        Console.WriteLine("The area of trapezoid is: " + areaOfTrapezoid);
    }
}
