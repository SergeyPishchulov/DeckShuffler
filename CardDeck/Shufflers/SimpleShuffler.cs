using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.CardDeck
{
    public class SimpleShuffler : IDeckShuffler
    {

        public List<Card> Shuffle(List<Card> cards)
        {
            Random rnd = new Random();
            return cards.OrderBy(x => rnd.Next()).ToList();
        }
    }
}