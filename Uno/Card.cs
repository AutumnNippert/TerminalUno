using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public enum Value
    {
        ZERO, ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, REVERSE, DRAWTWO, SKIP, WILD, WILDDRAWFOUR
    }

    public enum Color
    {
        RED, YELLOW, BLUE, GREEN
    }
    public abstract class Card
    {
        public abstract string toString();


    }
    public class NumberCard : Card
    {
        public Value _value;
        public Color _color;
        public NumberCard(Value value, Color color)
        {
            this._value = value;
            this._color = color;
        }
        public override string toString()
        {
            return this._color.ToString() + " : " + this._value.ToString();
        }

    }
    public class WildCard : Card
    {
        public Value _value;
        public WildCard(Value value)
        {
            this._value = value;
        }
        public override string toString()
        {
            return this._value.ToString();
        }
    }
}
