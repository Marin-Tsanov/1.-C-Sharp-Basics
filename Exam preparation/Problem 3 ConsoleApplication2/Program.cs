using System;
using System.Numerics;

namespace Problem_3_ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            
            BigInteger globalProduct = 1;

            while (true)
            {
                string text = Console.ReadLine();
                if (text == "END")
                {
                    break;
                }

                BigInteger number = BigInteger.Parse(text);
                if (counter == 10)
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }

                if (counter % 2 == 0)
                {
                    BigInteger product = 1;
                    while (number > 0)
                    {
                        
                        BigInteger digit = number % 10;
                        number = number / 10;
                        if (digit == 0)
                        {
                            digit = 1;
                        }
                        product *= digit;
                    }
                    globalProduct *= product;
                }
                counter++;
            }
            Console.WriteLine(globalProduct);
        }
    }
}

