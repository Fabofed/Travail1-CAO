using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.Xml.Serialization;
using System.IO;


namespace TravailSession
{
    [Serializable]

    public abstract class Item
    {
        #region propriete
        public abstract void Utiliser(Joueur joueur, Monstre monstre);

        protected Element type { get; set; }
        protected List<Effet> effets { get; set; }
        #endregion
      
        #region constructeur
        public Item (string nom, String description, int Cout, Element type, List<Effet> effets)
        {
            this.type = type;
            effets = new List<Effet>();
            this.effets = effets;
        }
        #endregion
    }
}