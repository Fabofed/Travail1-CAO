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
        private int taille { get; set; }


        public Collection()
        {
            items = new List<Item>();
            taille = 0;
        }

        public List<Item> Items
        {
            get
            {
                foreach (Item item in items)
                {
                    item.ToString();
                }
                return this.items;
            }
        }

        //Ajoute une item a une collection
        public Collection Ajouter(Item item, Collection collection) //Passe la collection et l'item en parametre
        {
            collection.items.Add(item); //Ajoute l'item a la collection
            collection.taille++;
            return collection;
        }

        public Collection Supprimer(Item item, Collection collection) //Passe la collection et l'item en parametre
        {
            for (int i = 0; i<collection.taille; i++)
            {
                if (collection.Items.Contains(item)) //Si il est dans la collection
                    collection.items.Remove(item); //Enleve l'item de la collection
                else
                    Console.WriteLine("L'item n'est pas dans la collection /n");
            }
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

