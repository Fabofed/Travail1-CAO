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
        public Monstre Cible { get; set; }
        public Monstre Depart { get; set; }
        public int Magnitude { get; set; }
        public int Duree { get; set; }

        public abstract void Effectuer(Effet effet, Monstre monstre);
    }
}
