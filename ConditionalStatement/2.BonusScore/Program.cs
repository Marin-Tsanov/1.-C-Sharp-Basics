using System;

namespace _2.BonusScore
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string result;

            switch (number)
            {
                case 1:
                case 2:
                case 3: number *= 10; Console.WriteLine(number); break;

                case 4:
                case 5:
                case 6: number = number * 100; Console.WriteLine(number); break;

                case 7:
                case 8:
                case 9: number = number * 1000; Console.WriteLine(number); break;


                default:
                    Console.WriteLine("invalid score");
                    break;
            }
        }
    }
}
