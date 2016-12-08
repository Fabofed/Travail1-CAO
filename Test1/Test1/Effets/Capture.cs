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
        private Monstre monstreACapturer;

        public Capture(Joueur joueur, Monstre monstreACapturer)
        {
            this.joueur = joueur;
            this.monstreACapturer = monstreACapturer;
        }

        public override void Effectuer(Joueur joueur, Monstre monstre)
        {
            joueur.MonstresCaptures.Add(monstreACapturer); //Ajoute le monstre a la liste de monstres captures
        }
    }
}
