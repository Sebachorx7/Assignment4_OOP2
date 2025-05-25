namespace Assignment4
{
    partial class SebastianDeckBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SebastianDeckBuilder));
            this.ButtonViewDeck = new System.Windows.Forms.Button();
            this.ButtonShuffle = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ListBoxShowDeck = new System.Windows.Forms.ListBox();
            this.LabelDeck = new System.Windows.Forms.Label();
            this.ListBoxCardsDealt = new System.Windows.Forms.ListBox();
            this.LabelCardsDealt = new System.Windows.Forms.Label();
            this.LabelDraw = new System.Windows.Forms.Label();
            this.TextBoxDraw = new System.Windows.Forms.TextBox();
            this.ButtonDeal = new System.Windows.Forms.Button();
            this.GroupBoxCard = new System.Windows.Forms.GroupBox();
            this.ButtonAddCustom = new System.Windows.Forms.Button();
            this.LabelRank = new System.Windows.Forms.Label();
            this.LabelSuit = new System.Windows.Forms.Label();
            this.TextBoxRank = new System.Windows.Forms.TextBox();
            this.TextBoxSuit = new System.Windows.Forms.TextBox();
            this.ToolTipDeckBulder = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonViewDeck
            // 
            this.ButtonViewDeck.BackColor = System.Drawing.Color.Sienna;
            this.ButtonViewDeck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonViewDeck.BackgroundImage")));
            this.ButtonViewDeck.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewDeck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonViewDeck.Location = new System.Drawing.Point(499, 317);
            this.ButtonViewDeck.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ButtonViewDeck.Name = "ButtonViewDeck";
            this.ButtonViewDeck.Size = new System.Drawing.Size(114, 43);
            this.ButtonViewDeck.TabIndex = 2;
            this.ButtonViewDeck.Text = "&View Deck";
            this.ToolTipDeckBulder.SetToolTip(this.ButtonViewDeck, "View your current deck");
            this.ButtonViewDeck.UseVisualStyleBackColor = false;
            this.ButtonViewDeck.Click += new System.EventHandler(this.ButtonViewDeck_Click);
            // 
            // ButtonShuffle
            // 
            this.ButtonShuffle.BackColor = System.Drawing.Color.Gold;
            this.ButtonShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonShuffle.BackgroundImage")));
            this.ButtonShuffle.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShuffle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonShuffle.Location = new System.Drawing.Point(499, 389);
            this.ButtonShuffle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ButtonShuffle.Name = "ButtonShuffle";
            this.ButtonShuffle.Size = new System.Drawing.Size(114, 43);
            this.ButtonShuffle.TabIndex = 3;
            this.ButtonShuffle.Text = "&Shuffle";
            this.ToolTipDeckBulder.SetToolTip(this.ButtonShuffle, "Shuffle your deck");
            this.ButtonShuffle.UseVisualStyleBackColor = false;
            this.ButtonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Gold;
            this.ButtonReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonReset.BackgroundImage")));
            this.ButtonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonReset.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonReset.Location = new System.Drawing.Point(499, 529);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(114, 43);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "&Reset";
            this.ToolTipDeckBulder.SetToolTip(this.ButtonReset, "Reset the form");
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gold;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit.Location = new System.Drawing.Point(499, 616);
            this.Exit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(114, 43);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "&Exit";
            this.ToolTipDeckBulder.SetToolTip(this.Exit, "Exit the program");
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ListBoxShowDeck
            // 
            this.ListBoxShowDeck.BackColor = System.Drawing.Color.DarkGreen;
            this.ListBoxShowDeck.ForeColor = System.Drawing.Color.Gold;
            this.ListBoxShowDeck.FormattingEnabled = true;
            this.ListBoxShowDeck.ItemHeight = 18;
            this.ListBoxShowDeck.Location = new System.Drawing.Point(279, 222);
            this.ListBoxShowDeck.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ListBoxShowDeck.Name = "ListBoxShowDeck";
            this.ListBoxShowDeck.Size = new System.Drawing.Size(208, 364);
            this.ListBoxShowDeck.TabIndex = 1;
            this.ToolTipDeckBulder.SetToolTip(this.ListBoxShowDeck, "Display your currrent deck");
            // 
            // LabelDeck
            // 
            this.LabelDeck.AutoSize = true;
            this.LabelDeck.BackColor = System.Drawing.Color.Transparent;
            this.LabelDeck.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeck.ForeColor = System.Drawing.Color.Gold;
            this.LabelDeck.Location = new System.Drawing.Point(356, 189);
            this.LabelDeck.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDeck.Name = "LabelDeck";
            this.LabelDeck.Size = new System.Drawing.Size(45, 18);
            this.LabelDeck.TabIndex = 0;
            this.LabelDeck.Text = "Deck";
            this.ToolTipDeckBulder.SetToolTip(this.LabelDeck, "Display your currrent deck");
            // 
            // ListBoxCardsDealt
            // 
            this.ListBoxCardsDealt.BackColor = System.Drawing.Color.DarkGreen;
            this.ListBoxCardsDealt.ForeColor = System.Drawing.Color.Gold;
            this.ListBoxCardsDealt.FormattingEnabled = true;
            this.ListBoxCardsDealt.ItemHeight = 18;
            this.ListBoxCardsDealt.Location = new System.Drawing.Point(722, 411);
            this.ListBoxCardsDealt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ListBoxCardsDealt.Name = "ListBoxCardsDealt";
            this.ListBoxCardsDealt.Size = new System.Drawing.Size(159, 202);
            this.ListBoxCardsDealt.TabIndex = 6;
            this.ToolTipDeckBulder.SetToolTip(this.ListBoxCardsDealt, "Show the cards dealt");
            // 
            // LabelCardsDealt
            // 
            this.LabelCardsDealt.AutoSize = true;
            this.LabelCardsDealt.BackColor = System.Drawing.Color.Transparent;
            this.LabelCardsDealt.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCardsDealt.ForeColor = System.Drawing.Color.Gold;
            this.LabelCardsDealt.Location = new System.Drawing.Point(755, 389);
            this.LabelCardsDealt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelCardsDealt.Name = "LabelCardsDealt";
            this.LabelCardsDealt.Size = new System.Drawing.Size(97, 18);
            this.LabelCardsDealt.TabIndex = 0;
            this.LabelCardsDealt.Text = "Cards Dealt";
            this.ToolTipDeckBulder.SetToolTip(this.LabelCardsDealt, "Show the cards dealt");
            // 
            // LabelDraw
            // 
            this.LabelDraw.AutoSize = true;
            this.LabelDraw.BackColor = System.Drawing.Color.Transparent;
            this.LabelDraw.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDraw.ForeColor = System.Drawing.Color.Gold;
            this.LabelDraw.Location = new System.Drawing.Point(768, 263);
            this.LabelDraw.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelDraw.Name = "LabelDraw";
            this.LabelDraw.Size = new System.Drawing.Size(50, 18);
            this.LabelDraw.TabIndex = 0;
            this.LabelDraw.Text = "Dr&aw";
            this.ToolTipDeckBulder.SetToolTip(this.LabelDraw, "Writre a number and choose how many cards you want to pull");
            // 
            // TextBoxDraw
            // 
            this.TextBoxDraw.BackColor = System.Drawing.Color.Bisque;
            this.TextBoxDraw.Location = new System.Drawing.Point(758, 290);
            this.TextBoxDraw.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TextBoxDraw.Name = "TextBoxDraw";
            this.TextBoxDraw.Size = new System.Drawing.Size(75, 25);
            this.TextBoxDraw.TabIndex = 4;
            this.ToolTipDeckBulder.SetToolTip(this.TextBoxDraw, "Writre a number and choose how many cards you want to pull");
            // 
            // ButtonDeal
            // 
            this.ButtonDeal.BackColor = System.Drawing.Color.Gold;
            this.ButtonDeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDeal.BackgroundImage")));
            this.ButtonDeal.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDeal.Location = new System.Drawing.Point(738, 333);
            this.ButtonDeal.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ButtonDeal.Name = "ButtonDeal";
            this.ButtonDeal.Size = new System.Drawing.Size(114, 43);
            this.ButtonDeal.TabIndex = 5;
            this.ButtonDeal.Text = "&Deal";
            this.ToolTipDeckBulder.SetToolTip(this.ButtonDeal, "Deal your deck");
            this.ButtonDeal.UseVisualStyleBackColor = false;
            this.ButtonDeal.Click += new System.EventHandler(this.ButtonDeal_Click);
            // 
            // GroupBoxCard
            // 
            this.GroupBoxCard.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxCard.Controls.Add(this.ButtonAddCustom);
            this.GroupBoxCard.Controls.Add(this.LabelRank);
            this.GroupBoxCard.Controls.Add(this.LabelSuit);
            this.GroupBoxCard.Controls.Add(this.TextBoxRank);
            this.GroupBoxCard.Controls.Add(this.TextBoxSuit);
            this.GroupBoxCard.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCard.ForeColor = System.Drawing.Color.Gold;
            this.GroupBoxCard.Location = new System.Drawing.Point(508, 85);
            this.GroupBoxCard.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxCard.Name = "GroupBoxCard";
            this.GroupBoxCard.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.GroupBoxCard.Size = new System.Drawing.Size(394, 157);
            this.GroupBoxCard.TabIndex = 9;
            this.GroupBoxCard.TabStop = false;
            this.GroupBoxCard.Text = "Card";
            this.ToolTipDeckBulder.SetToolTip(this.GroupBoxCard, "Used to add a new card from your imagination");
            // 
            // ButtonAddCustom
            // 
            this.ButtonAddCustom.BackColor = System.Drawing.Color.Gold;
            this.ButtonAddCustom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddCustom.BackgroundImage")));
            this.ButtonAddCustom.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCustom.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonAddCustom.Location = new System.Drawing.Point(271, 72);
            this.ButtonAddCustom.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ButtonAddCustom.Name = "ButtonAddCustom";
            this.ButtonAddCustom.Size = new System.Drawing.Size(114, 43);
            this.ButtonAddCustom.TabIndex = 3;
            this.ButtonAddCustom.Text = "Add &Custom";
            this.ToolTipDeckBulder.SetToolTip(this.ButtonAddCustom, "Click to add your custom card");
            this.ButtonAddCustom.UseVisualStyleBackColor = false;
            this.ButtonAddCustom.Click += new System.EventHandler(this.ButtonAddCustom_Click);
            // 
            // LabelRank
            // 
            this.LabelRank.AutoSize = true;
            this.LabelRank.Location = new System.Drawing.Point(10, 86);
            this.LabelRank.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelRank.Name = "LabelRank";
            this.LabelRank.Size = new System.Drawing.Size(44, 18);
            this.LabelRank.TabIndex = 0;
            this.LabelRank.Text = "Ran&k";
            this.ToolTipDeckBulder.SetToolTip(this.LabelRank, "Insert the rank from your card");
            // 
            // LabelSuit
            // 
            this.LabelSuit.AutoSize = true;
            this.LabelSuit.Location = new System.Drawing.Point(10, 42);
            this.LabelSuit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelSuit.Name = "LabelSuit";
            this.LabelSuit.Size = new System.Drawing.Size(34, 18);
            this.LabelSuit.TabIndex = 0;
            this.LabelSuit.Text = "S&uit";
            this.ToolTipDeckBulder.SetToolTip(this.LabelSuit, "Insert the suit from your card");
            // 
            // TextBoxRank
            // 
            this.TextBoxRank.BackColor = System.Drawing.Color.Bisque;
            this.TextBoxRank.Location = new System.Drawing.Point(92, 89);
            this.TextBoxRank.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TextBoxRank.Name = "TextBoxRank";
            this.TextBoxRank.Size = new System.Drawing.Size(148, 25);
            this.TextBoxRank.TabIndex = 2;
            this.ToolTipDeckBulder.SetToolTip(this.TextBoxRank, "Insert the rank from your card");
            // 
            // TextBoxSuit
            // 
            this.TextBoxSuit.BackColor = System.Drawing.Color.Bisque;
            this.TextBoxSuit.Location = new System.Drawing.Point(92, 42);
            this.TextBoxSuit.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.TextBoxSuit.Name = "TextBoxSuit";
            this.TextBoxSuit.Size = new System.Drawing.Size(148, 25);
            this.TextBoxSuit.TabIndex = 1;
            this.ToolTipDeckBulder.SetToolTip(this.TextBoxSuit, "Insert the suit from your card");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(56, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sebastian\'s Deck Builder";
            this.ToolTipDeckBulder.SetToolTip(this.label1, "Display your currrent deck");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 213);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SebastianDeckBuilder
            // 
            this.AcceptButton = this.ButtonViewDeck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.ButtonReset;
            this.ClientSize = new System.Drawing.Size(1037, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBoxCard);
            this.Controls.Add(this.ButtonDeal);
            this.Controls.Add(this.TextBoxDraw);
            this.Controls.Add(this.LabelDraw);
            this.Controls.Add(this.LabelCardsDealt);
            this.Controls.Add(this.ListBoxCardsDealt);
            this.Controls.Add(this.LabelDeck);
            this.Controls.Add(this.ListBoxShowDeck);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonShuffle);
            this.Controls.Add(this.ButtonViewDeck);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximumSize = new System.Drawing.Size(1053, 734);
            this.MinimumSize = new System.Drawing.Size(1053, 734);
            this.Name = "SebastianDeckBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sebastian\'s Deck Builder";
            this.Load += new System.EventHandler(this.SebastianDeckBuilder_Load);
            this.GroupBoxCard.ResumeLayout(false);
            this.GroupBoxCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonViewDeck;
        private System.Windows.Forms.Button ButtonShuffle;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox ListBoxShowDeck;
        private System.Windows.Forms.Label LabelDeck;
        private System.Windows.Forms.ListBox ListBoxCardsDealt;
        private System.Windows.Forms.Label LabelCardsDealt;
        private System.Windows.Forms.Label LabelDraw;
        private System.Windows.Forms.TextBox TextBoxDraw;
        private System.Windows.Forms.Button ButtonDeal;
        private System.Windows.Forms.GroupBox GroupBoxCard;
        private System.Windows.Forms.Button ButtonAddCustom;
        private System.Windows.Forms.Label LabelRank;
        private System.Windows.Forms.Label LabelSuit;
        private System.Windows.Forms.TextBox TextBoxRank;
        private System.Windows.Forms.TextBox TextBoxSuit;
        private System.Windows.Forms.ToolTip ToolTipDeckBulder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

