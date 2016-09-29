using System;

namespace _10_Odd_and_Even_Product_2nd_solution
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string [] value = Console.ReadLine().Split(' ');

            int[] oddEvens = new int [n];

            for ( int i=0; i<n; i++)
            {
                oddEvens[i] = int.Parse(value[i]);
            }

            long product1 = 1;
            long product2 = 1;

            for (int i = 0; i < n; i = i + 2)
            {
                product1 *= oddEvens[i];
            }

            for (int j = 1; j < n; j = j + 2)
            {
                product2 *= oddEvens[j];
            }

            if (product1 == product2)
            {
                Console.WriteLine("yes {0}", product1);
            }
            else
            {
                Console.WriteLine("no {0} {1}", product1, product2);
            }
        }
    }
}
