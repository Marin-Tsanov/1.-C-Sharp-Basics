using System;


namespace _11._3rdBit
{
    class Program
    {
        static void Main()
        {
            int p = 3;
            int n = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = (n & mask);
            int bit = nAndMask >> p;
            Console.WriteLine(bit);
        }
    }
}
