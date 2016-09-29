using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                char triangle = '©';
                Console.WriteLine("{0,4}", triangle);
                Console.WriteLine();
                Console.WriteLine("{0,3}{0,2}", triangle);
                Console.WriteLine();
                Console.WriteLine("{0,2}{0,4}", triangle);
                Console.WriteLine();
                Console.WriteLine("{0,1}{0,2}{0,2}{0,2}", triangle);

            }
        }
    }
}