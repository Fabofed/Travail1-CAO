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
        private Equipe equipeEnnemi;
        private Joueur LeJoueur;

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


        public Equipe EquipeJoueur
        {
            get
            {
                return LeJoueur.Equipe;
            }
        }


        public Equipe EquipeEnnemi
        {
            get
            {
                return equipeEnnemi;
            }
        }


        public DifficulteCombat LaDifficulte
        {
            get
            {
                return Difficulte;
            }
        }


        //Methode qui recoit une difficulte et genere une recompense avec les recompenses correspondantes
        public Recompense GenererEquipe(Recompense.DifficulteCombat Difficulte)
        {
            Recompense RecompenseDuMatch = new Recompense(Difficulte, 0, 0);

            switch (Difficulte)
            {
                case 0:
                    RecompenseDuMatch.RecompenseArgent = 1000;
                    RecompenseDuMatch.RecompensePts = 1000;
                    break;

                case (DifficulteCombat)1:
                    RecompenseDuMatch.RecompenseArgent = 2000;
                    RecompenseDuMatch.RecompensePts = 2000;
                    break;

                case (DifficulteCombat)2:
                    RecompenseDuMatch.RecompenseArgent = 3000;
                    RecompenseDuMatch.RecompensePts = 3000;
                    break;

                case (DifficulteCombat)3:
                    RecompenseDuMatch.RecompenseArgent = 4000;
                    RecompenseDuMatch.RecompensePts = 4000;
                    break;

                case (DifficulteCombat)4:
                    RecompenseDuMatch.RecompenseArgent = 5000;
                    RecompenseDuMatch.RecompensePts = 5000;
                    break;
            }

            return RecompenseDuMatch;
        }
    }
}

