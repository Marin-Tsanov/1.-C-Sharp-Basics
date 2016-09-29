using System;

namespace _14.hex_to_Decimal_2nd_solution
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            int length = hex.Length;

            char[] array = hex.ToCharArray();

            int[] intarray = new int[length];

            for (int i = 0; i < length; i++)
            {

                switch (array[i])
                {
                    case '0': intarray[i] = 0; break;
                    case '1': intarray[i] = 1; break;
                    case '2': intarray[i] = 2; break;
                    case '3': intarray[i] = 3; break;
                    case '4': intarray[i] = 4; break;
                    case '5': intarray[i] = 5; break;
                    case '6': intarray[i] = 6; break;
                    case '7': intarray[i] = 7; break;
                    case '8': intarray[i] = 8; break;
                    case '9': intarray[i] = 9; break;
                    case 'A': intarray[i] = 10; break;
                    case 'B': intarray[i] = 11; break;
                    case 'C': intarray[i] = 12; break;
                    case 'D': intarray[i] = 13; break;
                    case 'E': intarray[i] = 14; break;
                    case 'F': intarray[i] = 15; break;
                }
            }
                double sum = 0;
                for (int j = 0; j < length; j++)
                {

                    sum += (intarray[j] * Math.Pow(16, length - j - 1));

                }
                Console.WriteLine(sum);
            }
        }
    }
