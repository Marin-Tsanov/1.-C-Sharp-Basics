using System;

namespace Problem_5_Bits_to_Bits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxZerocount = 0;
            int currZerocount = 0;

            int maxOnecount = 0;
            int currOnecount = 0;

            int lastBit = 5555;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                for (int j = 29; j >= 0; j--)
                {
                  int bit = ((1 << j) & num) >> j;
                    Console.Write(bit);
                }
                if (bit == 1)
                {
                    if (lastBit == 1)
                    {
                        currOnecount++;
                    }


                    else
                    {
                        maxZerocount = Math.Max(maxZerocount, currZerocount);
                        currZerocount = 0;
                        currOnecount = 1;

                    }
                }
                else // bit == 0
                {
                    if (lastBit == 0)
                    {
                        currZerocount++;
                    }


                    else
                    {
                        maxOnecount = Math.Max(maxOnecount, currOnecount);
                        currOnecount = 0;
                        currZerocount = 1;

                    }
                }

                lastBit = bit;

            }
            Console.WriteLine();
        }
        }
    }
}
