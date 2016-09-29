using System;

namespace Problem_2_Text_to_Number
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            
            double result = 0;

            char [] array = text.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '@')
                {
                    break;
                }

                else if (('a' <= array[i] && array[i] <= 'z')

                      || ('A' <= array[i] && array[i] <= 'Z'))
                {
                    result += array[i] * number + 1000;
                }
                else if ('0' <= array[i] && array[i] <= '9')
                {
                    result *= array[i] + number + 500;
                }
                else
                {
                    result += array[i] - number;
                }

                if (i % 2 == 0)
                {
                    result = (result / 100);
                    result = Math.Round(result, 2);
                }
                else
                {
                    result = result * 100;
                }
            }
                Console.WriteLine(result);
            }
        }
    }

