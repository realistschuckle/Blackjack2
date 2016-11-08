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

            // Check if the player wants or can keep going
            bool playerWantsAnotherCard = KeepGoing(player);

            // while the player doesn't hold
            while (playerWantsAnotherCard)
            {
                // deal the player a card
                player.AddToHand(deck.TakeACard());

                // Check if the player wants or can keep going
                playerWantsAnotherCard = KeepGoing(player);
            }

            // while the house's hand is less than 17
            while (house.IsTotalLessThan17)
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
        }

        private static bool KeepGoing(Hand player)
        {
            // Check the status of the hand
            if (player.HasTwentyOne || player.IsBust)
            {
                return false;
            }

            // Prompt for additional card
            Console.WriteLine("Would you like another card? (yes or no)");
            string humanInput = Console.ReadLine();
            bool playerWantsAnotherCard = humanInput.ToLower() == "yes";
            return playerWantsAnotherCard;
        }
    }
}
