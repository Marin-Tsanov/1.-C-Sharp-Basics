using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());            //string combo = firstName + " " + lastName;
            long personalIDNumber = long.Parse(Console.ReadLine());
            int uniqueEmployeeNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("First name : {0}",firstName);
            Console.WriteLine("Last name : {0}",lastName);
            Console.WriteLine("Age : {0}",age);
            Console.WriteLine("Personal ID number: {0}",personalIDNumber);
            Console.WriteLine("Unique employee number :{0}",uniqueEmployeeNumber);


            
                
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ResetColor();

            string a = "5";
            int b;
            int.TryParse(a, out b);

            Console.WriteLine(a);
            Console.WriteLine(b);



                //Console.WriteLine("{0} \n {1} \n {2}", firstName, lastName, combo);
         }
    }
}
