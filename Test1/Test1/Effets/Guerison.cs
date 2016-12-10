using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession.Items;

namespace TravailSession
{
    class Guerison : Effet
    {
        public override void Effectuer(Effet guerir, Monstre cible)
        {
            {
                if (cible.PtsVieActuels == cible.PtsVieTotal) //Si les vies sont pleines
                    Console.WriteLine("Vos vies sont deja pleine!");

                else
                {
                    cible.PtsVieActuels = cible.PtsVieActuels + guerir.Magnitude; //Ajoute les vies  au monstre

                    if (cible.PtsVieActuels > cible.PtsVieTotal)
                        cible.PtsVieActuels = cible.PtsVieTotal; //Si les vies depasserais les vies permise, ont les met au max
                }
            }
        }
    }
}

