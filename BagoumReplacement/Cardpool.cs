using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace BagoumReplacement
{
    namespace deckbuilder_gui
    {
        public class Cardpool
        {
            public Dictionary<string, Card> cardpool;
            public Cardpool()
            {
                string lines = File.ReadAllText($"D:\\Destinazione Items Programmi C#\\Complete.json");
                cardpool = JsonConvert.DeserializeObject<Dictionary<string, Card>>(lines);
            }
        }
    }
}
