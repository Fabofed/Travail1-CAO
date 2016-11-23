using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Joueur
    {
        //mettre en majuscule
        protected string Nom { get; set; }
        protected int Argent { get; set; }
        protected Inventaire inventaire { get; set; }
        protected List<Monstre> monstresCaptures = new List<Monstre>();
        protected Equipe joueur = new Equipe();

        //  monstresCaptures.Add(new Monstre() {nom="Charmander"..... ETC. });

        public string Nom  
        {
            get
            {
                return nom;
            }
        }

        public int Argent
        {
            get
            {
                return argent;
            }
        }

        public Equipe Equipe
        {
            get
            {
                return joueur;
            }
        }

        public Joueur(string nom, int argent, Inventaire inventaire, List<Monstre> monstresCaptures, Equipe joueur)
        {
            this.nom = nom;
            this.argent = argent;
            this.inventaire = inventaire;
            this.monstresCaptures = monstresCaptures;
            this.joueur = joueur;
        }

        public override string ToString()
        {
            return "Nom: " + nom + "/nArgent: " + argent + "/nInventaire: " + inventaire + "/nMonstres Capturés: " + monstresCaptures + "/nEquipe: " + joueur;
        }

    }
}
