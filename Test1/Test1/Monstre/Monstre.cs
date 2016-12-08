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
    [Serializable]

    enum TypeMonstre { Feu, Magma, Terre, Vegetation, Eau, Glace, Air, Electricite }
    enum EtatActif { Mort, Vivant, Paralyse, Empoisonne, Enrage }


    /**
     * Stephane 
     */
    public class Monstre
    {
        private Random generateur  = new Random();

        public int id;

        //private string nom; 
        private string surnom;
        private byte rarete;
        private byte niveauExperience;
        private int pointsExperience;
        private Caracteristiques caracteristiquesMonstre;
        private List<EtatActif> etats { get; set; }
        private List<Habilete> habiletesPotentielles;
        private List<Habilete> habiletesActives;

 
        #region Constructeurs

        /*
         * Constructeur par défaut
         */
        public Monstre()
        {
            this.Id = 1;
            this.Nom = "Monstre";
            this.Surnom = null;
            etats = new List<EtatActif>();
        }

        /*
         * Constructeur avec Argumennts
         */
        public Monstre(string Nom, string Surnom, Caracteristiques caracteristiques)
        {
            this.Nom = Nom;
            this.Surnom = Surnom;
            this.Type = TypeMonstre.Terre;
            this.Rarete = rarete;
            this.NiveauExperience = 1;
            this.CaracteristiquesMonstre = caracteristiques;
            this.etats = new List<EtatActif>();
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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom { get; private set; }
        public string Surnom
        {
            get { return surnom; }
            set { surnom = value; }
        }
        public string Description { get; }
        public TypeMonstre Type { get; protected set; }
        public int Rarete {
            get
            {
                return rarete;
            }
            set
            {
                switch (Type)
                {
                    case TypeMonstre.Feu:
                        rarete = (byte)generateur.Next(0, 32);
                        break;
                    case TypeMonstre.Eau:
                        rarete = (byte)generateur.Next(32, 64);
                        break;
                    case TypeMonstre.Air:
                        rarete = (byte)generateur.Next(64, 96);
                        break;
                    case TypeMonstre.Terre:
                        rarete = (byte)generateur.Next(96, 128);
                        break;
                    case TypeMonstre.Magma:
                        rarete = (byte)generateur.Next(128, 160);
                        break;
                    case TypeMonstre.Glace:
                        rarete = (byte)generateur.Next(160, 192);
                        break;
                    case TypeMonstre.Electricite:
                        rarete = (byte)generateur.Next(192, 224);
                        break;
                    case TypeMonstre.Vegetation:
                        rarete = (byte)generateur.Next(224, 256);
                        break;
                }
            }
        }

        public byte NiveauExperience { get; set; }
        public int PointsExperience
        {
            get { return pointsExperience; }
            set { }  
        }
        public Caracteristiques CaracteristiquesMonstre
        {
            get { return caracteristiquesMonstre; }
            set { this.caracteristiquesMonstre = value; }
        }
        public int PtsVieActuels
        {
            get { return this.CaracteristiquesMonstre.PtsVieActuels; }
            set { this.caracteristiquesMonstre.PtsVieActuels = value; }
        }
         public int PtsVieTotal
        {
            get { return this.CaracteristiquesMonstre.PtsVieTotal; }
            set { this.caracteristiquesMonstre.PtsVieTotal = value; }
        }
        public List<EtatActif> Etats
        {
            get
            { return this.etats;
            }
            set { this.etats = value; }
        }
        public List<Habilete> HabiletesPotentielles
        {
            get { return this.habiletesPotentielles; }
        }
        public List<Habilete> HabiletesActives
        {
            get { return this.HabiletesActives; }
        }

        #endregion


        #region Autres Méthodes

        //Calcul niveau d'experience selon les points d'experience
        public void CalculNiveau()
        {
           
        }

        //Ajoute de l'experience et modifie le niveau si necessaire
        public void AjoutExperience(int experienceAAjouter)
        {
            this.pointsExperience += experienceAAjouter;
            int exp = this.pointsExperience;
            if (exp == 100 || exp == 250 || exp == 500 || exp == 1000 || exp == 1600 || exp == 3000)
            {
                this.niveauExperience++;
                this.CalculNiveau();
            }
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
                                  + "\t Type : " + this.Type + "\n"
                                  + "\t Rarete : " + this.Rarete + "\n"
                                  + "\t Exp : " + this.NiveauExperience + "\n"
                                  + "\t PV \\ PT : " + this.PtsVieActuels + " \\ " + this.PtsVieTotal + "\n"
                                  + "\t Etats : " + etats + "\n";
        }

        #endregion

    }
}

