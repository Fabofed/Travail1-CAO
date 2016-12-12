using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Force : Effet
    {
        private Guerison guerison;

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

        public override void Effectuer(Monstre cible)
        {
            cible.CaracteristiquesMonstre.Attaque = 1.25; //Augmente l'attaque du monstre

            if (cible.PtsVieActuels == cible.PtsVieTotal) //Si les vies sont pleines
                Console.WriteLine("Vos vies sont deja pleine!");
            else
            {
                cible.PtsVieActuels = cible.PtsVieActuels + guerison.Magnitude; //Ajoute les vies  au monstre

                if (cible.PtsVieActuels > cible.CaracteristiquesMonstre.PtsVieMax)
                    cible.PtsVieActuels = cible.CaracteristiquesMonstre.PtsVieMax; //Si les vies depasserais les vies permise, ont les met au max
            }
    }
}
