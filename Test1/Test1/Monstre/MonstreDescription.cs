using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravailSession;
using TravailSession.Interfaces;
using TravailSession.Items;

namespace TravailSession
{
    public enum TypeMonstre { Feu, Magma, Terre, Vegetation, Eau, Glace, Air, Electricite }

    public class MonstreDescription : IPersistant
    {
        static string confirmationSauvegarde = "Vous avez bien sauvegardee vos items.";
        static string confirmationChargement = "Vous avez bien sauvegardee vos items.";

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

        public string SauvegardeXML(Joueur joueur, MonstreDescription monstre, ItemDescription item, string endroit)
        {
            XmlSerializer formatJ = new XmlSerializer(typeof(Item));
            using (Stream stream = new FileStream(@endroit, FileMode.Create, FileAccess.Write, FileShare.None)) formatJ.Serialize(stream, joueur);

            XmlSerializer formatID = new XmlSerializer(typeof(Item));
            using (Stream stream = new FileStream(@endroit, FileMode.Create, FileAccess.Write, FileShare.None)) formatID.Serialize(stream, item);

            XmlSerializer formatMD = new XmlSerializer(typeof(Item));
            using (Stream stream = new FileStream(@endroit, FileMode.Create, FileAccess.Write, FileShare.None)) formatMD.Serialize(stream, monstre);


            return confirmationSauvegarde;
        }

        public string ChargerXML(Joueur joueur, MonstreDescription monstre, ItemDescription item, string endroit)
        {
            XmlSerializer formatJ = new XmlSerializer(typeof(Item));
            using (Stream streamJ = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) joueur = (ItemDescription)formatJ.Deserialize(streamJ);

            XmlSerializer formatID = new XmlSerializer(typeof(Item));
            using (Stream streamID = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) item = (ItemDescription)formatID.Deserialize(streamID);

            XmlSerializer formatMD = new XmlSerializer(typeof(Item));
            using (Stream streamMD = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) monstre = (MonstreDescription)formatMD.Deserialize(streamMD);

            return confirmationChargement;
        }
    }
}
