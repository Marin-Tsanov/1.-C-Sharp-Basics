using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double eps = 0.000001;

            if (a > b) 
            {
                double c = a - b;
                if ( c<eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    console.writeline("false");
                }
            }

            else
            {
                double d = b - a;
                if (d<eps)
                    Console.WriteLine("true");
                else
                {
                    Console.WriteLine("false");
                }
        
            }
        }
    }
}
