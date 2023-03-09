using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // Define the Pack class
    class Pack
    {
        // Define a static list to store the cards
        public static List<Card> cards = new List<Card>();

        // Define the constructor for the Pack class
        public Pack()
        {
            // Define the suits and values of the cards
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Loop through the suits and values to create the cards and add them to the pack
            foreach (string suit in suits)
            {
                foreach (string value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        // Define the deal method to remove and return the top card from the pack
        public Card deal()
        {
            Card topCard = cards[0];
            cards.RemoveAt(0);
            return topCard;
        }

        // Define the dealCard method to return an array of cards of the specified amount
        public string[] dealCard(int amount)
        {
            // Create an array to store the cards
            string[] card_list = new string[amount];

            // Loop through the specified amount of cards and add them to the array
            for (int i = 0; i < amount; i++)
            {
                Card card = deal();
                card_list[i] = card.Value + " Of " + card.Suit;
            }

            // Return the array of cards
            return card_list;
        }

        // Define the riffleShuffle method to shuffle the pack using a riffle shuffle technique
        public void riffleShuffle()
        {
            // Divide the pack into two decks
            int half = cards.Count / 2;
            List<Card> leftDeck = cards.GetRange(0, half);
            List<Card> rightDeck = cards.GetRange(half, half);

            // Clear the current pack and create a new random object
            cards.Clear();
            Random rand = new Random();

            // Loop through the left and right decks until they are both empty
            while (leftDeck.Count > 0 || rightDeck.Count > 0)
            {
                // If there are cards in the left deck, randomly select and add one to the new pack
                if (leftDeck.Count > 0)
                {
                    int cardIndex = rand.Next(0, leftDeck.Count);
                    cards.Add(leftDeck[cardIndex]);
                    leftDeck.RemoveAt(cardIndex);
                }

                // If there are cards in the right deck, randomly select and add one to the new pack
                if (rightDeck.Count > 0)
                {
                    int cardIndex = rand.Next(0, rightDeck.Count);
                    cards.Add(rightDeck[cardIndex]);
                    rightDeck.RemoveAt(cardIndex);
                }
            }
        }

        // Define the fisherYatesShuffle method to shuffle the pack using the Fisher-Yates shuffle technique
        public void fisherYatesShuffle()
        {
            // Create a new random object and get the number of cards in the pack
            Random rand = new Random();
            int n = cards.Count;

            // Loop through the cards in the pack in reverse order
            for (int i = n - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }


    }
}


