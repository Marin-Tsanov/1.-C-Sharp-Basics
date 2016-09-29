using System;
using System.Numerics;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            string intNum = Console.ReadLine();

            int transcount = 0;

            while (intNum.Length > 1 && transcount < 10)
            {
                BigInteger product = 1;

                while (intNum.Length > 0)
                {
                    intNum = intNum.Substring(0, intNum.Length - 1);

                    int sum = 0;

                    for (int i = 0; i < intNum.Length; i += 2)
                    {
                        sum += (intNum[i] - '0');
                    }
                    if (sum != 0)
                    {
                        product *= sum;
                    }
                    else
                    {
                        product *= 1;
                    }
                }
                
                transcount++;
                intNum = product.ToString();
            }

            if (transcount < 10)
            {
                Console.WriteLine(transcount);
            }

            Console.WriteLine(intNum);
        }
    }
}

