using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Joueur
    {
        public String nom;
        public int argent;
        Inventaire inventaire = new Inventaire();
        Monstre monstre = new Monstre();
        static Monstre[] Equipe = new Monstre[5];
        static Monstre[] monstreCaptures = new Monstre[10];

    }
}
