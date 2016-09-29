using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = firstNumber - secondNumber;

            bool comparison = firstNumber > secondNumber;

            if (comparison)
            {
                firstNumber -= thirdNumber;
                secondNumber += thirdNumber; 
            }

            Console.WriteLine("{0} {1}",firstNumber,secondNumber);
        }
    }
}
