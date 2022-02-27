using System;

namespace Operators_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 6;
            int secondNumber = 14;
            int plusPlus = firstNumber++;
            int minusMinus = secondNumber--;
            int plus = firstNumber + secondNumber;
            int minus = firstNumber - secondNumber;
            int multiplication = plusPlus * minus;
            int division = secondNumber / plusPlus;

            Console.WriteLine("plusPlus equals to: " + plusPlus);
            Console.WriteLine("minusMinus equals to: " + minusMinus);
            Console.WriteLine("plus equals to: " + plus);
            Console.WriteLine("minus equals to: " + minus);
            Console.WriteLine("multiplication equals to: " + multiplication);
            Console.WriteLine("division equals to: " + division);
        }
    }
}
