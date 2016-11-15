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
        private string nom { get; set; }
        private int argent { get; set; }
        private Inventaire inventaire { get; set; }
        private List<Monstre> monstresCaptures = new List<Monstre>();
        private Equipe joueur = new Equipe();

        //  monstresCaptures.Add(new Monstre() {nom="Charmander"..... ETC. });


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
