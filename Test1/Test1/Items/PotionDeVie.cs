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
        private Item potionDeVie;

        public PotionDeVie(string nom, string description, int Cout, Element type, List<Effet> effets) : base(nom, description, Cout, type, effets)
        {
        }

        public override string Utiliser(Effet guerir, Monstre cible, Monstre depart, Joueur joueur)
        {
            string resultat = "";

            bool utilisable = DeterminerUtilisable(depart.Type);

            if (utilisable == true)
            {

                if (joueur.Inventaire.Items.Contains(this.potionDeVie)) //Si la potion est dans l'inventaire
                {
                    guerir.Effectuer(guerir, cible); //Gueri la cible
                    joueur.Inventaire.Supprimer(this.potionDeVie); //Enleve l'item de l'inventaire
                    resultat = "Vous avez ete gueri de " + guerir.Magnitude + " points.";
                    return resultat;
                }

                else
                {
                    resultat = "Vous n'avez pas de potion de vie.";
                    return resultat;
                }
            }

            else
            {
                resultat = "Votre type ne vous permet pas d'utilise cette potion de vie.";
                return resultat;
            }
        }
    }
}
