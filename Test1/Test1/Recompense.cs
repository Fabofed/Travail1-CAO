using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TravailSession;
namespace TravailSession
{
    class Recompense
    {
        private DifficulteCombat Difficulte { get; set; }
        private int RecompensePts { get; set; }
        private int RecompenseArgent { get; set; }
        private Equipe EquipeEnnemi;
        private Joueur CeJoueur;

        public enum DifficulteCombat
        {
            tresFacile = 0, facile = 1, moyen = 2, difficile = 3, tresDifficile = 4
        };


        public Recompense(DifficulteCombat difficulte, int recompensePts, int recompenseArgent)
        {
            this.Difficulte = difficulte;
            this.RecompensePts = recompensePts;
            this.RecompenseArgent = recompenseArgent;
        }

        public Equipe Joueur
        {
            get
            {
                return CeJoueur.Equipe;
            }
        }


        public Equipe Ennemi
        {
            get
            {
                return EquipeEnnemi;
            }
        }

        public DifficulteCombat LaDifficulte
        {
            get
            {
                return Recompense;
            }
        }


        //Methode qui recoit une difficulte et genere une equipe avec les recompenses correspondantes
        //switch sur difficulte combat deja fournit plus haut
        public Equipe GenererEquipe(/*int difficulte*/)
        {
           
        
        }
    }
}

