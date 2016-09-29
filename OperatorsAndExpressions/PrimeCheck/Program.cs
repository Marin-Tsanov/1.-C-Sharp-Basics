using System;

class Program
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = 1.5;

        if (((x >= -0.5) & (x <= 2.5)) & ((y >= -0.5) & (y <= 2.5)))
        {
            double f = Math.Pow((1 - x), 2) + Math.Pow(y, 2);
            double fz = Math.Pow(z, 2);
            if (f <= fz)
            {
                string b = "inside circle";
                Console.Write(b+" ");
            }
            else
            {
                string b = "outside circle";
                Console.Write(b+" ");
            }
        }
        if (((x >= -1) & (x <= 5)) & ((y >= -1) & (y <= 1)))
        {
            string a = "inside rectangle";
            Console.Write(a);            
        }
        else
        {
            string a = "outside rectangle";
            Console.Write(a);
        }
    }
}




