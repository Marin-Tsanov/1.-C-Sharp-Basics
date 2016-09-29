using System;

namespace Exam
{
    class Program
    {
        static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Ivanov";
            Console.WriteLine("Hello, {0}.\n",firstName);
            Console.WriteLine("Your full name is {0} {1}",firstName,lastName);
            string fullName = "Your full name is " + firstName + " " + lastName;
            Console.WriteLine(fullName);

            int a = 25;
            int b = 14;

            int area = a * b;
            int perimeter = 2 * (a + b);
            int x = 5;
            x = x + 5;

            Console.WriteLine();
            Console.WriteLine(x);
           
            double m = 1e9;
            Console.WriteLine(m);

            float realNumber = 12.5f;
            float realNumbers = 1.25e1f;
            Console.WriteLine(realNumber==realNumbers);



            int? n = null;
            double? d = null;
            Console.WriteLine("This is the integer with Null value ->" + n);
            n = 5;
            Console.WriteLine("This is the integer with value 5 ->" + n);
            Console.WriteLine(d);

            Console.WriteLine();
            dynamic g = 5;
            dynamic h = 3;
            Console.WriteLine(g+h);

             g = "5";
             h = 3;
            Console.WriteLine(g+h);

            Console.WriteLine();
            a = 1;
            b = 2;
            bool greater=(a > b);
            bool equal = (a == 1);
            Console.WriteLine(greater);
            Console.WriteLine(equal);

            if (greater)
            {
                Console.WriteLine("A>B");
            }   
            else
            {
                Console.WriteLine("A<B");
            }

            Console.WriteLine();
            int i = 0x243;
            Console.WriteLine(i);

            Console.WriteLine();
            double l = 1e2;
            string k = "\u0061";
            Console.WriteLine(l+k);

            Console.WriteLine();
            double r = 0xFF;
            double e = 1e2;
            Console.WriteLine(r);
            Console.WriteLine(e);

            int? y = null;
            double? w = null;
            char? q = null;
            string gd= null;

            Console.WriteLine();
            dynamic type = 5;
            Console.WriteLine(type);
            type = 'c';
            Console.WriteLine(type);
            type = "Hello";
            Console.WriteLine(type);

            Console.WriteLine();
            char cha = '\u002A';
            Console.WriteLine(cha);

            Console.WriteLine();

            int Female = 1 ;
            int Male   = 2 ;

            int first = int.Parse(Console.ReadLine());

            bool isFemale = (first == Female);
            Console.WriteLine(isFemale);

            if (isFemale)
            {
                Console.WriteLine("Your gender is Female");
            }
            
            else
            {
                Console.WriteLine("Your gender is Male");
            }

            


        }
    }
}
