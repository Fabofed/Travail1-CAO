using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
   public abstract class Item
    {
        #region propriete
        public String Nom { get; set; }
        public String Description { get; set; }
        public int Valeur { get; set; }
        public int Degats { get; set; } // j'ai rajouté le champ degats
        public Element Type { get; set; }
        public List<Effet> etat { get; set; }
        #endregion

        #region constructeur
        public Item (string nom, String description, int valeur, int Degats, Element type, List<Effet> etat)
        {
            this.Nom = Nom;
            this.Description = Description;
            this.Valeur = Valeur;
            this.Degats = Degats;
            this.Type = type;
            this.etat = etat;
            etat = new List<Effet>();
        }
        #endregion
    }
}