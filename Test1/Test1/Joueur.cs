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
        private String nom { get; set; }
        private Sexe sexe { get; set; }
        private int age { get; set; }
        private int argent { get; set; }
        Inventaire inventaire = new Inventaire();
        Monstre monstre = new Monstre();
        static Monstre[] Equipe = new Monstre[5];
        private List<Monstre> monstresCaptures { get; set; }

        enum Sexe {homme, femme, autre}

        public Joueur()
        {
            monstresCaptures = new List<Monstre>();
        }
    }
}
