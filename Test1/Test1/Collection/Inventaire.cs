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
    //Cette classe n'est pas terminer - Dave
    //Il reste a implementer la serialization.

    [Serializable]
    //Herite de la classe abstraite generique Collection. Represente l'inventaire du joueur
    public class Inventaire : ItemCollection<Item>, IPersistant
    {
        private Joueur joueur;

        public Item Details { get; set; }
        public int Quantite { get; set; }

        public Inventaire (Item details, int quantite)
        {
            Details = details;
            Quantite = quantite;
        }

        public override void Ajouter(Item item)
        {
            if (item.Cout > this.joueur.Argent) //Si le joueur n'a pas assez d'argent
            {
                throw new ManqueDargent();
            }
            else
            {
                this.joueur.Inventaire.items.Add(item); //Ajoute l'item a la collection
            }
        }    

        public string SauvegardeXML(Joueur joueur, MonstreDescription monstre, ItemDescription item, string endroit)
        {
            throw new NotImplementedException();

        }

        public string ChargerXML(Joueur joueur, MonstreDescription monstre, ItemDescription item, string endroit)
        {
            throw new NotImplementedException();
        }
    }
}
