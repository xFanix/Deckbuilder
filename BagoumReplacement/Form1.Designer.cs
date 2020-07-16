namespace BagoumReplacement
{
    partial class DeckBuilder
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.formatLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.cardPoolBox = new System.Windows.Forms.ListBox();
            this.deckBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.deckLabel = new System.Windows.Forms.Label();
            this.cardPoolLabel = new System.Windows.Forms.Label();
            this.comboBoxNoC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "Rotation",
            "Unlimited"});
            this.comboBoxFormat.Location = new System.Drawing.Point(276, 45);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(162, 21);
            this.comboBoxFormat.TabIndex = 0;
            this.comboBoxFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFormat_SelectedIndexChanged);
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(274, 29);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(39, 13);
            this.formatLabel.TabIndex = 1;
            this.formatLabel.Text = "Format";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(274, 73);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(32, 13);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Forestcraft",
            "Swordcraft",
            "Runecraft",
            "Dragoncraft",
            "Bloodcraft",
            "Shadowcraft",
            "Havencraft",
            "Portalcraft"});
            this.comboBoxClass.Location = new System.Drawing.Point(277, 89);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(161, 21);
            this.comboBoxClass.TabIndex = 3;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClass_SelectedIndexChanged);
            // 
            // cardPool
            // 
            this.cardPoolBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cardPoolBox.FormattingEnabled = true;
            this.cardPoolBox.Location = new System.Drawing.Point(32, 45);
            this.cardPoolBox.Name = "cardPool";
            this.cardPoolBox.Size = new System.Drawing.Size(171, 524);
            this.cardPoolBox.TabIndex = 4;
            this.cardPoolBox.SelectedIndexChanged += new System.EventHandler(this.CardPool_SelectedIndexChanged);
            // 
            // deckBox
            // 
            this.deckBox.FormattingEnabled = true;
            this.deckBox.Location = new System.Drawing.Point(277, 188);
            this.deckBox.Name = "deckBox";
            this.deckBox.Size = new System.Drawing.Size(161, 381);
            this.deckBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 588);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(277, 588);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // deckLabel
            // 
            this.deckLabel.AutoSize = true;
            this.deckLabel.Location = new System.Drawing.Point(274, 172);
            this.deckLabel.Name = "deckLabel";
            this.deckLabel.Size = new System.Drawing.Size(33, 13);
            this.deckLabel.TabIndex = 8;
            this.deckLabel.Text = "Deck";
            // 
            // cardPoolLabel
            // 
            this.cardPoolLabel.AutoSize = true;
            this.cardPoolLabel.Location = new System.Drawing.Point(32, 29);
            this.cardPoolLabel.Name = "cardPoolLabel";
            this.cardPoolLabel.Size = new System.Drawing.Size(53, 13);
            this.cardPoolLabel.TabIndex = 9;
            this.cardPoolLabel.Text = "Card Pool";
            // 
            // comboBoxNoC
            // 
            this.comboBoxNoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNoC.FormattingEnabled = true;
            this.comboBoxNoC.Items.AddRange(new object[] {
            "Class cards",
            "Neutral cards"});
            this.comboBoxNoC.Location = new System.Drawing.Point(277, 134);
            this.comboBoxNoC.Name = "comboBoxNoC";
            this.comboBoxNoC.Size = new System.Drawing.Size(161, 21);
            this.comboBoxNoC.TabIndex = 11;
            this.comboBoxNoC.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNoC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Neutral/Class";
            // 
            // DeckBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 644);
            this.Controls.Add(this.comboBoxNoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardPoolLabel);
            this.Controls.Add(this.deckLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deckBox);
            this.Controls.Add(this.cardPoolBox);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.comboBoxFormat);
            this.Name = "DeckBuilder";
            this.Text = "Deck Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ListBox cardPoolBox;
        private System.Windows.Forms.ListBox deckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label deckLabel;
        private System.Windows.Forms.Label cardPoolLabel;
        private System.Windows.Forms.ComboBox comboBoxNoC;
        private System.Windows.Forms.Label label1;
    }
}

