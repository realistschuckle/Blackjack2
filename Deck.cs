using System.Collections.Generic;

namespace Blackjack2
{
    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();

            Suit[] suits = new Suit[] { Suit.Hearts, Suit.Spades, Suit.Diamonds, Suit.Clubs };
            for (int i = 0; i < suits.Length; i += 1)
            {
                for (int rank = 2; rank < 11; rank += 1)
                {
                    Card newCard = new Card(suits[i], rank);
                    cards.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            
        }
    }
}
