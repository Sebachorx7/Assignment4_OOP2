using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Sebastian Romero Gonzalez - 100886859
// Last Updated: November, 16 2023.
// Description: This is a program who is going to show you a deck of cards, you can add a custom card, deal cards and reset the form if you want to.

namespace Assignment4
{
    public partial class SebastianDeckBuilder : Form
    {
        private List<Card> deckInPlay;
        private CustomDeck customDeck;
        private Deck deck;
        // Costructor, initializes the form, create instances.
        public SebastianDeckBuilder()
        {
            InitializeComponent();
            customDeck = new CustomDeck();
            deck = new Deck();

        }
        /// <summary>
        /// Set as default all the writable fields in the form.
        /// </summary>
        private void ClearErrorBackground()
        {
            // Clear error background colors for all inputs control
            foreach (Control control in Controls)
            {
                if (control is GroupBox)
                {
                    control.BackColor = SystemColors.Window;
                }
            }
        }
        private void ClearForm()
        {
            // Clear all form controls, including those within groupboxes
            ClearControls(this);
            // Clear the file contents display
            //TextBoxDisplay.Text = "";
        }
        //es un groupbox, se utiliza todo para limpiar, y no uno por uno
        private void ClearControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.Text = "";
                    ctrl.BackColor = SystemColors.Window;
                }
                // If the control is groupbox, recursively clear it control
                if (ctrl is GroupBox)
                {
                    ClearControls(ctrl);
                }
            }
        }
        /// <summary>
        /// Exit Button: Close the program and clear the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            clearForm();
            Close();
        }
        // Create a new instance from class Deck, called newDeck.
        // Call the method BuildDeck and stores in the deck variable.
        // Link the builted deck to the deckInPlay variable.
        private void buildDeckFromScratch()
        {
            Deck newDeck = new Deck();
            List<Card> deck = newDeck.BuildDeck();
            deckInPlay = deck;
        }
        // Use a method to avoid the code repetition.
        private void SebastianDeckBuilder_Load(object sender, EventArgs e)
        {
            buildDeckFromScratch();
        }
        /// <summary>
        /// View the deck in the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonViewDeck_Click(object sender, EventArgs e)
        {
            try
            {
                // Clean the items in the list box.
                ListBoxShowDeck.Items.Clear();
                // Iterates for each card in deckInPlay and add each card to the list box.
                foreach (Card card in deckInPlay)
                {
                    ListBoxShowDeck.Items.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There are some errors in the form, please, review your request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Shuffle the deck.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            // Instance of the deck class, select the current deck, and shuffle it, the result is assigned again to deckInPlay variable.
            Deck newShuffle = new Deck();
            deckInPlay = newShuffle.Shuffle(deckInPlay);
            ListBoxShowDeck.Items.Clear();
            ButtonViewDeck.Focus();
        }
        /// <summary>
        /// Set as default the form, clean all the writable fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        /// <summary>
        /// This method update the list box, used before the add button is clicked.
        /// </summary>
        private void UpdateListBox()
        {
            foreach (Card card in deckInPlay)
            {
                // Add each card to the list box
                ListBoxShowDeck.Items.Add(card);
            }
        }
        /// <summary>
        /// Add a new card using information given from the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddCustom_Click(object sender, EventArgs e)
        {
            try
            {
                string suit = TextBoxSuit.Text;
                string rank = TextBoxRank.Text;
                // If the tect boxes have information, the code will continue.
                if (!string.IsNullOrWhiteSpace(suit) && !string.IsNullOrWhiteSpace(rank))
                {
                    // Clean the list box.
                    ListBoxShowDeck.Items.Clear();
                    // Create a new instance from Card, add the new card taken from the text boxes.
                    Card customCard = new Card(suit, rank);
                    deckInPlay.Add(customCard);
                    TextBoxRank.Text = string.Empty;
                    TextBoxSuit.Text = string.Empty;
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Check the empty spaces, you have to fill Suit and Rank of your new card.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There are some errors in the form, please, review your request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// This method will display the dealt card in the new list box.
        /// </summary>
        /// <param name="dealtCards"></param>
        private void DisplayDealtCards(List<Card> dealtCards)
        {
            ListBoxCardsDealt.Items.Clear();
            // add the cards to the list view.
            foreach (Card card in dealtCards)
            {
                ListBoxCardsDealt.Items.Add(card.ToString());
            }
        }
        private void dealInput()
        {
            if (int.TryParse(TextBoxDraw.Text, out int cardsToDeal))
            {
                if (cardsToDeal > 0 && cardsToDeal <= deckInPlay.Count)
                {
                    List<Card> dealtCards = new List<Card>();

                    // get the number of cards from the deck, and place them in a new list.
                    for (int i = 0; i < cardsToDeal; i++)
                    {
                        Card drawnCard = deckInPlay[i];
                        dealtCards.Add(drawnCard);
                    }
                    // Delete the dealt cards from the list of the original deck.
                    foreach (Card cardToRemove in dealtCards)
                    {
                        deckInPlay.Remove(cardToRemove);
                    }
                    // Display the selected cards in the list view.
                    DisplayDealtCards(dealtCards);
                }
                else
                {
                    MessageBox.Show("Invalid number of cards to draw or not enough cards in the deck.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of cards to draw.");
            }
        }
        /// <summary>
        /// Deal cards from the deck and display it in another list. It be possible select how many cards you want to deal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeal_Click(object sender, EventArgs e)
        {
            try
            {
                dealInput();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"The amount of cards in the deck are less than the number you entered: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}