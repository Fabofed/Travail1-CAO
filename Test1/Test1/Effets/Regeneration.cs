using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Regeneration : Effet
    {
        private Monstre monstre;

        public override Monstre Cible
        {
            get { return Cible; }
            set { this.Cible = value; }
        }

        public override int Duree
        {
            get { return Duree; }
            set { this.Duree = value; }
        }

        public override int Magnitude
        {
            get { return Magnitude; }
            set { this.Magnitude = value; }
        }

        public override void Effectuer(Monstre monstre)
        {
            this.monstre.CaracteristiquesMonstre.PtsEnergieActuels = this.monstre.CaracteristiquesMonstre.PtsEnergieActuels * 
                ((this.monstre.CaracteristiquesMonstre.PtsEnergieTotal)/2); //Regenere 1/2 de lenergie total du monstre
        }
    }
}
