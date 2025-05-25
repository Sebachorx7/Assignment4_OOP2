using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    /// <summary>
    /// Name: Sebastian Romero Gonzalez - 100886859
    /// Last Updated: November, 16 2023.
    /// </summary>
    internal class Card
    {
        //Parameters
        private string cardSuit;
        private string cardRank;

        //Default constructor - empty
        public Card()
        {

        }
        //parametirized constructor - pass and assign value
        public Card(string assignedSuit, string assignedValue)
        {
            cardSuit = assignedSuit;
            cardRank = assignedValue;
        }

        // getters and setters
        protected internal string Suit
        {
            get { return cardSuit; }
            set { cardSuit = value; }
        }
        protected internal string Value
        {
            get { return cardRank; }
            set { cardRank = value; }
        }
        /// <summary>
        /// over write the ToString method to display the selected text.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cardString;
            cardString = Value + " of " + Suit;
            return cardString;
        }
    }
}
