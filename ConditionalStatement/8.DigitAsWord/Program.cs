﻿using System;

namespace _3.PlayCard_
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();

            string name;
            switch (number)
            {
                case "0": name = "zero"; break;
                case "1": name = "one"; break;
                case "2": name = "two"; break;
                case "3": name = "three"; break;
                case "4": name = "four"; break;
                case "5": name = "five"; break;
                case "6": name = "six"; break;
                case "7": name = "seven"; break;
                case "8": name = "eight"; break;
                case "9": name = "nine"; break;
                default:
                    name = "not a digit";
                    break;
            }
            Console.WriteLine(name);
        }

    }
}
