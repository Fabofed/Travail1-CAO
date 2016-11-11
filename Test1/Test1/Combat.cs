using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Combat
    {
        public Difficulte difficulte;
        private Equipe joueur;
        private Equipe ennemi;


        #region Constructeurs

        public Combat(Equipe joueur, Equipe ennemi, Difficulte difficulte) 
        {
            this.joueur = joueur;
            this.ennemi = ennemi;
            this.difficulte = difficulte;
        }

        #endregion


        #region Propriétés

        public Equipe Joueur
        {
            get
            {
                return joueur;
            }

            set { }
        }

        public Equipe Ennemi
        {
            get
            {
                return ennemi;
            }

            set { }

        }
        public Difficulte Difficulte
        {
            get
            {
                return difficulte;
            }

            set { }
        }

        #endregion

    }
}
