using System;


namespace PrintTheASCIITable
{
    class Program
    {
        static void Main()
        {

            for (int i = 33; i < 50; i++)
            {
                char c = (char)i;
                Console.Write(c);
            }
            
            char a = '<';
            int b = (int)a;
            Console.WriteLine(b);
        }
    }
}

