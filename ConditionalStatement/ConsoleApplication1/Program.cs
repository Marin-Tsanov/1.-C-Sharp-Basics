using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sample = 7;

            int mask1 = sample << 3;
            int mask2 = sample << 24;

            int getNumbers1 = number & mask1;
            int getNumbers2 = number & mask2;

            int numberzeobits = (number & ~mask1) & mask2;

            int mask3 = (getNumbers1 >> 3) << 24;
            int mask4 = (getNumbers2 >> 24)<<3;
            int numberchanged = (numberzeobits | mask3)|mask4;

            Console.WriteLine(numberchanged);
        }
    }
}
