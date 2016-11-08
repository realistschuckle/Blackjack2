namespace Blackjack2
{
    public class NumberCard : Card
    {
        private int number;

        public NumberCard(Suit suit, int number)
            : base(suit)
        {
            this.number = number;
        }

        public override int Value
        {
            get { return number; }
        }

        public override string ToString()
        {
            return number + " of " + Suit;
        }
    }
}
