using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    public class TwentyOneDealer:Dealers
    {
        public List<Card> Hand { get; set; }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
        
    }
}
