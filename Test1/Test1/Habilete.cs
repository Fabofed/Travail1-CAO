using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
  
    enum CibleHabilete { Soi, Ennemi}

    enum EffetHabilete { Guerison, Degat, Regeneration, Sommeil, Paralysie, Force, Faiblesse} 

    public class Habilete
    {
        public string Nom { get; private set; }
        public string Description { get; private set; }
        public int Gain { get; private set; }
        public int Puissance { get; private set; }
       // public TypeElement element { get; private set; }


        public Habilete(string nom, string description, int gain, int puissance, /*TypeElement element = TypeElement.PretaAttaquer*/)
        {
            this.Nom = nom;
            this.Description = description;
            this.Gain = gain;
            this.Puissance = puissance;
            //this.Element = element;
        }

    }
}