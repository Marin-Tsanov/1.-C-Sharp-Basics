using System;

namespace _4.Print_a_Deck
{
    class Program
    {
        static void Main()
        {
            string card = Console.ReadLine();

            string[] deck = new string[] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};

            for (int i = 0; i < deck.Length; i++)
            {
                if ( deck[i] == card)
                {
                    for (int j = 0; j <=i ; j++)
                    {
                        Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[j]);
                    }
                }

            }
        }
    }
}
