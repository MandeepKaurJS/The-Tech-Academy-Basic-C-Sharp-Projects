using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    public class Dealers
    {
        public string Name { get; set; }
        public Deck Deck1 { get; set; }
        public int balacne { get; set; }
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck1.Cards.First());
            Console.WriteLine(Deck1.Cards.First().ToString());
            Deck1.Cards.RemoveAt(0);
        }
    }
}
