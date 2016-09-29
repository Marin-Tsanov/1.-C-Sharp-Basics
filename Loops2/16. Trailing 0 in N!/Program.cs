using System;
using System.Numerics;

namespace _16.Trailing_0_in_N_
{
    class Program
    {
        static void Main()
        {

            decimal number = decimal.Parse(Console.ReadLine());

            BigInteger math = 0;


            if (number / 5 > 1)
            { do
                {
                    math += (BigInteger)(number / 5);
                    number = number/5;
                }
                while ((number / 5) >1);

                Console.WriteLine(math);

            }
            else
            {
                Console.WriteLine("0");
            }
            

            // THIS WAS MY WAY VERY SLOW AND DOES NOT WORK WITH HUGE NUMBERS
             
            //BigInteger number = BigInteger.Parse(Console.ReadLine());

            //BigInteger factorielNumber = 1;

            //for (BigInteger i = 1; i <= number; i++)
            //{
            //    factorielNumber *= i;
            //}
            
            //BigInteger counter = 0;


            //Console.WriteLine(factorielNumber);
            //while (factorielNumber % 10 == 0)
            //{
            //    counter++;
            //    factorielNumber = factorielNumber / 10;
            //}


            //Console.WriteLine(counter);
        }
    }
}
