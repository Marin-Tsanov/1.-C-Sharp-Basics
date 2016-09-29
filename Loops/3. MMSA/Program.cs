using System;

namespace _3.MMSA
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[] myIntArray = new double[n];
            double min_value = 18446744073709551615D;
            double max_value = -18446744073709551615D;
            double sum = 0;
            double average;

            for (int i = 0; i < n; i++)
            {
                myIntArray[i] = double.Parse(Console.ReadLine());
            }

            for (int j = 0; j < myIntArray.Length; j++)
            {
                if (myIntArray[j] < min_value)
                {
                    min_value = myIntArray[j];
                }
            }
            Console.WriteLine("min={0:F2}", min_value);

            for (int m = 0; m < myIntArray.Length; m++)
            {
                if (myIntArray[m] > max_value)
                {
                    max_value = myIntArray[m];
                }
            }
            Console.WriteLine("max={0:F2}", max_value);

            for (int k = 0; k < myIntArray.Length; k++)
            {
                sum += myIntArray[k];
                
            }
            Console.WriteLine("sum={0:F2}", sum);

            average = sum / (n);
               
                Console.WriteLine("avg={0:F2}", average);
            }
        }
    }

