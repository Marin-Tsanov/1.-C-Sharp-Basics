using System;

namespace _7.Sort3Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int first;
            int second;
            int third;

            if (a > b)
            {
                if (c > a)
                {
                    first =  c;
                    second = a;
                    third =  b;
                }
                else if ((a > c) && (c > b))
                {
                    first =  a;
                    second = c;
                    third =  b;
                }
                else
                {
                    first =  a;
                    second = b;
                    third =  c;
                }
            }
            else
            {
                if (c > b)
                {
                    first =  c;
                    second = b;
                    third =  a;
                }
                else if ((b > c) && (c > a))
                {
                    first =  b;
                    second = c;
                    third =  a;
                }
                else
                {
                    first =  b;
                    second = a;
                    third =  c;
                }
            }

            Console.WriteLine("{0} {1} {2}",first,second,third);
        }

    }
}

