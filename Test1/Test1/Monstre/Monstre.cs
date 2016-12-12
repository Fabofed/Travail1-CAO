using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.IO;
using System.Xml.Serialization;


namespace TravailSession
{    //Cette classe n'est pas terminer - Dave
    //Il reste a implementer la serialization en fichier binaire

    [Serializable]
    public enum EtatActif { Mort, Vivant, Paralyse, Empoisonne, Enrage }


    public class Monstre : MonstreDescription
    {
        private Random generateur = new Random();

        public string Surnom { get; set; }

        public byte NiveauExperience { get; set; } //De 1 a 10.

        public int PointsExperience { get; set; } //Selon les baremes definies dans la methode VerifierMonterNiveau()

        private int ptsVieActuels;

        private int ptsEnergieActuels;

        public List<EtatActif> Etats { get; set; }

        public List<Habilete> HabiletesActives { get; set; }

        public float Attaque { get; set; }
        public float Defense { get; set; }

        #region Constructeurs
        /*
         * Constructeur avec Argumennts
         */
        public Monstre(int id, string nom, string description, int ptsVieBase, int ptsVieMax, int ptsEnergieBase, int ptsEnergieMax, List<Habilete> habiletesPotentielles, TypeMonstre typeDelement, int rarete, //base termine ici.
             string surnom, List<EtatActif> etats, List<Habilete> habiletesActives, float Attaque, float Defense) //Uniquement de la classe Monstre
            : base(id, nom, description, ptsVieBase, ptsVieMax, ptsEnergieBase, ptsEnergieMax, habiletesPotentielles, typeDelement, rarete)
        {
            this.Surnom = surnom;
            this.NiveauExperience = 1;
            this.PointsExperience = 0;
            this.ptsVieActuels = ptsVieBase;
            this.ptsEnergieActuels = ptsEnergieBase;
            this.Etats = new List<EtatActif>();
            this.HabiletesActives = new List<Habilete>();
            this.Attaque = Attaque;
            this.Defense = Defense;
            etats.Add(EtatActif.Vivant);
        }

        #endregion

        #region Serialization
        //Enregistrer liste de Monstre
        public static void Enregistrer(Monstre[] liste)
        {
            XmlSerializer format = new XmlSerializer(typeof(Monstre[]));
            using (Stream stream = new FileStream(@".\liste_monstres.xml", FileMode.Create, FileAccess.Write, FileShare.None)) format.Serialize(stream, liste);
        }

        //Charger liste de Monstre
        public static Monstre[] Charger()
        {
            Monstre[] monstre;
            XmlSerializer format = new XmlSerializer(typeof(Monstre[]));
            using (Stream stream = new FileStream(@"liste_monstres.xml", FileMode.Open, FileAccess.Read, FileShare.None)) monstre = (Monstre[])format.Deserialize(stream);
            return monstre;
        }
        #endregion


        #region Propriétés (Acesseurs et Mutateurs)

        public int PtsVieActuels
        {
            get { return this.ptsVieActuels; }
            set
            {
                if (value < 0)
                {
                    this.ptsVieActuels = 0;
                }
                else if (value > PtsVieMax)
                {
                    this.ptsVieActuels = PtsVieMax;
                }
                else
                {
                    this.ptsVieActuels = value;
                }
            }
        }

        public int PtsEnergieActuels
        {
            get { return this.ptsEnergieActuels; }
            set
            {
                if (value < 0)
                {
                    this.ptsEnergieActuels = 0;
                }
                else if (value > PtsEnergieMax)
                {
                    this.ptsEnergieActuels = PtsEnergieMax;
                }
                else
                {
                    this.ptsEnergieActuels = value;
                }
            }
        }

        #endregion


        #region Autres Méthodes

        //Verifie si lon doit monter de niveau
        public void VerifierMonterNiveau()
        {
            int niveau1 = 1000;
            int niveau2 = 2500;
            int niveau3 = 5000;
            int niveau4 = 8000;
            int niveau5 = 12000;
            int niveau6 = 16500;
            int niveau7 = 22000;
            int niveau8 = 28000;
            int niveau9 = 36000;
            int niveau10 = 46000;

            if (this.PointsExperience < niveau1)
            {
                NiveauExperience = 1;
            }

            else if (this.PointsExperience < niveau2)
            {
                if (NiveauExperience < 2)
                {
                    NiveauExperience = 2;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                NiveauExperience = 2;
            }

            else if (this.PointsExperience < niveau3)
            {
                if (NiveauExperience < 3)
                {
                    NiveauExperience = 3;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 3;
            }

            else if (this.PointsExperience < niveau4)
            {
                if (NiveauExperience < 4)
                {
                    NiveauExperience = 4;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 4;
            }

            else if (this.PointsExperience < niveau5)
            {
                if (NiveauExperience < 5)
                {
                    NiveauExperience = 5;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 5;
            }

            else if (this.PointsExperience < niveau6)
            {
                if (NiveauExperience < 6)
                {
                    NiveauExperience = 6;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 6;
            }

            else if (this.PointsExperience < niveau7)
            {
                if (NiveauExperience < 7)
                {
                    NiveauExperience = 7;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 7;
            }

            else if (this.PointsExperience < niveau8)
            {
                if (NiveauExperience < 8)
                {
                    NiveauExperience = 8;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 8;
            }

            else if (this.PointsExperience < niveau9)
            {
                if (NiveauExperience < 9)
                {
                    NiveauExperience = 9;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 9;
            }

            else {
                if (NiveauExperience < 10)
                {
                    NiveauExperience = 10;
                    Console.WriteLine("Vous avez monter de niveau! Vous etes maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 10;
            }
        }

        //Ajoute de l'experience et modifie le niveau si necessaire
        public void AjoutExperience(int xp)
        {
            this.PointsExperience += xp;
        }

        /**
         * Permet de choisir une habilete active du monstre
         */
        public Habilete ChoisirHabilete(string nom)
        {
            Habilete habileteTrouvee = null;
            foreach (Habilete h in HabiletesActives)
                if (h.Nom.Equals(nom))
                    habileteTrouvee = h;
            return habileteTrouvee;
        }

        /**
         * Affiche l'état actuel du Monstre
         */
        public override string ToString()
        {
            string etats = "";
            foreach (EtatActif E in etats)
                etats += E.ToString() + " ";
            return "Monstre : \n" + "\t Nom : " + this.Nom + "\n"
                                  + "\t Surnom : " + this.Surnom + "\n"
                                  + "\t Type : " + this.TypeDelement + "\n"
                                  + "\t Rarete : " + this.Rarete + "\n"
                                  + "\t Exp : " + this.NiveauExperience + "\n"
                                  + "\t PV \\ PT : " + this.PtsVieActuels + " \\ " + this.PtsVieMax + "\n"
                                  + "\t Etats : " + etats + "\n";
        }

        #endregion

    }
}

