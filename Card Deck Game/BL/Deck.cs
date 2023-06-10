using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck_Game.BL
{
    public class Deck
    {
        private int count;
        private Card[] deck = new Card[52];
        public Deck()
        {
            count = 0;
            for(int x=1;x<=4;x++)
            {
                for(int y=1;y<=13;y++)
                {
                    deck[count] = new Card(x, y);
                    count++;
                }
            }
        }
        public void shuffle()
        {
            System.Random rand = new System.Random();
            Card temp;
            for(int i=0;i<52;i++)
            {
                int num = rand.Next(0, 52);
                temp = deck[num];
                deck[num] = deck[i];
                deck[i] = temp;
            }
            count = 52;

        }
        public Card dealCard()
        {
            if(count>0)
            {
                count--;
                return deck[count];
            }
            else
            {
                return null;
            }
        }
        public int cardsLeft()
        {
            return count;

        }



    }
}
