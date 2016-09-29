using System;

namespace _14.Hex to Decimal
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

                if (array[i] == '1')
                { intarray[i] = 1; }

                if (array[i] == '2')
                { intarray[i] = 2; }

                if (array[i] == '3')
                { intarray[i] = 3; }

                if (array[i] == '4')
                { intarray[i] = 4; }

                if (array[i] == '5')
                { intarray[i] = 5; }

                if (array[i] == '6')
                { intarray[i] = 6; }

                if (array[i] == '7')
                { intarray[i] = 7; }

                if (array[i] == '8')
                { intarray[i] = 8; }

                if (array[i] == '9')
                { intarray[i] = 9; }

                if (array[i] == 'A')
                { intarray[i] = 10; }

                if (array[i] == 'B')
                { intarray[i] = 11; }

                if (array[i] == 'C')
                { intarray[i] = 12; }

                if (array[i] == 'D')
                { intarray[i] = 13; }

                if (array[i] == 'E')
                { intarray[i] = 14; }

                if (array[i] == 'F')
                { intarray[i] = 15; }
            }
            double sum=0;
            for (int i = 0; i < length; i++)
            {

                sum += (intarray[i] * Math.Pow(16,length-i-1));
                
            }
            Console.WriteLine(sum);
        }
    }
}
