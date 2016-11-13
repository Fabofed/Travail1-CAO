using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    //Classe mere de Magasin et Inventaire
    public abstract class Collection
    {
        private List<Item> items { get; set; }

        public Collection()
        {
            items = new List<Item>();
        }

        public void Ajouter(Item item)
        {
            Item aAjouter = item;
        }

        public void Supprimer(Item item)
        {
            Item aRetirer = item;
        }
    }
}
