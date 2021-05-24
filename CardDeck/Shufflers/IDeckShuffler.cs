using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApplication.CardDeck
{
    public interface IDeckShuffler
    {
        List<Card> Shuffle(List<Card> cards);
    }
}
