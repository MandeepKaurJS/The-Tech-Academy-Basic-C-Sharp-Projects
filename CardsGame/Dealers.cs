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
        public Deck Deck { get; set; }
        public int Balacne { get; set; }
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString());
            Deck.Cards.RemoveAt(0);
        }
    }
}
