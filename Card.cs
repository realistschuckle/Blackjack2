namespace Blackjack2
{
    public class Card
    {
        private int rank;
        private Suit suit;

        public Card(Suit suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public int Value
        {
            get { return rank; }
        }
    }
}
