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
            this.joueur.MonstresCaptures.Add(monstre); //Ajoute le monstre a la liste de monstres captures
        }
    }
}
