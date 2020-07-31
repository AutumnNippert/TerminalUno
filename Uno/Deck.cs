using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public class Deck
    {
        List<Card> _cards = new List<Card>();
        Card _topCard;
        public Deck()
        {

        }
        public void addCard(Card card)
        {
            _cards.Add(card);
        }
        public void populate()
        {
            _cards.Add(new NumberCard(Value.ZERO, Color.RED));
            _cards.Add(new NumberCard(Value.ZERO, Color.YELLOW));
            _cards.Add(new NumberCard(Value.ZERO, Color.BLUE));
            _cards.Add(new NumberCard(Value.ZERO, Color.GREEN));
            _cards.Add(new NumberCard(Value.ONE, Color.RED));
            _cards.Add(new NumberCard(Value.TWO, Color.RED));
            _cards.Add(new NumberCard(Value.THREE, Color.RED));
            _cards.Add(new NumberCard(Value.FOUR, Color.RED));
            _cards.Add(new NumberCard(Value.FIVE, Color.RED));
            _cards.Add(new NumberCard(Value.SIX, Color.RED));
            _cards.Add(new NumberCard(Value.SEVEN, Color.RED));
            _cards.Add(new NumberCard(Value.EIGHT, Color.RED));
            _cards.Add(new NumberCard(Value.NINE, Color.RED));
            _cards.Add(new NumberCard(Value.REVERSE, Color.RED));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.RED));
            _cards.Add(new NumberCard(Value.SKIP, Color.RED));
            _cards.Add(new NumberCard(Value.ONE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.TWO, Color.YELLOW));
            _cards.Add(new NumberCard(Value.THREE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.FOUR, Color.YELLOW));
            _cards.Add(new NumberCard(Value.FIVE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SIX, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SEVEN, Color.YELLOW));
            _cards.Add(new NumberCard(Value.EIGHT, Color.YELLOW));
            _cards.Add(new NumberCard(Value.NINE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.REVERSE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SKIP, Color.YELLOW));
            _cards.Add(new NumberCard(Value.ONE, Color.BLUE));
            _cards.Add(new NumberCard(Value.TWO, Color.BLUE));
            _cards.Add(new NumberCard(Value.THREE, Color.BLUE));
            _cards.Add(new NumberCard(Value.FOUR, Color.BLUE));
            _cards.Add(new NumberCard(Value.FIVE, Color.BLUE));
            _cards.Add(new NumberCard(Value.SIX, Color.BLUE));
            _cards.Add(new NumberCard(Value.SEVEN, Color.BLUE));
            _cards.Add(new NumberCard(Value.EIGHT, Color.BLUE));
            _cards.Add(new NumberCard(Value.NINE, Color.BLUE));
            _cards.Add(new NumberCard(Value.REVERSE, Color.BLUE));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.BLUE));
            _cards.Add(new NumberCard(Value.SKIP, Color.BLUE));
            _cards.Add(new NumberCard(Value.ONE, Color.GREEN));
            _cards.Add(new NumberCard(Value.TWO, Color.GREEN));
            _cards.Add(new NumberCard(Value.THREE, Color.GREEN));
            _cards.Add(new NumberCard(Value.FOUR, Color.GREEN));
            _cards.Add(new NumberCard(Value.FIVE, Color.GREEN));
            _cards.Add(new NumberCard(Value.SIX, Color.GREEN));
            _cards.Add(new NumberCard(Value.SEVEN, Color.GREEN));
            _cards.Add(new NumberCard(Value.EIGHT, Color.GREEN));
            _cards.Add(new NumberCard(Value.NINE, Color.GREEN));
            _cards.Add(new NumberCard(Value.REVERSE, Color.GREEN));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.GREEN));
            _cards.Add(new NumberCard(Value.SKIP, Color.GREEN));
            _cards.Add(new NumberCard(Value.ONE, Color.RED));
            _cards.Add(new NumberCard(Value.TWO, Color.RED));
            _cards.Add(new NumberCard(Value.THREE, Color.RED));
            _cards.Add(new NumberCard(Value.FOUR, Color.RED));
            _cards.Add(new NumberCard(Value.FIVE, Color.RED));
            _cards.Add(new NumberCard(Value.SIX, Color.RED));
            _cards.Add(new NumberCard(Value.SEVEN, Color.RED));
            _cards.Add(new NumberCard(Value.EIGHT, Color.RED));
            _cards.Add(new NumberCard(Value.NINE, Color.RED));
            _cards.Add(new NumberCard(Value.REVERSE, Color.RED));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.RED));
            _cards.Add(new NumberCard(Value.SKIP, Color.RED));
            _cards.Add(new NumberCard(Value.ONE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.TWO, Color.YELLOW));
            _cards.Add(new NumberCard(Value.THREE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.FOUR, Color.YELLOW));
            _cards.Add(new NumberCard(Value.FIVE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SIX, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SEVEN, Color.YELLOW));
            _cards.Add(new NumberCard(Value.EIGHT, Color.YELLOW));
            _cards.Add(new NumberCard(Value.NINE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.REVERSE, Color.YELLOW));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.YELLOW));
            _cards.Add(new NumberCard(Value.SKIP, Color.YELLOW));
            _cards.Add(new NumberCard(Value.ONE, Color.BLUE));
            _cards.Add(new NumberCard(Value.TWO, Color.BLUE));
            _cards.Add(new NumberCard(Value.THREE, Color.BLUE));
            _cards.Add(new NumberCard(Value.FOUR, Color.BLUE));
            _cards.Add(new NumberCard(Value.FIVE, Color.BLUE));
            _cards.Add(new NumberCard(Value.SIX, Color.BLUE));
            _cards.Add(new NumberCard(Value.SEVEN, Color.BLUE));
            _cards.Add(new NumberCard(Value.EIGHT, Color.BLUE));
            _cards.Add(new NumberCard(Value.NINE, Color.BLUE));
            _cards.Add(new NumberCard(Value.REVERSE, Color.BLUE));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.BLUE));
            _cards.Add(new NumberCard(Value.SKIP, Color.BLUE));
            _cards.Add(new NumberCard(Value.ONE, Color.GREEN));
            _cards.Add(new NumberCard(Value.TWO, Color.GREEN));
            _cards.Add(new NumberCard(Value.THREE, Color.GREEN));
            _cards.Add(new NumberCard(Value.FOUR, Color.GREEN));
            _cards.Add(new NumberCard(Value.FIVE, Color.GREEN));
            _cards.Add(new NumberCard(Value.SIX, Color.GREEN));
            _cards.Add(new NumberCard(Value.SEVEN, Color.GREEN));
            _cards.Add(new NumberCard(Value.EIGHT, Color.GREEN));
            _cards.Add(new NumberCard(Value.NINE, Color.GREEN));
            _cards.Add(new NumberCard(Value.REVERSE, Color.GREEN));
            _cards.Add(new NumberCard(Value.DRAWTWO, Color.GREEN));
            _cards.Add(new NumberCard(Value.SKIP, Color.GREEN));
            _cards.Add(new WildCard(Value.WILD));
            _cards.Add(new WildCard(Value.WILD));
            _cards.Add(new WildCard(Value.WILD));
            _cards.Add(new WildCard(Value.WILD));
            _cards.Add(new WildCard(Value.WILDDRAWFOUR));
            _cards.Add(new WildCard(Value.WILDDRAWFOUR));
            _cards.Add(new WildCard(Value.WILDDRAWFOUR));
            _cards.Add(new WildCard(Value.WILDDRAWFOUR));
        }
        public Card draw()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _cards.Count-1);
            Card card = _cards[randomNumber];
            _cards.RemoveAt(randomNumber);
            return card;
        }
    }
}
