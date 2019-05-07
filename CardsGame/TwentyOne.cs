using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
   public class TwentyOne:Game,IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
        }
        public override void ListPlayer()
        {
            Console.WriteLine("Welcome to 21 Players");
            base.ListPlayer();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
