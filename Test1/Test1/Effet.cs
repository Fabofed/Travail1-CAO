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
        private Monstre cible { get; set; }
        private Monstre depart { get; set; }
        private int magnitude { get; set; }
        private int duree { get; set; }

        public Effet()
        {

        }

        public void Effectuer()
        {

        }
    }
}
