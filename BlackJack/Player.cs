using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        
        public Card[] Cards { get; set; }

        public string Name { get; set; }

        public int ChairNumber { get; set; }

        public Player(int inChairNumber)
        {
            this.ChairNumber = inChairNumber;
        }

    }
}
