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
    /// Inheritance from deck.cs
    /// </summary>
    internal class CustomDeck : Deck
    {
        public List<Card> customCards;
        public CustomDeck()
        {
            //customCards = new List<Card>();
        }
        /// <summary>
        /// I  tried to add a new card using this method.
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        public void AddCustomCard(string suit, string rank)
        {
            //string suit = TextBoxSuit.Text;
            //string rank = TextBoxRank.Text;
            Card customCard = new Card(suit, rank);
            //base.AddCard(customCard);
            //AddCard(customCard);
            //customCards.Add(customCard);
            //deckInPlay.Add(customCard);
            //AddCard(customCard);
        }
    }
}
