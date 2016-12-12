using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    public abstract class Effet
    {
        //Cette classe est terminer - Dave

        public abstract Monstre Cible { get; set; }
        public Monstre Depart { get; set; }
        public abstract int Magnitude { get; set; }
        public abstract int Duree { get; set; }

        public abstract void Effectuer(Monstre monstre);
    }
}
