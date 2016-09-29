using System;


namespace TypeCasting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            string hello = "Hello";
            string world = "World";

            object helloWorld = hello + " " + world;

            string helloWorld2 = (string)helloWorld;
            Console.WriteLine(helloWorld2);
        }
    }
}
