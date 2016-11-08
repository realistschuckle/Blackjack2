namespace Blackjack2
{
    public class AceCard : Card
    {
        public AceCard(Suit suit)
            : base(suit)
        {
        }

        public override int Value
        {
            get { return 11; }
        }

        public override string ToString()
        {
            return $"Ace of {Suit}";
        }
    }
}
