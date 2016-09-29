using System;
using System.Numerics;
using System.Collections.Generic;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                int cargo;
                cargo= number;
                cargo = cargo / 2;
                counter +=1 ;

                if (cargo == 0)
                {
                    break;
                }
            }


            Console.WriteLine(counter);
            
            //BigInteger[] deck = new BigInteger[counter];

            //for (int i = 0; i < counter; i++)
            //{
            //    deck[i] = number % 2;
            //    number = number / 2;
            //}


            //for (int i = 0; i < deck.Length; i++)
            //{
            //    Console.Write("{0}", deck[i]);
            //}
          


            //BigInteger binary = BigInteger.Parse(Console.ReadLine());
            //int length = binary.ToString().Length;

            //BigInteger[] deck = new BigInteger[length];

            //for (int i = 0; i < length; i++)
            //{
            //    deck[i] = binary % 10;
            //    binary = binary / 10;
            //}

            //double decima = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    if (deck[i] == 1)
            //    {
            //        decima += (Math.Pow(2, i));
            //    }
            //}
            //Console.WriteLine(decima);
        }
    }
}
