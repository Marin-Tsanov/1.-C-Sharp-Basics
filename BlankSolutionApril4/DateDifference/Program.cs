using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2016, 8, 4);
            DateTime d2 = DateTime.Now.AddYears(10);
            TimeSpan t = d1 - d2 ;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
        }
    }
}
