using System;

namespace PrintASCIITable3
{
    class Program
    {
        static void Main()
        {
            int min = 33;
            int max = 127;

            for (int i = min; i < max; i++)
            {
                char c = (char)i;
                Console.Write(c);
            }
            Console.WriteLine();
        }





    }
}
