using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    public struct Card
    {
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit
    {
        Spades,Dimonds,Hearts,Clubs
    }
    public enum Face
    {
        Two,Three,Four,Five,Six,Seven,
                Eight,Nine,Ten,Jack,Queen,King,Ace
    }
}
