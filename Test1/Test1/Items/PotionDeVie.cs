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
        private Guerison guerison;

        public PotionDeVie(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(guerison);
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
