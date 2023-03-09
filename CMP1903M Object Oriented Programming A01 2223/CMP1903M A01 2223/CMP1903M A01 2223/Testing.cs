using CMP1903M_A01_2223;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Declaring Testing class
class Testing
{
    // Initializing pack
    public static Pack pack = new Pack();

    // Method to bring cards to this class
    public void bringing_cards_to_this_class()
    {
        // Get cards list from Pack class
        List<Card> cards = Pack.cards;

    }

    // Method to run the main menu
    public static void RunMenu()
    {
        // Boolean variable to control the loop
        bool loop = true;

        // Loop through menu options until user chooses to end the program
        while (loop)
        {
            // Display menu options to user
            Console.WriteLine("\nWelcome to the card shuffler.\nPlease enter a number:\n1: Deal a card\n2: Deal multiple cards\n3: No shuffle\n4: Riffle Shuffle\n5: Fisher-Yates Shuffle\n6: End program\n");

            // Get user selection from input
            string userSelection = Console.ReadLine();

            // Switch statement to perform action based on user selection
            switch (userSelection)
            {
                // Case 1: Deal a card
                case "1":
                    try
                    {
                        // Deal a card and print it to console
                        Card card1 = pack.deal();
                        Console.WriteLine(card1.Value + " Of " + card1.Suit);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                // Case 2: Deal multiple cards
                case "2":
                    Console.WriteLine("Number of cards:");

                    // Get amount of cards to deal from user input
                    if (!int.TryParse(Console.ReadLine(), out int amount) || amount <= 0 || amount > 52)
                    {
                        Console.WriteLine("Error: Please enter a valid number between 1 and 52.");
                        break;
                    }

                    try
                    {
                        // Deal multiple cards and print them to console
                        string[] dealtCards = pack.dealCard(amount);
                        foreach (string card in dealtCards)
                        {
                            Console.WriteLine(card);
                        }
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                // Case 3: No shuffle
                case "3":
                    // Do nothing
                    break;

                // Case 4: Riffle Shuffle
                case "4":
                    try
                    {
                        // Shuffle cards using riffle shuffle and print message to console
                        pack.riffleShuffle();
                        Console.WriteLine("Cards shuffled using riffle shuffle.");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                // Case 5: Fisher-Yates Shuffle
                case "5":
                    try
                    {
                        // Shuffle cards using Fisher-Yates shuffle and print message to console
                        pack.fisherYatesShuffle();
                        Console.WriteLine("Cards shuffled using Fisher-Yates shuffle.");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;

                // Case 6: End program
                case "6":
                    loop = false;
                    break;

                // Default case: Invalid selection
                default:
                    Console.WriteLine("Error: Invalid selection. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }

}
