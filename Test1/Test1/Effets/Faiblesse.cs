using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Faiblesse : Effet
    {
        private Monstre monstre;

        public override void Effectuer(Effet effet, Monstre monstre)
        {
            this.monstre.CaracteristiquesMonstre.Defense = 0.75 ; //Reduit la defense du monstre
        }
    }
}
