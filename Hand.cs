using System;
using System.Collections.Generic;

namespace Blackjack2
{
    public class Hand
    {
        private int total;
        private List<Card> cards;

        public Hand()
        {
            cards = new List<Card>();
        }

        public bool HasTwentyOne
        {
            get { return Value == 21; }
        }

        public bool IsBust
        {
            get { return Value > 21; }
        }

        public bool IsTotalLessThan17
        {
            get { return Value < 17; }
        }

        public int Value
        {
            get { return total; }
        }

        public void AddToHand(Card card)
        {
            total += card.Value;
            cards.Add(card);
        }

        public override string ToString()
        {
            string s = "";
            foreach(Card c in cards)
            {
                s += $"  {c}{Environment.NewLine}";
            }
            return s;
        }
    }
}
