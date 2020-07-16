namespace deckbuilder_gui
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cardpool c = new Cardpool();
            foreach (string key in c.cardpool.Keys)
            {
                System.Console.WriteLine(c.cardpool[key].baseAttack);
            }
        }
    }
}