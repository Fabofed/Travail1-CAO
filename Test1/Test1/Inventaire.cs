using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    [Serializable]
    //Herite de la classe Collection
    class Inventaire : Collection
    {
        public Item Details { get; set; }
        public int Quantite { get; set; }

        public Inventaire (Item details, int quantite)
        {
            Details = details;
            Quantite = quantite;
        }
    }
}
