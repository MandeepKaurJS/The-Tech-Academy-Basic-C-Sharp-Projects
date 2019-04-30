using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int shuffled = 0;
            deck = Shuffle(deck,out shuffled,3);
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("time shuffle {0}:", shuffled);
            Console.ReadLine();

        }
        public static Deck Shuffle(Deck deck,out int shuffled,int times=1)
        {
            shuffled = 0;
            for(int i = 0; i < times; i++)
            {
                shuffled++;
                List<Card> templist = new List<Card>();
                Random random = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    templist.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = templist;
                
            }
            return deck;



        }
        //public static Deck Shuffle(Deck deck,int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
