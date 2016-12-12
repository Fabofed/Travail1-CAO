using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    //Cette classe est terminer - Dave

    class PotionDeForce : Item
    {
        private PotionDeVie potionDeForce;
        private Force force;
        private Joueur joueur;
        private Monstre cible;

        public PotionDeForce(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(force);
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
            if (this.joueur.Inventaire.Contains(this.potionDeForce)) //Si la potion est dans l'inventaire
            {
                force.Effectuer(this.cible); //Ajoute la force a la cible
                joueur.Inventaire.Supprimer(this.potionDeForce); //Enleve l'item de l'inventaire
                Console.WriteLine("Vous consommez votre potion. /nVous reprenez " + force.Magnitude + " points de force.");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de potion de force.");
            }
        }
    }
}
