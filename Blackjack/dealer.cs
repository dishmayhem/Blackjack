using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Blackjack
{
    class dealer
    {
        public List<card> deck;
        public int numberOfDecks;

        public dealer(int numDecks)
        {
            this.deck = new deck(1).cards;
            this.numberOfDecks = numDecks;
        }

        public int[] shuffle()
        {
            int[] shuffleIndex = Enumerable.Range(0, 52 * numberOfDecks - 1).ToArray();
            Random rnd = new Random();

            for (int i = shuffleIndex.Length -1; i > 0; i--)
            {

                int randomIndex = rnd.Next(0, i + 1);
                int temp = shuffleIndex[i];
                shuffleIndex[i] = shuffleIndex[randomIndex];
                shuffleIndex[randomIndex] = temp;

            }

            return shuffleIndex;
        }

   

    }
}
