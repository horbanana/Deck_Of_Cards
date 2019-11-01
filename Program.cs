using System;
using System.Collections.Generic;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck cards = new Deck();
            // cards.shuffle();
            foreach(var card in cards.cards)
            {
                Console.WriteLine(card.show());
            }
            Player bill = new Player("Ricki");
            Console.WriteLine(cards.Deal().show());

            

        }
    }
}
