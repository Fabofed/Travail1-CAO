using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.IO;
using System.Xml.Serialization;


namespace TravailSession
{    
    //Cette classe n'est pas terminer - Dave
    //Il reste a implementer la serialization en fichier binaire

    [Serializable]
    public enum EtatActif { Mort, Vivant, Paralyse, Empoisonne, Enrage }


    public class Monstre : MonstreDescription
    {
        private Random generateur = new Random();
        private const int ARgentDepart = 1000;

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
         * Constructeur vide
         */
        public Monstre() : base()
        {
            this.Surnom = Surnom;
            this.NiveauExperience = 1;
            this.PointsExperience = 0;
            this.ptsVieActuels = PtsVieBase;
            this.ptsEnergieActuels = PtsEnergieBase;
            this.Etats = new List<EtatActif>();
            this.HabiletesActives = new List<Habilete>();
            this.Attaque = Attaque;
            this.Defense = Defense;
            Etats.Add(EtatActif.Vivant);
        }

        /*
        * Constructeur avec surnom
        */
        public Monstre(string Surnom) : base()
        {
            this.Surnom = Surnom;
            this.NiveauExperience = 1;
            this.PointsExperience = 0;
            this.ptsVieActuels = PtsVieBase;
            this.ptsEnergieActuels = PtsEnergieBase;
            this.Etats = new List<EtatActif>();
            this.HabiletesActives = new List<Habilete>();
            this.Attaque = Attaque;
            this.Defense = Defense;
            Etats.Add(EtatActif.Vivant);
        }

        /*
         * Constructeur avec Arguments
         */
        public Monstre(int id, string nom, string description, int ptsVieBase, int ptsVieMax, int ptsEnergieBase, int ptsEnergieMax, List<Habilete> habiletesPotentielles, TypeDelement Type
            , int rarete, //base termine ici.
             string surnom, List<EtatActif> etats, List<Habilete> habiletesActives, float Attaque, float Defense) //Uniquement de la classe Monstre
            : base(id, nom, description, ptsVieBase, ptsVieMax, ptsEnergieBase, ptsEnergieMax, habiletesPotentielles, Type , rarete )
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
            if (this.PointsExperience < Niveau1)
            {
                NiveauExperience = 1;
            }

            else if (this.PointsExperience < Niveau2)
            {
                if (NiveauExperience < 2)
                {
                    NiveauExperience = 2;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                NiveauExperience = 2;
            }

            else if (this.PointsExperience < Niveau3)
            {
                if (NiveauExperience < 3)
                {
                    NiveauExperience = 3;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 3;
            }

            else if (this.PointsExperience < Niveau4)
            {
                if (NiveauExperience < 4)
                {
                    NiveauExperience = 4;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 4;
            }

            else if (this.PointsExperience < Niveau5)
            {
                if (NiveauExperience < 5)
                {
                    NiveauExperience = 5;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 5;
            }

            else if (this.PointsExperience < Niveau6)
            {
                if (NiveauExperience < 6)
                {
                    NiveauExperience = 6;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 6;
            }

            else if (this.PointsExperience < Niveau7)
            {
                if (NiveauExperience < 7)
                {
                    NiveauExperience = 7;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 7;
            }

            else if (this.PointsExperience < Niveau8)
            {
                if (NiveauExperience < 8)
                {
                    NiveauExperience = 8;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 8;
            }

            else if (this.PointsExperience < Niveau9)
            {
                if (NiveauExperience < 9)
                {
                    NiveauExperience = 9;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 9;
            }

            else if (this.PointsExperience < Niveau10)
            {
                if (NiveauExperience < 10)
                {
                    NiveauExperience = 10;
                    Console.WriteLine("Votre monstre a monter de niveau! Il est maintenant niveau" + NiveauExperience);
                }
                else
                    NiveauExperience = 10;
            }

            else
                Console.WriteLine("Une erreur est survenu! Votre niveau est ambigue." );
        }

        //Ajoute de l'experience
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

