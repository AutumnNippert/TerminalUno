using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Uno
{

    public abstract class Player
    {
        List<Card> _hand = new List<Card>();
        public int xPos = 0;
        public abstract Card playCard(Card topCard, Card pickedCard);
        public string displayHand()
        {
            string cards = "";
            for (int i = 0; i < _hand.Count-1; i++)
            {
                if(i == xPos)
                {
                    cards += "[x] " + _hand[i].toString() + "\n";
                }
                else
                {
                    cards += "[ ] " + _hand[i].toString() + "\n";
                }
            }
            return cards;
        }
        public int getHandCount()
        {
            return _hand.Count;
        }
        public void addCard(Card card)
        {
            _hand.Add(card);
        }
        protected void removeCard(Card card)
        {
            _hand.Remove(card);
        }
        public Card getCard(int index)
        {
            return _hand[index];
        }

        

    }
    public class PersonPlayer : Player
    {
        public override Card playCard(Card topCard, Card pickedCard)
        {
            if(pickedCard is WildCard)
            {
                //go to wildcard things that edit the Game ITSELF
                removeCard(pickedCard);
                return pickedCard;
            }
            else if(pickedCard is NumberCard)
            {
                NumberCard card = pickedCard as NumberCard;
                if (topCard is NumberCard)
                {
                    NumberCard otherTopCard = topCard as NumberCard;
                    if (card._color == otherTopCard._color || card._value == otherTopCard._value)
                    {
                        removeCard(pickedCard);
                        return pickedCard;
                    }
                }
                if (topCard is WildCard)
                {
                    NumberCard otherTopCard = topCard as NumberCard;
                    if (card._color == otherTopCard._color)
                    {
                        removeCard(pickedCard);
                        return pickedCard;
                    }
                }
            }
            return null;
        }
    }
    public class AiPlayer : Player
    {
        public override Card playCard(Card topCard, Card pickedCard)
        {
            if (pickedCard is WildCard)
            {
                //go to wildcard things that edit the Game ITSELF
                removeCard(pickedCard);
                return pickedCard;
            }
            else if (pickedCard is NumberCard)
            {
                NumberCard card = pickedCard as NumberCard;
                if (topCard is NumberCard)
                {
                    NumberCard otherTopCard = topCard as NumberCard;
                    if (card._color == otherTopCard._color || card._value == otherTopCard._value)
                    {
                        removeCard(pickedCard);
                        return pickedCard;
                    }
                }
                if (topCard is WildCard)
                {
                    NumberCard otherTopCard = topCard as NumberCard;
                    if (card._color == otherTopCard._color)
                    {
                        removeCard(pickedCard);
                        return pickedCard;
                    }
                }
            }
            return null;
        }
        //public Card pickCard(Card topCard)
        //{

        //}
    }
}
