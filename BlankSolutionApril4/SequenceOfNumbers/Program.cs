using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        IEnumerable<int> Series(int k = 0, int n = 1, int c = 1)
{
            while (true)
            {
                yield return k;
                k = (c * k) + n;
            }
        }

    }
    }

