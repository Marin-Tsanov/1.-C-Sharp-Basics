using System;
using System.Numerics;

namespace Problem_3_Maslan
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            
            BigInteger transformation = 0;

            while (number.Length > 1)
            {
                if (transformation>9)
                {
                    break;
                }

                BigInteger product = 1;

                while (number.Length > 0)
                {
                    number = number.Substring(0, number.Length - 1);

                    BigInteger sum = 0;


                    for (int i = 1; i < number.Length; i += 2)
                    {
                        sum += number[i] - '0';

                       
                    }
                    if (sum == 0)
                    {
                        sum = 1;
                    }
                    product *= sum;
                }
                transformation++;
                number = product.ToString();
            }

            if (transformation<9)
            {
                Console.WriteLine(transformation);
            }

            Console.WriteLine(number);
        }
    }
}
