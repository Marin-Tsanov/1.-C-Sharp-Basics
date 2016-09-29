using System;
namespace _13.ModifyBit
{
    class Program
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            byte position = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());

            if (v == 1)
                
            {
                ulong mask = (ulong)1 << position;
                ulong nAndMask = number | mask;
                Console.WriteLine(nAndMask);
            }
            else if (v == 0)
            {
                ulong mask1 = (ulong)~(1 << position);
                ulong result = number & mask1;
                Console.WriteLine(result);
            }
        }
    }
}
