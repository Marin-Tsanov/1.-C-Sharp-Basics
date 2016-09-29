using System;

namespace _2.MoonGravity
{
    class Program
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());

            float moonWeight = W * 0.17f;
            string s = string.Format("{0:F3}", moonWeight);
            Console.WriteLine(s);
        }
    }
}
