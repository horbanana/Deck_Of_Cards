using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Player
    {
        string name;
        public List<Card> hand;
        public Player(string person)
        {
            name = person;
            hand = new List<Card>();
        }

        Random rand = new Random();
        public void Draw(Deck cards) {
            hand.Add(cards.Deal());
        }
    }
}