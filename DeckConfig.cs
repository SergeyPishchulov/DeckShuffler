using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiApplication.CardDeck;

namespace WebApiApplication
{
    public class DeckConfig
    {
        public static IDeckShuffler Shuffler = new SimpleShuffler();
    }
}