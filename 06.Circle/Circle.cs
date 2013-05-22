// Write an expression that checks if given point (x, y) is within a circle K(O, 5). 

using System;

class Circle
{
    static void Main()
    {
        Console.WriteLine("Enter point (x, y):");
        Console.Write("x=");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("y=");
        decimal y = decimal.Parse(Console.ReadLine());
        
        // x and y must satisfy (x-center_x)^2 + (y - center_y)^2 < radius^2 
        decimal xy = x * x + y * y;
        bool isPointInCircle = xy < 5 * 5;
        Console.WriteLine("This point is within the circle: {0}", isPointInCircle);
    }
}
