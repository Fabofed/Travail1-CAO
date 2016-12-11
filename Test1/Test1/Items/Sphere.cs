using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Effets;

namespace TravailSession
{
    public class Sphere : Item
    {
        private Capture capture;

        public Sphere(int Id, string nom, string description, int Cout, int Quantite) : base()
        {
            this.Id = Id;
            this.Nom = nom;
            this.Description = description;
            this.Cout = Cout;
            this.Quantite = Quantite;
            Effets.Add(capture);
        }

        //Ajoute un monstre au monstresCaptures
        public override void Utiliser(Joueur joueur, Monstre monstreACapturer)
        {
            Effets.Capture monstre = new Capture(joueur, monstreACapturer);
        }

    }
}
