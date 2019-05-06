using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    public class Card
    {
        public Card()
        {
            //Suit = "Spades";
            Face = "Two";
        }
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        spades,dimonds
    }
}
