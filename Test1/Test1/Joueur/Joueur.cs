using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    public class Joueur
    {
        // Constantes représentant les caractéristiques de départ du joueur.
        private const int NIVEAU_DEPART = 1;
        private const int ARGENT_DEPART = 1000;

        private string nom { get; set; }
        private int argent { get; set; }
        public Inventaire Inventaire { get; set; }
        private List<Monstre> monstresCaptures = new List<Monstre>();
        public Equipe Equipe = new Equipe();

        //  monstresCaptures.Add(new Monstre() {nom="Charmander"..... ETC. });


        public Joueur(string nom, int argent, Inventaire Inventaire, List<Monstre> monstresCaptures, Equipe Equipe)
        {
            this.nom = nom;
            this.argent = ARGENT_DEPART;
            this.Inventaire = Inventaire;
            this.monstresCaptures = monstresCaptures;
            this.Equipe = Equipe;
        }

        public List<Monstre> MonstresCaptures
        {
            get
            {
                return this.monstresCaptures;
            }
        }

        public int Argent
        {
            get
            {
                return this.argent;
            }
            set
            {
                this.argent = value;
            }
        }

        public override string ToString()
        {
            return "Nom: " + nom + "/nArgent: " + argent + "/nInventaire: " + Inventaire + "/nMonstres Capturés: " + monstresCaptures + "/nEquipe: " + Equipe;
        }

    }
}
