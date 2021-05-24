using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApplication.CardDeck
{
    public class DeckContainer
    {
        private readonly Dictionary<string, Deck> decks = new Dictionary<string, Deck>();

        public void DeleteDeck(string deckName)
        {
            if (decks.ContainsKey(deckName))
                decks.Remove(deckName);
            else
                throw new ArgumentException("There is no such Deck with specified name");
        }

        public Deck GetByName(string deckName)
        {
            if (decks.ContainsKey(deckName))
                return decks[deckName];
            else
                throw new ArgumentException("There is no such Deck with specified name");
        }

        public void CreateDeck(string deckName)
        {
            decks[deckName] = new Deck(deckName);
        }

        public List<string> DeckNames => decks.Keys.ToList();
    }
}