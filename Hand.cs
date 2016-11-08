using System;

namespace Blackjack2
{
    public class Hand
    {
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
            get { throw new NotImplementedException(); }
        }

        public void AddToHand(Card card)
        {
            throw new NotImplementedException();
        }
    }
}
