using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Exceptions;


namespace TravailSession
{
    //Cette classe est terminer - Dave

    [Serializable]
    //Classe abstraite generique mere de Magasin et Inventaire
    public abstract class ItemCollection<T> : IEnumerable<T> where T : Item
    {
        protected List<T> items = new List<T>();

        public T Item(int index)
        {
            return items[index];
        }

        public abstract void Ajouter(T item);

        public void Supprimer(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items.Contains(item)) //Si il est dans la collection
                    items.Remove(item); //Enleve l'item de la collection
                else
                    Console.WriteLine("L'item n'est pas dans la collection /n");
            }
        }

        public void Clear()
        {
            items.Clear();
        }

        public int Count { get { return items.Count; } }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public void GetNomItem(int index)
        {
            Console.WriteLine(items[index].Nom);
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

