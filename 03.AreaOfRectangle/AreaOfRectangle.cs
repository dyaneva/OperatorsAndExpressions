//Write an expression that calculates rectangle’s area by given width and height.

using System;

class AreaOfRectangle
{
    static void Main()
    {
        Console.Write("Enter the width of rectangle: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter the height of rectangle: ");
        int height = int.Parse(Console.ReadLine());

        int areaOfRectangle = width * height;
        Console.WriteLine("The rectangle’s area is: {0}", areaOfRectangle);
    }

}
