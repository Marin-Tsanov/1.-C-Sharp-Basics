
using System;
using System.Numerics;
using System.Collections.Generic;

namespace _12.Decimal_to_Binary
{
    class Program
    {
        static void Main()
        {

            // DECIMAL TO BINARY


            int number = int.Parse(Console.ReadLine());
            int cargo = number;
            int counter = 0;

            do
            {
                cargo = cargo / 2;
                counter += 1;
            }
            while (cargo != 0);

            BigInteger[] array = new BigInteger[counter];

            for (int i = counter - 1; i >= 0; i--)
            {
                array[i] = number % 2;
                number = number / 2;
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write("{0}", array[i]);
            }
            Console.WriteLine();

            // DECIMAL TO HEX

            //ulong number = ulong.Parse(Console.ReadLine());
            //ulong cargo = number;
            //int counter = 0;




            //do
            //{
            //    cargo = cargo / 16;
            //    counter += 1;
            //}
            //while (cargo != 0);

            //BigInteger[] array = new BigInteger[counter];

            //for (long i = counter - 1; i >= 0; i--)
            //{
            //    array[i] = number % 16;
            //    number = number / 16;
            //}

            //for (long i = 0; i < counter; i++)
            //{
            //    if (array[i]>=0 && array[i]<=9)
            //    { Console.Write(array[i]); }

            //    if (array[i] == 10 )
            //    { Console.Write("A"); }
            //    if (array[i] == 11)
            //    { Console.Write("B"); }
            //    if (array[i] == 12)
            //    { Console.Write("C"); }
            //    if (array[i] == 13)
            //    { Console.Write("D"); }
            //    if (array[i] == 14)
            //    { Console.Write("E"); }
            //    if (array[i] == 15)
            //    { Console.Write("F"); }
            //}
            //Console.WriteLine();

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

