namespace Blackjack2
{
    public abstract class Card
    {
        private Suit suit;

        public Card(Suit suit)
        {
            this.suit = suit;
        }

        public Suit Suit
        {
            get { return suit; }
        }

        public abstract int Value { get; }
    }
}
