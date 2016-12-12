using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TravailSession;
namespace TravailSession
{
    //Cette classe est terminer - Dave

    public class Recompense
    {
        public DifficulteCombat Difficulte { get; set; }
        public int RecompensePts { get; set; }
        public int RecompenseArgent { get; set; }

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

        //Methode qui recoit une difficulte et genere une recompense avec les recompenses correspondantes
        public Recompense GenererEquipe(Recompense.DifficulteCombat difficulte)
        {
            Recompense recompenseDuMatch = new Recompense(difficulte, 0, 0);

            switch (difficulte)
            {
                case 0:
                    recompenseDuMatch.RecompenseArgent = 50;
                    recompenseDuMatch.RecompensePts = 500;
                    break;

                case (DifficulteCombat)1:
                    recompenseDuMatch.RecompenseArgent = 100;
                    recompenseDuMatch.RecompensePts = 1000;
                    break;

                case (DifficulteCombat)2:
                    recompenseDuMatch.RecompenseArgent = 200;
                    recompenseDuMatch.RecompensePts = 2000;
                    break;

                case (DifficulteCombat)3:
                    recompenseDuMatch.RecompenseArgent = 500;
                    recompenseDuMatch.RecompensePts = 4000;
                    break;

                case (DifficulteCombat)4:
                    recompenseDuMatch.RecompenseArgent = 1000;
                    recompenseDuMatch.RecompensePts = 7000;
                    break;
            }

            return recompenseDuMatch;
        }
    }
}

