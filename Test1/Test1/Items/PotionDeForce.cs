using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    class PotionDeForce : Item
    {
        private ItemCollection collection;
        private Item item;
        private Joueur joueur;
        private Monstre monstre;
        private Force force;


        public override string Utiliser
        {
            get
            {
                // Inserer un traitement ici
                joueur.Inventaire.Supprimer(this.item, this.collection); //Enleve l'item de l'inventaire            }
            }
        }

        public PotionDeForce(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(force);
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
    }
}
