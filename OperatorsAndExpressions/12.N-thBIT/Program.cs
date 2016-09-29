using System;


namespace _12.N_thBIT
{
    class Program
    {
        static void Main()
        {
            long p = long.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
           
                int mask = 1 << n;
                long nAndMask = p & mask;
                long bit = nAndMask >> n;
                Console.WriteLine(bit);
            }
        }
    }

