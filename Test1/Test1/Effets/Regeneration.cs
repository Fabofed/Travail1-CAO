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

        public override void Effectuer(Effet effet, Monstre monstre)
        {
            this.monstre.CaracteristiquesMonstre.PtsEnergieActuels = this.monstre.CaracteristiquesMonstre.PtsEnergieActuels * 1.25; //Regenere 1/4 de lenergie du monstre
        }
    }
}
