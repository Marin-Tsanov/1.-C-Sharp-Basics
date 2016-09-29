using System;

class IsThirdDigit7
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a > 999)
        {
            int fourth = a % 10;          
            int third = (a / 10) % 10;     
            int second = (a / 100) % 10;  
            int first = (a / 1000) % 10; 
            Console.WriteLine(first + second + third + fourth);
            Console.WriteLine("{0}{1}{2}{3}", fourth, third, second,first);
            Console.WriteLine("{0}{1}{2}{3}", fourth,first,second,third);
            Console.WriteLine("{0}{1}{2}{3}",first,third,second,fourth);
        }
    }
}