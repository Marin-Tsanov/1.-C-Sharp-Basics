
using System;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            long number=long.Parse(Console.ReadLine());
            int p = 7;

            int mask1 = (p<<3);
            long getNumbers1 = (number&mask1);
            
            int mask2 = (p << 24) ;
            long getNumbers2 = (number&mask2);

            int maskcombination = ~(mask1 ^ mask2);
            long newnumber = number & maskcombination;
            long mask3 = (getNumbers1 >> 3) << 24;
            long mask4 = (getNumbers2 >> 24) << 3;
            long numberbit = (newnumber | mask3) | mask4;
            
            Console.WriteLine(numberbit);
        }
    }
}
