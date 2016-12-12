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
    //Cette classe est terminer - Dave

    [Serializable]
    public class Joueur : IPersistant
    {
        private string confirmationSauvegarde = "Vous avez bien sauvegardee vos items.";
        private string confirmationChargement = "Vous avez bien sauvegardee vos items.";
        private const int NiveauDepart = 1;
        private const int NiveauMax = 10;
        private const int ArgentDepart = 500;
        private const int ExperienceDepart = 0;

        private const int Niveau1 = 1000;
        private const int Niveau2 = 2500;
        private const int Niveau3 = 5000;
        private const int Niveau4 = 8000;
        private const int Niveau5 = 12000;
        private const int Niveau6 = 16500;
        private const int Niveau7 = 22000;
        private const int Niveau8 = 28000;
        private const int Niveau9 = 36000;
        private const int Niveau10 = 46000;

        public string Nom { get; set; }
        public int Niveau { get; set; }
        public int Experience { get; set; }

        public int Argent { get; set; }
        public Sexe Sex { get; set; }
        public int Age { get; set; }
        public Inventaire inventaire { get; set; }
        private List<Monstre> monstresCaptures = new List<Monstre>();
        private Equipe _equipe;

        public enum Sexe { homme, femme, autre }
        
        public Joueur(string nom, Sexe sexe, int age, Inventaire inventaire, List<Monstre> monstresCaptures, Equipe equipe)
        {
            this.Nom = nom;
            this.Argent = ArgentDepart;
            this.Niveau = NiveauDepart;
            this.Sex = sexe;
            this.Age = age;
            this.inventaire = inventaire;
            this.monstresCaptures = monstresCaptures;
            this._equipe = equipe;
        }

        //Verifie si lon doit monter de niveau
        public void VerifierMonterNiveau()
        {
            if (this.Experience < Niveau1)
            {
                Niveau = 1;
            }

            else if (this.Experience < Niveau2)
            {
                if (Niveau < 2)
                {
                    Niveau = 2;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 2;
            }

            else if (this.Experience < Niveau3)
            {
                if (Niveau < 3)
                {
                    Niveau = 3;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 3;
            }

            else if (this.Experience < Niveau4)
            {
                if (Niveau < 4)
                {
                    Niveau = 4;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 4;
            }

            else if (this.Experience < Niveau5)
            {
                if (Niveau < 5)
                {
                    Niveau = 5;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 5;
            }

            else if (this.Experience < Niveau6)
            {
                if (Niveau < 6)
                {
                    Niveau = 6;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 6;
            }

            else if (this.Experience < Niveau7)
            {
                if (Niveau < 7)
                {
                    Niveau = 7;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 7;
            }

            else if (this.Experience < Niveau8)
            {
                if (Niveau < 8)
                {
                    Niveau = 8;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 8;
            }

            else if (this.Experience < Niveau9)
            {
                if (Niveau < 9)
                {
                    Niveau = 9;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 9;
            }

            else if (this.Experience < Niveau10)
            {
                if (Niveau < 10)
                {
                    Niveau = 10;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + Niveau);
                }
                else
                    Niveau = 10;
            }

            else
                Console.WriteLine("Une erreur est survenu! Votre niveau est ambigue.");
        }

        //Ajoute de l'experience
        public void AjoutExperience(int xp)
        {
            this.Experience += xp;
        }

        public List<Monstre> MonstresCaptures
        {
            get { return this.monstresCaptures; }
        }

        public object Inventaire { get; internal set; }

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

        public override string ToString()
        {
            return "Nom: " + Nom + "/nNiveau: " + Niveau + "/nSexe: " + Sex + "/nArgent: " + Argent + "/nInventaire: " + inventaire + "/nMonstres Capturés: " + monstresCaptures + "/nEquipe: " + _equipe;
        }
    }
}
