using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.CardDeck
{
    public class Deck
    {
        public string Name { get; private set; }
        public List<Card> Cards { get; private set; }
        public Deck(string name)
        {
            Name = name;
            Cards = CreateSortedDeck();
        }

        public void Shuffle(IDeckShuffler shuffler)
        {
            Cards = shuffler.Shuffle(Cards);
        }

        private static List<Card> CreateSortedDeck()
        {
            var res = new List<Card>();
            foreach (var value in Enum.GetValues(typeof(CardValue)).Cast<CardValue>())
                foreach (var suit in Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>())
                    res.Add(new Card(suit, value));
            return res;
        }
    }
}