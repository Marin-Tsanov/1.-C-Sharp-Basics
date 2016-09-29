using System;

namespace _4.MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            int firstNumber = Math.Sign(double.Parse(Console.ReadLine()));
            int secondNumber = Math.Sign(double.Parse(Console.ReadLine()));
            int thirdNumber = Math.Sign(double.Parse(Console.ReadLine()));

            if ((firstNumber == 1 && secondNumber == 1 && thirdNumber == 1)
                || (firstNumber == -1 && secondNumber == -1 && thirdNumber == 1)
                || (firstNumber == -1 && secondNumber == 1 && thirdNumber == -1)
                || (firstNumber == 1 && secondNumber == -1 && thirdNumber == -1))
            {
                Console.WriteLine("+");
            }
            else if ((firstNumber == -1 && secondNumber == -1 && thirdNumber == -1)
                || (firstNumber == 1 && secondNumber == 1 && thirdNumber == -1)
                || (firstNumber == 1 && secondNumber == -1 && thirdNumber == 1)
                || (firstNumber == -1 && secondNumber == 1 && thirdNumber == 1))
            {
                Console.WriteLine("-");
            }
            else if ((firstNumber == 0 || secondNumber == 0 || thirdNumber == 0))
            {
                Console.WriteLine("0");
            }
        }
    }
}
