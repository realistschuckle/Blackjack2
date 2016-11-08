using System;

namespace Blackjack2
{
    public class FaceCard : Card
    {
        private string name;

        public FaceCard(Suit suit, string name)
            : base(suit)
        {
            this.name = name;
        }

        public override int Value
        {
            get { return 10; }
        }

        public override string ToString()
        {
            return $"{name} of {Suit}";
        }
    }
}
