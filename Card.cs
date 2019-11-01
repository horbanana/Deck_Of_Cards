using System;

namespace deckOfCards
{
    public class Card
    {
        public string stringVal{get;set;}
        public string suit{get;set;}


        public Card (string stringVal, string suit)
        {
            this.stringVal = stringVal;
            this.suit = suit;
        }

        public string show()
        {
            return ($"the {stringVal} of {suit}");
        }

    }
}