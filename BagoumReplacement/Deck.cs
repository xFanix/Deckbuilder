using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagoumReplacement
{
    class Minicard
    {
        public int pp { get; set; }
        public int numCopie { get; set; }
        public int id { get; set; }

    }
    class Deck
    {
        public Dictionary<string, Minicard> deck = new Dictionary<string, Minicard>();
        public void AddToDeck(string nomecarta, Minicard copieandcosto)
        {
            if (deck.ContainsKey(nomecarta))
            {
                if(deck[nomecarta].numCopie < 3)
                {
                    deck[nomecarta].numCopie++;
                }
            }
            else
            {
                deck.Add(nomecarta, copieandcosto);
            }
        }

        public void RemoveFromDeck(string nomecarta)
        {
            if (deck.ContainsKey(nomecarta))
            {
                deck[nomecarta].numCopie--;
                if (deck[nomecarta].numCopie == 0)
                {
                    deck.Remove(nomecarta);
                }
            }
        }
    }
}
