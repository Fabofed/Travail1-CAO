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
        protected List<Item> items { get; set; }

        public Collection()
        {
            items = new List<Item>();
        }

        //Ajoute une item a une collection
        public Collection Ajouter(Item item, Collection collection) //Passe la collection et l'item en parametre
        {
            collection.items.Add(item); //Ajoute l'item a la collection
            return collection;
        }
        

    public Collection Supprimer(Item item, Collection collection) //Passe la collection et l'item en parametre
        {
            foreach (Item unItem in collection)
            {


            }
            collection.items.Remove(item); //Enleve l'item a la collection
            return collection;
        } 


        public void Afficher()
        {
            foreach (Item item in items)
            {
                item.ToString();
            }
        }
    }


}

