using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    class PotionDeVie : Item
    {
        private Collection collection;
        private Item item;
        private Joueur joueur;
        private Monstre monstre;

        public PotionDeVie(string nom, string description, int valeur, Element type, List<Effet> effets) : base(nom, description, valeur, type, effets)
        {
        }

        public override void Utiliser(Joueur joueur, Monstre monstre)
        {
            if (monstre.PtsVieActuels == monstre.PtsVieTotal) //Si les vies sont pleines
                Console.WriteLine("Vos vies sont pleine! Gardez votre potion");

            else
            {
                monstre.PtsVieActuels += this.Valeur; //Ajoute les vies de la potion au monstre
                joueur.Inventaire.Supprimer(this.item, this.collection); //Enleve l'item de l'inventaire
            }
        }
    }
}
