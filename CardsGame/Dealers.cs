using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CardsGame
{
    public class Dealers
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balacne { get; set; }
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\VrinMan Dulay\Documents\test.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
