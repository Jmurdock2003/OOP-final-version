using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    // Define a public class Card
    public class Card
    {
        // Define two properties called 'Suit' and 'Value' for the class
        public string Suit { get; }
        public string Value { get; }

        // Create a constructor for the 'Card' class that takes in two arguments: 'suit' and 'value'
        public Card(string suit, string value)
        {
            // Assign the 'suit' argument to the 'Suit' property of the class
            Suit = suit;
            // Assign the 'value' argument to the 'Value' property of the class
            Value = value;
        }
    }
}
