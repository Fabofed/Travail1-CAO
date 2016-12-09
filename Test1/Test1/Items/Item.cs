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
        
        //Enregistrer un item sur XML
        public static void Enregistrer(Item item, string endroit)
        {
            XmlSerializer format = new XmlSerializer(typeof(Item));
            using (Stream stream = new FileStream(@endroit, FileMode.Create, FileAccess.Write, FileShare.None)) format.Serialize(stream, item);
        }

        //Charger un item de XML
        public static Item Charger(string endroit)
        {
            Item item;
            XmlSerializer format = new XmlSerializer(typeof(Item));
            using (Stream stream = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) item = (Item)format.Deserialize(stream);
            return item;
        }

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