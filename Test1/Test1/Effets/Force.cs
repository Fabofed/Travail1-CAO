using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Force : Effet
    {
        private Monstre monstre;

        public override void Effectuer(Effet effet, Monstre monstre)
        {
            this.monstre.CaracteristiquesMonstre.Attaque = 1.25; //Augmente l'attaque du monstre
        }
    }
}
