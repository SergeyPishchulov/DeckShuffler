using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.CardDeck
{
    public class Card
    {
        public readonly CardSuit Suit;
        public readonly CardValue Value;

        public Card(CardSuit s, CardValue v)
        {
            Suit = s;
            Value = v;
        }

    }
}