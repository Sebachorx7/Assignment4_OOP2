using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{/// <summary>
    /// Name: Sebastian Romero Gonzalez - 100886859
    /// Last Updated: November, 16 2023.
    /// Inheritance from deck.cs
    /// </summary>
    internal class StandardDeck : Deck
    {
        // Set the standard deck with the default values, suits and ranks.
        public StandardDeck() 
        {
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    AddCard(new Card(suit, rank));
                }
            }
        }
    }
}
