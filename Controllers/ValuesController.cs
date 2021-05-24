using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApplication.CardDeck;

namespace WebApiApplication.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly DeckContainer decks = new DeckContainer();
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("api/decks/{name}")]
        public string Create(string deckName)
        {
            decks.CreateDeck(deckName);
            return "Created";
        }

        [HttpDelete]
        [Route("api/decks/{name}")]
        public string Delete(string deckName)
        {
            try
            {
                decks.DeleteDeck(deckName);
                return $"{deckName} deleted";
            }
            catch (ArgumentException)
            {
                return $"{deckName} is not deleted. No such deck name";
            }
        }

        [HttpGet]
        [Route("api/decks")]
        public List<string> GetNames()
        {
            return decks.DeckNames;
        }

        [HttpPost]
        [Route("api/decks/{name}/shuffle")]
        public void Shuffle(string deckName)
        {
            decks.GetByName(deckName).Shuffle(DeckConfig.Shuffler);
        }

    }
}
