using System;

namespace _9.Int_Double_String
{
    class Program
    {
        static void Main()
        {
            string typeOfInput = Console.ReadLine();
            
            string variable = Console.ReadLine();


            int integerNumber;
            double doubleNumber;
            string stringWord;

            switch (typeOfInput)
            {
                case "integer": integerNumber = (int.Parse(variable)) + 1; Console.WriteLine(integerNumber); break;
                case "real": doubleNumber = double.Parse(variable) + 1; Console.WriteLine("{0:F2}",doubleNumber);  break; 
                case "text": stringWord = variable + "*"; Console.WriteLine(stringWord); break;
            }
        }
    }
}
