using System;
using System.Numerics;

namespace _2.Speeds
{
    class Program
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());

            int[] array = new int[c];

            for (int i = 0; i < c; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            BigInteger currentValue = 0;
            BigInteger maxValue = 0;
            BigInteger sum1 = 0;
            BigInteger sum2 = 0;
            BigInteger counter = 0;
            int group = 1;
            int groupMax = 0;

            for (int i = c - 1, j = c - 2; i > 0; i--, j--)
            {
                sum1 = 0;
                sum2 = 0;

                BigInteger sum = array[i] - array[j];

                sum1 += array[i];

                if (sum > 0)
                {
                    group++;
                    currentValue += sum1;
                    counter++;

                    if (i == 1 && j == 0)
                    {
                        currentValue += array[j];
                    }

                    if (group >= groupMax)
                    {
                        groupMax = group;
                        maxValue = currentValue;
                    }

                    else if ((group >= groupMax) && (sum <= 0) && (currentValue > 0))

                    {
                        currentValue += array[i];

                        if (currentValue > maxValue)
                        {
                            maxValue = currentValue;
                        }

                        group = 0;
                        currentValue = 0;

                    }

                    else if (sum < 0)
                    {
                        if ((groupMax == 0) && (counter == 0) && (i == 1 && j == 0))
                        {

                            currentValue += array[j];
                            sum1 = 0;
                            sum2 = 0;

                            if (currentValue > maxValue)
                            {
                                maxValue = currentValue;
                            }

                            currentValue = 0;
                            group = 0;
                        }
                        else
                        {
                            currentValue = 0;
                            group = 0;
                        }
                    }
                }


                Console.WriteLine(maxValue);
            }

        }
    }
}


