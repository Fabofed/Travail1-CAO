using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Interfaces;
using TravailSession.Items;

namespace TravailSession
{
    public enum TypeMonstre { Feu, Magma, Terre, Vegetation, Eau, Glace, Air, Electricite }

    public class MonstreDescription : IPersistant
    {
        public string nom { get; set; }
        public TypeMonstre type { get; set; }
        public int NiveauDeBase { get; set; }
        public int Rarete { get; set; } // plus bas = plus rare (1 a 100)
        public Element Element { get; set; }
        private List<Habilete> habiletesPotentielles;
        private List<Habilete> habiletesActives;

        public override string ToString()
        {
            return "Description du monstre: " + nom;
        }

        public string SauvegardeXML(MonstreDescription monstre, ItemDescription item)
        {
            throw new NotImplementedException();
        }

        public string ChargerXML(MonstreDescription monstre, ItemDescription item)
        {
            throw new NotImplementedException();
        }
    }
}
