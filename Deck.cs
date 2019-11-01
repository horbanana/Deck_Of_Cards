using System;
using System.Collections.Generic;

namespace deckOfCards
{
    public class Deck
    {
        public  List<Card> cards{get;set;}

        public Deck()
        {
            cards = new List<Card>();
            
            string[] suits = {"Hearts", "Diamonds", "Spades", "Clubs"};
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            foreach(string suit in suits)
            {
                for(int i = 0; i < stringVal.Length; i++)
                {
                    Card play = new Card(stringVal[i], suit);
                    cards.Add(play);
                }
            }

            
        }
        public Card Deal() 
                {
                    Card topCard = cards[0];
                    cards.Remove(topCard);
                    return topCard;
                }
        public void shuffle()
     {
        Random r = new Random();
        for (int i = 0; i < cards.Count; i++)
        {
            var temp = cards[i];
            int rI = r.Next(cards.Count);
            cards[i] = cards[rI];
            cards[rI] = temp;
        }
     }
     }
}



