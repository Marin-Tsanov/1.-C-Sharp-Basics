using System;

namespace SymbolToNumber
{
    class Program
    {
        static void Main()
        {
            // char by char
            // if char is @ return
            // if char is letter => ascii *secret +1000
            // if char is digit => ascii (digit) + secret + 500
            // else ==> ascii(char) - secret

            // if cchar is on even position => result /100

            // if char is on odd position => result * 100

            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < text.length; i++)
            {

            }

             
        }
    }
}
