using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    enum TypeMonstre { Feu, Magma, Terre, Vegetation, Eau, Glace, Air, Electricite }

    class Monstre
    {
        private int id;
        private byte rarete;
        private byte experience;
        private int pointsExperience;
        private Caracteristiques caracteristiques;

        #region Propriétés (Acesseurs et Mutateurs)

        public int Id { get; set; }
        public string Nom { get; }
        public string Surnom { get; set; }
        public TypeMonstre Type { get; protected set; }
        public byte Rarete { get; set; }
        public byte Experience { get; protected set; }
        public int PointsExperience
        {
            get
            {
                return pointsExperience;
            }

            set
            {
                pointsExperience = value;
            }
        }




        #endregion

        public Monstre()
        {

        }
    }

    struct Caracteristiques
    {
        private int pointsDeVieDeBase;
        private int pointsDEnergie;
    }
}

