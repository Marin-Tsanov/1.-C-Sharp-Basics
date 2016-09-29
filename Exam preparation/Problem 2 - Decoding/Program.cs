using System;

namespace Problem_2___Decoding
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            double result;

            char[] array = text.ToCharArray();


            for (int i = 0; i < text.Length; i++)
            {
                if (array[i] == '@')
                {
                    break;
                }

                if ((array[i] >= 'a' && array[i] <= 'z') ||
                    (array[i] >= 'A' && array[i] <= 'Z'))
                {
                    result = (array[i]*number) + 1000;
                }

                else if (array[i] >= '0' && array[i] <= '9' )
                {
                    result = array[i] + number + 500 ; 
                }

                else
                {
                    result = array[i] - number;
                }

                if (i % 2 ==0)
                {
                    result = result / 100.0;
                    Console.WriteLine("{0:F2}",result);
                }
                else
                {
                    result = result * 100.0;
                    Console.WriteLine(result);
                }
            }

        }
    }
}
