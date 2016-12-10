using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Exceptions;


namespace TravailSession
{
    //Classe mere de Magasin et Inventaire
    public abstract class Collection
    {
        protected List<Item> items { get; set; }
        protected int taille { get; set; }


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
        public virtual void Ajouter(Item item) //Passe la collection et l'item en parametre
        {
            items.Add(item); //Ajoute l'item a la collection
            taille++;
        }

        public void Supprimer(Item item)
        {
            for (int i = 0; i<taille; i++)
            {
                if (Items.Contains(item)) //Si il est dans la collection
                    items.Remove(item); //Enleve l'item de la collection
                else
                    Console.WriteLine("L'item n'est pas dans la collection /n");
            }
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

