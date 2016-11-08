using System;

namespace Blackjack2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a player
            Hand player = new Hand();

            // Create the house
            Hand house = new Hand();

            // Create a deck of cards
            Deck deck = new Deck();

            // Shuffle the deck
            deck.Shuffle();

            // "Deal the cards"
            Card card = deck.TakeACard();
            player.AddToHand(card);

            card = deck.TakeACard();
            house.AddToHand(card);

            player.AddToHand(deck.TakeACard());
            house.AddToHand(deck.TakeACard());

            // while the can and wants to keep getting another card
            while (KeepGoing(player, house))
            {
                // deal the player a card
                player.AddToHand(deck.TakeACard());
            }

            // while the player hasn't busted and
            // the house's hand is less than 17
            while (!player.IsBust && house.IsTotalLessThan17)
            {
                // deal the house a card
                house.AddToHand(deck.TakeACard());
            }

            // if the house is bust, the human wins
            // the winner is the hand with the highest total
            // if a tie, assume the player is a loser
            if (house.IsBust)
            {
                Console.WriteLine("HUMANS WIN!");
            }
            else if (player.IsBust)
            {
                Console.WriteLine("HUMANITY GOES BUST!");
            }
            else if (house.Value == player.Value)
            {
                Console.WriteLine("NO ONE WINS! WHICH PROBABLY MEANS YOU'RE A LOSER.");
            }
            else if (house.Value > player.Value)
            {
                Console.WriteLine("YOU'RE DEFINITELY A LOSIER.");
            }
            else
            {
                Console.WriteLine("YOU WON!");
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        private static bool KeepGoing(Hand player, Hand house)
        {
            // Check the status of the hand
            if (player.HasTwentyOne || player.IsBust)
            {
                return false;
            }

            // Prompt for additional card
            Console.Clear();
            Console.WriteLine("The house has " + house.Value);
            Console.WriteLine("You have " + player.Value);
            Console.WriteLine("Would you like another card? (yes or no)");
            string humanInput = Console.ReadLine();
            bool playerWantsAnotherCard = humanInput.ToLower() == "yes";
            return playerWantsAnotherCard;
        }
    }
}
