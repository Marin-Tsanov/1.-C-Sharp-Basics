using System;


namespace _14.BitExchange
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            

            uint p3 = 1 << 3;
            uint mask3 = (uint)number & p3;
            uint mask3result = mask3 >> 3;

            uint p4 = 1 << 4;
            uint mask4 = (uint)number & p4;
            uint mask4result = mask4 >> 4;
            

            uint p5 = 1 << 5;
            uint mask5 = (uint)number & p5;
            uint mask5result = mask5 >> 5;
            

            uint p24 = 1 << 24;
            uint mask24 = (uint)number & p24;
            uint mask24result = mask24 >> 24;
            

            uint p25 = 1 << 25;
            uint mask25 = (uint)number & p25;
            uint mask25result = mask25 >> 25;
            
            if (mask3result != mask24result)
            {

            }
            

        }
    }
}
