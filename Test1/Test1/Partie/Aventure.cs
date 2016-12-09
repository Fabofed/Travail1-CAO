using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using TravailSession.Exceptions;

namespace TravailSession
{
    [Serializable]
     class Aventure
    {
       // Habilete[] listeHabilete;
        public int IdAventure { get; set; }
        public string NomAventure { get; set; }
        public Joueur joueur;

        public Aventure(int IdAventure, string NomAventure)
        {
            this.IdAventure = IdAventure;
            this.NomAventure = NomAventure;
            joueur = new Joueur();
        }

        public void acheterSphere(int argentActuel)
        {
            joueur.Inventaire.Sphere += argentActuel;
            joueur.Argent = joueur.Argent - (100 * argentActuel);
        }

        public void acheterPotion(int potionDeVie, int potionDenergie, int potionAdrenaline)
        {
            if (potionDeVie > 0)
            {
                joueur.Inventaire.potionDeVie += potionDeVie;
                joueur.Argent = joueur.Argent - (200 * potionDeVie);
            }
            if (potionDenergie > 0)
            {
                joueur.Inventaire.potionDenergie += potionDenergie;
                joueur.Argent = joueur.Argent - (200 * potionDenergie);
            }
            if (potionAdrenaline > 0)
            {
                joueur.Inventaire.potionAdrenaline += potionAdrenaline;
                joueur.Argent = joueur.Argent - (200 * potionAdrenaline);
            }
        }
        public static void Sauvegarder_Aventure(Aventure aventure)
        {
            List<Object> save = new List<object>();
            save.Add(joueur.Joueur);
            save.Add(joueur.MonstresCaptures);
            save.Add(joueur.Inventaire);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("sauvegardePartie.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, save);
            stream.Close();

            Console.WriteLine("La partie a ete sauvegardee");
        }

        public void ChargerAventure()
        {
            if (File.Exists("sauvegardePartie.bin"))
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("sauvegardePartie.bin",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read);
                List<Object> save = (List<object>)formatter.Deserialize(stream);

                //Sauvegarde le joueur, les monstreCaptures et l'inventaire du joueur
                joueur.Joueur = (Joueur)save[0];
                joueur.MonstresCaptures = (List<Monstre>)save[1];
                joueur.Inventaire = (Inventaire)save[2];
                stream.Close();

                //ReloadMagasin();

                Console.WriteLine("La partie a ete chargee");
            }
            else
            {
                throw new AucuneSauvegardeTrouvee();
            }
        }
    }
}
