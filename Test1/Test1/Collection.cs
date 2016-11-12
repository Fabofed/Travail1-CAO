using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    //Classe mere de Magasin et Inventaire
    class Collection
    {
        private List<Item> items = new List<Item>();

        public Collection()
        {

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
