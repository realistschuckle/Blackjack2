using System;

namespace Blackjack2
{
    public class Hand
    {
        private int total;

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
        }
    }
}
