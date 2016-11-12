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
        private String nom;
        private Sexe sexe;
        private int age;
        private int argent;
        Inventaire inventaire = new Inventaire();
        Monstre monstre = new Monstre();
        static Monstre[] Equipe = new Monstre[5];
        static Monstre[] monstreCaptures = new Monstre[10];

        enum Sexe {homme, femme, autre}

        public Joueur()
        {

        }
    }
}
