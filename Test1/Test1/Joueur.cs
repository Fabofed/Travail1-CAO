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
        // Constantes représentant les caractériqtiques de départ du joueur.
        private const int NIVEAU_DEPART = 1;
        private const int ARGENT_DEPART = 1000;
        
        private string nom { get; set; }
        private int argent { get; set; }
        private Inventaire inventaire { get; set; }
        private List<Monstre> monstresCaptures = new List<Monstre>();
        private Equipe joueur = new Equipe();

        //  monstresCaptures.Add(new Monstre() {nom="Charmander"..... ETC. });

        #region Constructeurs
        public Joueur()
        {

        }
        public Joueur(string nom, Inventaire inventaire, List<Monstre> monstresCaptures, Equipe joueur)
        {
            this.nom = nom;
            this.argent = ARGENT_DEPART;
            this.inventaire = inventaire;
            this.monstresCaptures = monstresCaptures;
            this.joueur = joueur;
        }
        #endregion
        public override string ToString()
        {
            return "Nom: " + nom + "/nArgent: " + argent + "/nInventaire: " + inventaire + "/nMonstres Capturés: " + monstresCaptures + "/nEquipe: " + joueur;
        }

    }
}
