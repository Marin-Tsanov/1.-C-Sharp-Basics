using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(a+null);
            Console.WriteLine(a+5);
            int? value = 0;

            if (value == 0)
            {
                value = null;
            }

            Console.WriteLine(value);

            
        }
    }
}
