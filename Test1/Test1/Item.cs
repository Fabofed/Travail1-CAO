using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Item
    {
        private String nom { get; set; }
        private String description { get; set; }
        private int valeur { get; set; }
        private Element type { get; set; }
        private List<Effet> etat = new List<Effet>();


        public Item(String nom, String description, int valeur, Element type, List<Effet> etat)
        {
            this.nom = nom;
            this.description = description;
            this.valeur = valeur;
            this.type = type;
            this.etat = etat;
        }

    }
}


