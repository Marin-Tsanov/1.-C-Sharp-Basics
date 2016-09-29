using System;

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            int dayOfWeeek = int.Parse(Console.ReadLine());
            string nameOfDay = "";

            switch (dayOfWeeek)
            {
                case 1: nameOfDay = "Monday"; break;
                case 2: nameOfDay = "Tuesday";break;
                case 3: nameOfDay = "Wednesday"; break;
                case 4: nameOfDay = "Thursday"; break;
                case 5: nameOfDay = "Friday"; break;
                case 6: nameOfDay = "Saturday"; break;
                case 7: nameOfDay = "Sunday"; break;
                default:
                    break;
            }

            string text = "one";
            switch(text)
            {
                case "one": break;
                case "two": break;
                default:
                    break;

            }

            Console.WriteLine(nameOfDay);
        }
    }
}
