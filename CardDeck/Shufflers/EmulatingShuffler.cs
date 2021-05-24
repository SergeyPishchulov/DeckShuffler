using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.CardDeck
{
    public class EmulatingShuffler : IDeckShuffler
    {
        public List<Card> Shuffle(List<Card> cards)
        {
            Random rnd = new Random();
            for (var i = 0; i < cards.Count * 10; i++)
            {
                var separatorInd = rnd.Next((int)(cards.Count * 0.4), (int)(cards.Count * 0.6));
                var first = cards.Take(separatorInd);
                var second = cards.Skip(separatorInd);
                cards = second.Concat(first).ToList();
            }
            return cards;
        }
}
}