using System;
using System.Collections.Generic;
using System.Linq;

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

        public Card TakeACard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            cards = cards.OrderBy(card => rand.Next(100)).ToList();
        }

        public void LikeTheRealWorldShuffle()
        {
            for (int i = 0; i < 7; i += 1)
            {
                List<Card> left = new List<Card>();
                List<Card> right = new List<Card>();

                // removing from main deck and put it
                // in left and right stacks
                while (cards.Count > 0)
                {
                    Card card = cards[0];
                    cards.RemoveAt(0);
                    left.Add(card);

                    card = cards[0];
                    cards.RemoveAt(0);
                    right.Add(card);
                }
                
                Random rand = new Random();
                while (left.Count > 0 || right.Count > 0)
                {
                    int leftOrRight = rand.Next(2);
                    // if leftOrRight == 0, pull from the left stack
                    // if leftOrRight == 1 (otherwise), pull from the right stack
                    if (leftOrRight == 0)
                    {
                        if (left.Count > 0)
                        {
                            Card card = left[0];
                            left.RemoveAt(0);
                            cards.Add(card);
                        }
                        else
                        {
                            Card card = right[0];
                            right.RemoveAt(0);
                            cards.Add(card);
                        }
                    }
                    else
                    {
                        if (right.Count > 0)
                        {
                            Card card = right[0];
                            right.RemoveAt(0);
                            cards.Add(card);
                        }
                        else
                        {
                            Card card = left[0];
                            left.RemoveAt(0);
                            cards.Add(card);
                        }
                    }
                }
            }
        }
    }
}
