using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession.Interfaces;

namespace TravailSession.Items
{
    class ItemDescription : IUtilisable, IPersistant
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Cout { get; set; }

        public override string ToString()
        {
            return "Nom: " + Nom + "Description: " + Description + "Cout: " + Cout;
        }

        public string Utiliser(Effet unEffet, Monstre cible)
        {
            throw new NotImplementedException();
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

