using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession
{
    class Difficulte
    {
        private DifficulteCombat difficulte;
        private int recompensePts { get; set; }


        #region Proprietes

        public enum DifficulteCombat
        {
            tresFacile = 0, facile = 1, moyen = 2, difficile = 3, tresDifficile = 4
        };

        public int RecompensePts
        {
            get { return recompensePts; }
            set { this.recompensePts = value; }
        }

        #endregion

        #region Constructeurs

        public Difficulte(DifficulteCombat difficulte, int recompensePts)
        {

            this.difficulte = difficulte;
            this.recompensePts = recompensePts;
        }

        #endregion

        #region Methodes

        public Equipe TresFacile()
        {
            private Equipe ennemi;

        Difficulte tresFacile = new Difficulte(0, 1000);

        ennemi = ennemi.ChoisirMonstres(0); //methode qui va choisirs une liste de monstres

            return ennemi;
        }


    public Equipe Facile()
    {
            private Equipe ennemi;

    Difficulte facile = new Difficulte(1, 3000);

    ennemi = ennemi.ChoisirMonstres(1); //methode qui va choisirs une liste de monstres

            return ennemi;
        }


public Equipe Moyen()
{
            private Equipe ennemi;

Difficulte moyen = new Difficulte(2, 10000);

ennemi = ennemi.ChoisirMonstres(2); //methode qui va choisirs une liste de monstres

            return ennemi;
        }


            public Equipe Difficile()
{
            private Equipe ennemi;

Difficulte difficile = new Difficulte(3, 40000);

ennemi = ennemi.ChoisirMonstres(3); //methode qui va choisirs une liste de monstres

            return ennemi;
        }


            public Equipe TresDifficile()
{
            private Equipe ennemi;

Difficulte tresDifficile = new Difficulte(4, 100000);

ennemi = ennemi.ChoisirMonstres(4); //methode qui va choisirs une liste de monstres

            return ennemi;
        }
    
    #endregion

}
}
