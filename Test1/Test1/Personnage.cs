using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Personnage : Joueur
    {
        private Sexe sexe { get; set; }
        private int age { get; set; }

        public enum Sexe { homme, femme, autre }

        public Personnage(Sexe sexe, int age) : base(nom, argent, inventaire, monstresCaptures, equipe)
        {
            this.sexe = sexe;
            this.age = age;
        }
    }
}
