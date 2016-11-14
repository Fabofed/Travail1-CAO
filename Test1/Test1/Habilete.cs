using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    enum TypeElement
    {
        cible,
        effet,
        magnitude,
        duree,
    }

    public class Habilete
    {
        public string nom { get; private set; }
        public string description { get; private set; }
        public int gain { get; private set; }
        public int puissance { get; private set; }
        public TypeElement element { get; private set; }


        public Habilete(string nom, string description, int gain, int puissance, TypeElement Element = TypeElement.PretAAttaquer)
        {
            this.nom = nom;
            this.description = description;
            this.gain = this.gain;
            this.puissance = puissance;
            this.Element = element;
        }

    }
}