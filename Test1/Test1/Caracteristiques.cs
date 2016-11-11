using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    struct Caracteristiques
    {

        private int ptsVieBase;
        private int ptsEnergieBase;
        private int ptsVieActuels;
        private int ptsEnergieActuels;
        private int progression;
        private int ptsVieTotal;
        private int ptsEnergieTotal;

        #region Constructeurs

        public Caracteristiques(int ptsVieBase , int ptsEnergieBase) : this()
        {
            this.PtsVieBase = ptsVieBase;
            this.PtsVieActuels = ptsVieBase;
            this.PtsVieTotal = ptsVieBase;
            this.PtsEnergieBase = ptsEnergieBase;
            this.ptsEnergieActuels = ptsEnergieBase;
            this.ptsEnergieTotal = ptsEnergieBase; 
        }

        #endregion


        #region Propriétés

        public int PtsVieBase
        {
            get { return ptsVieBase; }
            set { this.ptsVieBase = value; } 
        }

        public int PtsVieActuels
        {
            get
            {
                return ptsVieActuels;
            }

            set
            {
                this.ptsVieActuels = value;
            }
        }

        public int PtsVieTotal
        {
            get { return ptsVieTotal; }
            set { this.ptsVieTotal = value; }
        }

        public int PtsEnergieBase
        {
            get { return ptsEnergieBase; }
            set { this.ptsEnergieBase = value; }
        }

        public int PtsEnergieActuels
        {
            get { return ptsEnergieActuels; }
            set { }
        }

        public int PtsEnergieTotal
        {
            get { return ptsEnergieTotal; }
            set { }
        }


        public int Attaque
        {
            get;
            private set; // On laisse la place à un eventuelle évolution du monstre
        }

        public int Defense
        {
            get;
            private set;
        }

        public int Progression
        {
            get;
            private set;
        }


        #endregion

        public static int GenererValeur()
        {
            Random generateur = new Random();
            return generateur.Next(10, 481); // Génère un entier compris dans la plage [10, 480]
        }
    }

}
