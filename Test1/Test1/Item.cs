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

    public class Item
    {
        #region propriete
        public String Nom { get; set; }
        public String Description { get; set; }
        public int Valeur { get; set; }
        public int DegatsMax { get; set; }
        public int DegatsMin { get; set; }
        public Element Type { get; set; }
        public List<Effet> etat { get; set; }
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
        public Item (string nom, String description, int valeur, int DegatsMax, int DegatsMin, Element type, List<Effet> etat)
        {
            this.Nom = Nom;
            this.Description = Description;
            this.Valeur = Valeur;
            this.DegatsMax = DegatsMax;
            this.DegatsMin = DegatsMin;
            this.Type = type;
            this.etat = etat;
            etat = new List<Effet>();
        }
        #endregion
    }
}