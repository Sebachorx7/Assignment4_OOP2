using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Assignment4
{
    /// <summary>
    /// Name: Sebastian Romero Gonzalez - 100886859
    /// Last Updated: November, 16 2023.
    /// </summary>
    internal class Deck
    {
        //Constructor: initializes the cards lists by creating a new instance.
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
        }
        /// <summary>
        /// Method: Set the standard deck with the default values, suits and ranks.
        /// </summary>
        /// <returns></returns>
        protected internal List<Card> BuildDeck()
        {
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] values = { "Ace","2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            //New object of cards list... crea la lista como ojeto
            List<Card> deck = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    deck.Add(new Card(suit, value));
                }
            }

            return deck;
        }
        /// <summary>
        /// MEthod: Shuffle the deck, inserts in the list, and displays it.
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public List<Card> Shuffle(List<Card> deck)
        {
            int cardCounter = 0;
            Random random = new Random();
            List<Card> shuffledDeck = new List<Card>();
            // iterate over each card, select a random position to each card.
            foreach (Card drawnCard in deck)
            {
                int shuffleIndex = random.Next(shuffledDeck.Count);
                shuffledDeck.Insert(shuffleIndex, deck[cardCounter]);
                cardCounter++;
            }
            return shuffledDeck;
        }
        /// <summary>
        /// Adds a new card to the deck.
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        
    }
}
