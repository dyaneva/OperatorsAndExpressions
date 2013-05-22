// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

class IsThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isThirdDigit7 = (number / 100) % 10 == 7;

        Console.WriteLine("The third digit is 7: " + isThirdDigit7);
    }

}
