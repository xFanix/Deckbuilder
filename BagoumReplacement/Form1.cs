using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BagoumReplacement.deckbuilder_gui;
using Json.Net;
using Newtonsoft.Json;

namespace BagoumReplacement
{
    public partial class DeckBuilder : Form
    {
        string classe = "";
        bool isRotation;
        Cardpool c = new Cardpool();
        Deck d = new Deck();
        int testoSelezionato;
        public DeckBuilder()
        {
            InitializeComponent();
        }

        private void ShowCardsInBox()
        {
            foreach (string key in c.cardpool.Keys)
            {
                if (comboBoxNoC.SelectedItem == "Class cards")
                {
                    if (c.cardpool[key].craft == classe && isRotation)
                    {
                        if (c.cardpool[key].rotation)
                        {
                            cardPoolBox.Items.Add(c.cardpool[key].name);
                        }
                    }
                    else if (c.cardpool[key].craft == classe)
                    {
                        cardPoolBox.Items.Add(c.cardpool[key].name);
                    }
                }
                else
                {
                    if (c.cardpool[key].craft == "Neutral" && isRotation)
                    {
                        if (c.cardpool[key].rotation)
                        {
                            cardPoolBox.Items.Add(c.cardpool[key].name);
                        }
                    }
                    else if (c.cardpool[key].craft == "Neutral")
                    {
                        cardPoolBox.Items.Add(c.cardpool[key].name);
                    }
                }
            }
        }
    
        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classe = comboBoxClass.SelectedItem.ToString();
            cardPoolBox.Items.Clear();
            ShowCardsInBox();
        }

        private void ComboBoxNoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardPoolBox.Items.Clear();
            ShowCardsInBox();
        }

        private void CardPool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormat.SelectedItem.Equals("Rotation"))
            {
                isRotation = true;
            }
            else
            {
                isRotation = false;
            }
            cardPoolBox.Items.Clear();
            ShowCardsInBox();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Minicard mc = new Minicard();
                Card card1 = new Card();
                string nomeCartaSelezionata = cardPoolBox.SelectedItem.ToString();
                card1 = c.cardpool[nomeCartaSelezionata];
                mc.pp = card1.pp;
                mc.id = card1.id;
                mc.numCopie = 1;
                d.AddToDeck(cardPoolBox.SelectedItem.ToString(), mc);
            }
            catch (System.NullReferenceException) //TODO: chiedere che eccezione usare
            {
                MessageBox.Show("Nessun elemento selezionato");
            }
            deckBox.Items.Clear();
            foreach (KeyValuePair<string, Minicard> item in d.deck.OrderBy(key => key.Value.id))
            {
                deckBox.Items.Add(item.Value.numCopie+" "+item.Key);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                testoSelezionato = deckBox.SelectedIndex;
                d.RemoveFromDeck(deckBox.SelectedItem.ToString().Substring(2));
            }
            catch //TODO: chiedere che eccezione usare
            {
                MessageBox.Show("Nessun elemento selezionato");
            }
            deckBox.Items.Clear();
            foreach (KeyValuePair<string, Minicard> item in d.deck.OrderBy(key => key.Value.id))
            {
                deckBox.Items.Add(item.Value.numCopie + " " + item.Key);
            }
            try
            {
                deckBox.SelectedIndex = testoSelezionato;
            }
            catch
            {

            }
        }
    }
}

