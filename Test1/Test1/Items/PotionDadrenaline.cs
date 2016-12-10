using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    class PotionDadrenaline : Item
    {
        private Collection collection;
        private Item item;
        private Joueur joueur;
        private Monstre monstre;

        public PotionDadrenaline(string nom, string description, int Cout, Element type, List<Effet> effets) : base(nom, description, Cout, type, effets)
        {
        }

        public override string Utiliser(Effet unEffet, Monstre cible, Monstre depart)
        {
            string resultat = "";
            bool utilisable = DeterminerUtilisable(depart.Type);

            if (utilisable == true)
            {
                resultat = "Vous consommez la potion.";
            }

            else
            {
                resultat = "Vous n'etes pas du bon type pour utiliser cette item.";
            }

            return resultat;
        }

        public override void Utiliser(Joueur joueur, Monstre monstre)
        {
            // Inserer un traitement ici
            joueur.Inventaire.Supprimer(this.item, this.collection); //Enleve l'item de l'inventaire
        }
    }
}
