// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and 
// out of the rectangle R(top=1, left=-1, width=6, height=2).


using System;

class PointInCircleAndOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter point (x, y):");
        Console.Write("x=");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("y=");
        decimal y = decimal.Parse(Console.ReadLine());

        // x and y must satisfy (x-center_x)^2 + (y - center_y)^2 < radius^2 
        bool isPointInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) < 3 * 3;
        // rectangle R((-1;1); (5;-1))
        bool isPointOutRectangle = (((x < -1) || (x > 5)) || ((y > 1) || (y < -1)));
        bool isPointInCircleAndOutRectangle = isPointInCircle && isPointOutRectangle;
        Console.WriteLine("This point is within the circle and out of the rectangle: {0}", isPointInCircleAndOutRectangle);
    }
}

