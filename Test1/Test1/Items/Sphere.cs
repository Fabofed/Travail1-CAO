using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Effets;

namespace TravailSession
{
    //Cette classe est terminer - Dave

    public class Sphere : Item
    {
        private Sphere sphere;
        private Capture capture;
        private Joueur joueur;
        private Monstre cible;

        public Sphere(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(capture);
        }

        public override int Cout
        {
            get { return Cout; }
            set{ this.Cout = value; } 
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
            if (this.joueur.Inventaire.Contains(this.sphere)) //Si le sphere est dans l'inventaire
            {
                capture.Effectuer(this.cible); //Capture la cible
                joueur.Inventaire.Supprimer(this.sphere); //Enleve l'item de l'inventaire
                Console.WriteLine("Vous capturez " + capture.Cible + ". /nIl fait desormais partie de vos monstres captures.");
            }
            else
            {
                Console.WriteLine("Vous n'avez pas de sphere dans votre inventaire.");
            }
        }
    }
}
