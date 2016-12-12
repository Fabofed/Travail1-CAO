using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TravailSession.Interfaces;

namespace TravailSession.Items
{
    //Cette classe est terminer - Dave

    [Serializable]
    public abstract class ItemDescription : IPersistant
    {
        static string confirmationSauvegarde = "Vous avez bien sauvegardee vos items.";
        static string confirmationChargement = "Vous avez bien sauvegardee vos items.";

        public abstract int Id { get; set; }

        public abstract string Nom { get; set; }

        public abstract string Description { get; set; }

        public abstract int Cout { get; set; }

        public abstract List<Effet> Effets { get; set; }

        //Si on a le temps on pourrait implementer que certaine potion soit utilisable juste pour certain type de monstre.
        /*
        public bool UtilisableFeu { get; set; }

        public bool UtilisableMagma { get; set; }

        public bool UtilisableTerre { get; set; }

        public bool UtilisableVegetation { get; set; }

        public bool UtilisableEau { get; set; }

        public bool UtilisableGlace { get; set; }

        public bool UtilisableAir { get; set; }

        public bool UtilisableElectricite { get; set; }


        //Determine quel type de monstre peut utiliser l'item
        protected void DeterminerUtilisable(Element.Elements Type)
        {
            UtilisableFeu = false;
            UtilisableMagma = false;
            UtilisableTerre = false;
            UtilisableVegetation = false;
            UtilisableEau = false;
            UtilisableGlace = false;
            UtilisableAir = false;
            UtilisableElectricite = false;

            switch (Type)
            {
                case Element.Elements.Air:
                    UtilisableAir = true;
                    break;

                case Element.Elements.Eau:
                    UtilisableEau = true;
                    break;

                case Element.Elements.Electricite:
                    UtilisableElectricite = true;
                    break;

                case Element.Elements.Feu:
                    UtilisableFeu = true;
                    break;

                case Element.Elements.Glace:
                    UtilisableGlace = true;
                    break;

                case Element.Elements.Magma:
                    UtilisableMagma = true;
                    break;

                case Element.Elements.Vegetation:
                    UtilisableVegetation = true;
                    break;

                case Element.Elements.Terre:
                    UtilisableTerre = true;
                    break;

                default:
                    break;
            }
        }*/

        public abstract void Utiliser();


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
            using (Stream streamJ = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) joueur = (Joueur)formatJ.Deserialize(streamJ);

            XmlSerializer formatID = new XmlSerializer(typeof(Item));
            using (Stream streamID = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) item = (ItemDescription)formatID.Deserialize(streamID);

            XmlSerializer formatMD = new XmlSerializer(typeof(Item));
            using (Stream streamMD = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) monstre = (MonstreDescription)formatMD.Deserialize(streamMD);

            return confirmationChargement;
        }
    }
}


