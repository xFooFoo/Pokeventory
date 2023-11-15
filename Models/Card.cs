using System.Diagnostics;

namespace Pokeventory.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
        public string Set { get; set; }
        public int BuyPrice { get; set; }
        public int InitialMktPrice { get; set; }
        public int MktPrice { get; set; }
        public int Stock { get; set; }
        public Card()
        {
            
        }
    }
}
