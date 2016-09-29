using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a+" " + b);
            Console.WriteLine("After the exchange:");
            int c = b - a;
            a = a + c;
            b = b - c;
            Console.WriteLine(a+" "+b);

            

        }
    }
}
