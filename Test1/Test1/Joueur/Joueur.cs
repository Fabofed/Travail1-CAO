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
    public class Joueur : IPersistant
    {
        private string confirmationSauvegarde = "Vous avez bien sauvegardee vos items.";
        private string confirmationChargement = "Vous avez bien sauvegardee vos items.";
        private const int NIVEAU_DEPART = 1;
        private const int ARGENT_DEPART = 1000;

        private string nom { get; set; }
        private int argent { get; set; }
        private Sexe sexe { get; set; }
        private int age { get; set; }
        public Inventaire Inventaire { get; set; }
        private List<Monstre> monstresCaptures = new List<Monstre>();
        public Equipe Equipe = new Equipe();

        //  monstresCaptures.Add(new Monstre() {nom="Charmander"..... ETC. });

        public enum Sexe { homme, femme, autre }


        public Joueur(string nom, int argent, Sexe sexe, int age, Inventaire Inventaire, List<Monstre> monstresCaptures, Equipe Equipe)
        {
            this.nom = nom;
            this.argent = ARGENT_DEPART;
            this.sexe = sexe;
            this.age = age;
            this.Inventaire = Inventaire;
            this.monstresCaptures = monstresCaptures;
            this.Equipe = Equipe;
        }

        public List<Monstre> MonstresCaptures
        {
            get
            {
                return this.monstresCaptures;
            }
        }

        public int Argent
        {
            get
            {
                return this.argent;
            }
            set
            {
                this.argent = value;
            }
        }

        public override string ToString()
        {
            return "Nom: " + nom + "/nArgent: " + argent + "/nInventaire: " + Inventaire + "/nMonstres Capturés: " + monstresCaptures + "/nEquipe: " + Equipe;
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
            using (Stream streamJ = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) joueur = (Joueur)formatJ.Deserialize(streamJ);

            XmlSerializer formatID = new XmlSerializer(typeof(Item));
            using (Stream streamID = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) item = (ItemDescription)formatID.Deserialize(streamID);

            XmlSerializer formatMD = new XmlSerializer(typeof(Item));
            using (Stream streamMD = new FileStream(@endroit, FileMode.Open, FileAccess.Read, FileShare.None)) monstre = (MonstreDescription)formatMD.Deserialize(streamMD);

            return confirmationChargement;
        }
    }
}
