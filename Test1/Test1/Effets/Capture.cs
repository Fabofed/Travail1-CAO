using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession.Effets
{
    public class Capture : Effet
    {
        private Joueur joueur;

        public override void Effectuer(Effet capture, Monstre monstre)
        {
            this.joueur.MonstresCaptures.Add(monstre); //Ajoute le monstre a la liste de monstres captures
        }
    }
}
