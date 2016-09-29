using System;
using System.Numerics;

namespace _13.Decimal_to_Hex
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong cargo = number;
            int counter = 0;

            do
            {
                cargo = cargo / 16;
                counter += 1;
            }
            while (cargo != 0);

            BigInteger[] array = new BigInteger[counter];

            for (long i = counter - 1; i >= 0; i--)
            {
                array[i] = number % 16;
                number = number / 16;
            }

            for (long i = 0; i < counter; i++)
            {
                if (array[i] >= 0 && array[i] <= 9)
                { Console.Write(array[i]); }

                if (array[i] == 10)
                { Console.Write("A"); }
                if (array[i] == 11)
                { Console.Write("B"); }
                if (array[i] == 12)
                { Console.Write("C"); }
                if (array[i] == 13)
                { Console.Write("D"); }
                if (array[i] == 14)
                { Console.Write("E"); }
                if (array[i] == 15)
                { Console.Write("F"); }
            }
            Console.WriteLine();


            //do
            //{
            //    cargo /= 16;
            //    counter += 1;
            //}
            //while (cargo != 0);
            //Console.WriteLine(counter);
            ////object[] array = new object[counter];

            //for (ulong i = counter - 1; i >= 0; i--)
            //{
            //    array[i] = number % 16;
            //    number = number / 16;
            //}

            //for (ulong i = 0; i < counter; i++)
            //{
            //    Console.Write("{0}", array[i]);
            //}
            //Console.WriteLine();

        }
    }
}

   