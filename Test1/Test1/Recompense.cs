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
        private DifficulteCombat difficulte { get; set; }
        private int recompensePts { get; set; }
        private int recompenseArgent { get; set; }
        private Equipe equipeEnnemi;
        private Joueur leJoueur;

        public enum DifficulteCombat
        {
            tresFacile = 0, facile = 1, moyen = 2, difficile = 3, tresDifficile = 4
        };


        public Recompense(DifficulteCombat difficulte, int recompensePts, int recompenseArgent)
        {
            this.difficulte = difficulte;
            this.recompensePts = recompensePts;
            this.recompenseArgent = recompenseArgent;
        }


        public Equipe EquipeJoueur
        {
            get
            {
                return this.leJoueur.Equipe;
            }
        }


        public Equipe EquipeEnnemi
        {
            get
            {
                return this.equipeEnnemi;
            }
        }


        public DifficulteCombat LaDifficulte
        {
            get
            {
                return this.difficulte;
            }
        }


        //Methode qui recoit une difficulte et genere une recompense avec les recompenses correspondantes
        public Recompense GenererEquipe(Recompense.DifficulteCombat difficulte)
        {
            Recompense recompenseDuMatch = new Recompense(difficulte, 0, 0);

            switch (difficulte)
            {
                case 0:
                    recompenseDuMatch.recompenseArgent = 1000;
                    recompenseDuMatch.recompensePts = 1000;
                    break;

                case (DifficulteCombat)1:
                    recompenseDuMatch.recompenseArgent = 2000;
                    recompenseDuMatch.recompensePts = 2000;
                    break;

                case (DifficulteCombat)2:
                    recompenseDuMatch.recompenseArgent = 3000;
                    recompenseDuMatch.recompensePts = 3000;
                    break;

                case (DifficulteCombat)3:
                    recompenseDuMatch.recompenseArgent = 4000;
                    recompenseDuMatch.recompensePts = 4000;
                    break;

                case (DifficulteCombat)4:
                    recompenseDuMatch.recompenseArgent = 5000;
                    recompenseDuMatch.recompensePts = 5000;
                    break;
            }

            return recompenseDuMatch;
        }
    }
}

