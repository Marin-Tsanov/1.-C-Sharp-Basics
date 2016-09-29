using System;

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = (int)Math.Pow(10, n - 1);
            int lastNumber = (int)Math.Pow(10, n) - 1;
            int counter = 0;
            for ( int i = firstNumber; i <= lastNumber; i++)
            {
                int number = i;
                int digit1 = 0;
                for (int j = 1; j <= n/2; j++)
                {
                    int firstDigits = number%10;
                    digit1 += firstDigits;
                    number = number / 10;
                }
                int digit2 = 0;
                for (int k = 0; k<=n/2; k++)
                {
                    int secondDigits = number % 10;
                    digit2 += secondDigits;
                    number = number / 10;
                }
                
                if (digit1==digit2)
                {
                    counter++;  
                }
            }
            Console.WriteLine(counter);
        }
    }
}

