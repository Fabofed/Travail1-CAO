using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Degat : Effet
    {
        protected int degatsMax { get; set; }
        protected int degatsMin { get; set; }

        public override void Effectuer(Effet degat, Monstre cible)
        {
            cible.PtsVieActuels = cible.PtsVieActuels - degat.Magnitude; //Enleve les vies  au monstre
            if (cible.PtsVieActuels<0)
            {
                cible.Etats.Clear(); //Enleve tout les EtatActif
                cible.Etats.Add(EtatActif.Mort); //Indique que le monstre est mort
            }
        }
    }
}
