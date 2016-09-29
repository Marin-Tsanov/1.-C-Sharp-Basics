using System;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            BigInteger globalProduct = 1;

            while (true)
            {
                string data = Console.ReadLine();
                

                if (data == "END")
                {
                    break;
                }

                if (counter == 10)
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }


                BigInteger number = BigInteger.Parse(data);

                if (counter % 2 == 1)
                {
                    long product = 1;

                    while (number > 0)
                    {
                        long digit = (long)(number % 10);

                        if (number == 0)
                        {
                            digit = 1;
                        }
                        number = number / 10;

                        if (digit != 0)
                        {
                            product *= digit;
                        }
                    }

                    globalProduct *= product;
                }

                counter++;
            }

            Console.WriteLine(globalProduct);

        }
    }
}
