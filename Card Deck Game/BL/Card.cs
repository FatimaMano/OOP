using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Deck_Game
{
    public class Card
    {
        private int value;
        private int suit;
        public Card(int theValue,int theSuit)
        {
            this.value = theValue;
            this.suit = theSuit;
        }
        public int getValue()
        {
            return value;
        }
        public int getSuit()
        {
            return suit;
        }
        public String getSuitAsString()
        {
            if (suit == 1)
            {
                return "Clubs";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
            
        }
        public String getValueAsString()
        {
            if(value == 1)
            {
                return "Ace";
            }
            else if(value == 11)
            {
                return "Jack";
            }
            else if(value == 12)
            {
                return "Queen";
            }
            else if(value == 13)
            {
                return "King";
            }
            return value.ToString();
        }
        public String toString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
    }
}
