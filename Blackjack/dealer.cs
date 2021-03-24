using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class dealer
    {
        public List<card> deck;

        public dealer(int numDecks)
        {
            this.deck = new deck(1).cards;
        }
    }
}
