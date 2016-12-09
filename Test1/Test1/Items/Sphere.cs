using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession.Effets;

namespace TravailSession
{
    public class Sphere : Item
    {
        private Capture capture;

        public Sphere(string nom, String description, int Cout, Element type, List<Effet> effets) : base(nom, description, Cout, type, effets)
        {
            effets.Add(capture); //Ajoute l'effet capture a la liste des effets
        }

        //Ajoute un monstre au monstresCaptures
        public override void Utiliser(Joueur joueur, Monstre monstreACapturer)
        {
            Effets.Capture monstre = new Capture(joueur, monstreACapturer);
        }

    }
}
