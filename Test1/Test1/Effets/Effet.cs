using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    //Cette classe est terminer - Dave

    public abstract class Effet
    {
        public abstract Monstre Cible { get; set; }
        public abstract int Magnitude { get; set; }
        public abstract int Duree { get; set; }

        public abstract void Effectuer(Monstre cible);
    }
}
