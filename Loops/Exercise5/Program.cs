using System;

namespace Exercise5
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());


            int[] array = new int[size+1];
            array[0] = size;

           
            for ( int i=1;i<= size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
