using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace TravailSession
{
    [Serializable]
     class Aventure
    {
        Joueur joueur;
        Habilete[] listeHabilete;
        Monstre[] listeMonstre;

        public Aventure(Joueur joueur)
        {
            this.joueur = joueur;
            listeHabilete = Habilete.ChargerListeHabilete();
            listeMonstre = Monstre.ChargerListeMonstre();
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
            BinaryFormatter format = new BinaryFormatter();
            using (Stream stream = new FileStream(@".\aventure.ply", FileMode.Create, FileAccess.Write, FileShare.None)) format.Serialize(stream, aventure);
        }

        public static Aventure Charger_Aventure()
        {
            Aventure aventure;
            BinaryFormatter format = new BinaryFormatter();
            using (Stream stream = new FileStream(@".\aventure.ply", FileMode.Open, FileAccess.Read, FileShare.None)) aventure = (Aventure)format.Deserialize(stream);
            return aventure;
        }
    }
}
