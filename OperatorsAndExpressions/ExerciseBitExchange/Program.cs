using System;

namespace ExerciseBitExchange
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int probeFirst = 7<<3;
            int probeSecond = 7 << 24;

            int maskFisrt = (number & probeFirst);
             


        }
    }
}
