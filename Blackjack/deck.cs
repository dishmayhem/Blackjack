using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack
{
    class deck
    {
        public List<card> cards;
        public int numDecks;

        public deck(int numberOfDecks)
        {
            this.numDecks = numberOfDecks;
            this.cards = buildDeck(numDecks);
        }

        public List<card> buildDeck(int numDecks)
        {
            string[] suits = { "clubs", "diamonds", "hearts", "spades" };

            List<card> deck = new List<card>();
            int deckindex = 0;
            foreach (string s in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    deckindex++;
                    card c = new card();
                    c.index = deckindex;
                    c.suit = s;

                    switch (i)
                    {
                        case 1:
                            c.value = 11;
                            c.face = "ace";
                            break;
                        case 11:
                            c.value = 10;
                            c.face = "jack";
                            break;
                        case 12:
                            c.value = 10;
                            c.face = "queen";
                            break;
                        case 13:
                            c.value = 10;
                            c.face = "king";
                            break;
                        default:
                            c.value = i;
                            c.face = i.ToString();
                            break;
                    }
                    deck.Add(c);
                }
            }

            return deck;
        }
    }

}

