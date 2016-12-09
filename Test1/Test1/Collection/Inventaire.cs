using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Exceptions;
using TravailSession.Interfaces;
using TravailSession.Items;

namespace TravailSession
{
    [Serializable]
    //Herite de la classe Collection
    class Inventaire : Collection, IPersistant
    {
        public Item Details { get; set; }
        public int Quantite { get; set; }

        public Inventaire (Item details, int quantite)
        {
            Details = details;
            Quantite = quantite;
        }


        //Ajoute une item a l'inventaire
        public Inventaire Ajouter(Item item, Inventaire inventaire, Joueur joueur)
        {
            if (item.Cout > joueur.Argent) //Si le joueur n'a pas assez d'argent
            {
                throw new ManqueDargent("Vous n'avez assez d'argent pour acheter l'item " + item.Nom);
            }
            else
            {
                inventaire.items.Add(item); //Ajoute l'item a la collection
                inventaire.taille++;
                return inventaire;
            }
        }

        public string SauvegardeXML(MonstreDescription monstre, ItemDescription item)
        {
            throw new NotImplementedException();
        }

        public string ChargerXML(MonstreDescription monstre, ItemDescription item)
        {
            throw new NotImplementedException();
        }
    }
}
