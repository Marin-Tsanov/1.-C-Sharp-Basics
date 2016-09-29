using System;
namespace _3.Produkt
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = 0;

            if (a<b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 1; j <= i ; j++)
                    {
                        if ( j % 2 != 0)
                        {
                            if ( i % j == 0)
                            {
                                sum += j;
                            }
                        }
                    }

                }
            }

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 != 0)
                        {
                            if (i % j == 0)
                            {
                                sum += j;
                            }
                        }
                    }

                }
            }


            Console.WriteLine(sum);
        }
    }
}
