using System;

namespace _10.Odd_and_Even_Product
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
           
                string value = Console.ReadLine();
                Char delimiter = ' ';
                String[] substrings = value.Split(delimiter);

                int[] oddEvens = Array.ConvertAll(substrings, int.Parse);

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


//int n = int.Parse(Console.ReadLine());
//string value = Console.ReadLine();
//Char delimiter = ' ';
//String[] substrings = value.Split(delimiter);

//int[] oddEvens = Array.ConvertAll(substrings, int.Parse);

//int sum1 = 0;
//int sum2 = 0;

//if (n % 2 == 1)
//{

//    for (int i = 0; i <= n; i = i + 2)
//    {
//        sum1 += oddEvens[i];
//    }

//    for (int j = 1; j < n; j = j + 2)
//    {
//        sum2 += oddEvens[j];
//    }
//}

//else if (n%2 == 0)
//{
//    for (int i = 0; i < n; i = i + 2)
//    {
//        sum1 += oddEvens[i];
//    }

//    for (int j = 1; j <= n; j = j + 2)
//    {
//        sum2 += oddEvens[j];
//    }
//}

//if (sum1==sum2)
//{
//    Console.WriteLine("yes {0}", sum1);
//}
//else
//{
//    Console.WriteLine("no {0} {1}", sum1 , sum2);
//}

//foreach (var oddEven in oddEvens)
//    Console.WriteLine(oddEven);

//int [] oddEven = new int[n];
//double[] myIntArray = new double[n];

//for (int i = 0; i < n; i++)
//{
//    myIntArray[i] = double.Parse(Console.ReadLine());
//}


//for ( int i=0; i< n;i++)
//{
//    oddEven[i] = int.Parse(Console.ReadLine());
//}
