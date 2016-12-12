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
    //Cette classe n'est pas terminer - Dave
    //Il reste a implementer la serialization en XML

    [Serializable]

    public enum TypeMonstre { Feu, Magma, Terre, Vegetation, Eau, Glace, Air, Electricite }

    public class MonstreDescription : IPersistant
    {
        static string confirmationSauvegarde = "Vous avez bien sauvegardee vos items.";
        static string confirmationChargement = "Vous avez bien sauvegardee vos items.";

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public int PtsVieBase { get; set; }

        public int PtsVieMax { get; set; }

        public int PtsEnergieBase { get; set; }

        public int PtsEnergieMax { get; set; }

        public List<Habilete> habiletesPotentielles { get; set; }

        public TypeMonstre TypeDelement { get; set; }

        public int NiveauDeBase { get; set; }

        public int Rarete { get; set; } // plus bas = plus rare (1 a 100)

        public MonstreDescription()
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Description = Description;
            this.PtsVieBase = PtsVieBase;
            this.PtsVieMax = PtsVieMax;
            this.PtsEnergieBase = PtsEnergieBase;
            this.PtsEnergieMax = PtsEnergieMax;
            this.habiletesPotentielles = habiletesPotentielles;
            this.TypeDelement = TypeDelement;
            this.NiveauDeBase = 1;
            this.Rarete = Rarete;
        }

        public MonstreDescription(int Id, string Nom, string Description, int PtsVieBase, int PtsVieMax, int PtsEnergieBase, 
            int PtsEnergieMax, List<Habilete> habiletesPotentielles, TypeMonstre TypeDelement, int Rarete)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Description = Description;
            this.PtsVieBase = PtsVieBase;
            this.PtsVieMax = PtsVieMax;
            this.PtsEnergieBase = PtsEnergieBase;
            this.PtsEnergieMax = PtsEnergieMax;
            this.habiletesPotentielles = habiletesPotentielles;
            this.TypeDelement = TypeDelement;
            this.NiveauDeBase = 1;
            this.Rarete = Rarete;
        }

        public override string ToString()
        {
            return "ID: " + Id + "/nNom: " + Nom + "/nDescription: " + Description + "/nPoints de vie de base: " + PtsVieBase 
                + "/nPoints de vies maximales: " + PtsVieMax + "/nPoints d'energie de base: " + PtsEnergieBase + 
                "/nPoints d'enerige maximales: " + PtsEnergieMax + "/nHabiletes potentielles: " + habiletesPotentielles
                 + "/Type d'element: " + TypeDelement + "/Niveau de base: " + NiveauDeBase + "/Rarete: " + Rarete;
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
