using System;

namespace Exam_preparation
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            double S = double.Parse(Console.ReadLine());

            double amount = (((N * P) / 500D) * S);

            Console.WriteLine("{0:F2}",amount);
            
        }
    }
}
