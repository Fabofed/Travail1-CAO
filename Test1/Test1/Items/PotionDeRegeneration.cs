using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    //Cette classe est terminer - Dave

    class PotionDeRegeneration : Item
    {
        private PotionDeRegeneration potionDeRegeneration;
        private Regeneration regeneration;
        private Joueur joueur;
        private Monstre cible;

        public PotionDeRegeneration(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(regeneration);
        }

        public override int Cout
        {
            get { return Cout; }
            set { this.Cout = value; }
        }

        public override string Description
        {
            get { return Description; }
            set { this.Description = value; }
        }

        public override List<Effet> Effets
        {
            get { return Effets; }
            set { this.Effets = value; }
        }

        public override int Id
        {
            get { return Id; }
            set { this.Id = value; }
        }

        public override string Nom
        {
            get { return Nom; }
            set { this.Nom = value; }
        }

        public override int Quantite
        {
            get { return Quantite; }
            set { this.Quantite = value; }
        }

        public override void Utiliser()
        {
            if (this.joueur.Inventaire.Contains(this.potionDeRegeneration)) //Si la potion est dans l'inventaire
            {
                regeneration.Effectuer(this.cible); //Gueri la cible
                joueur.Inventaire.Supprimer(this.potionDeRegeneration); //Enleve l'item de l'inventaire
                Console.WriteLine("Vous consommez votre potion. /nVous avez regenere " + regeneration.Magnitude + " points d'energie.");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de potion de regeneration.");
            }
        }
    }
}
