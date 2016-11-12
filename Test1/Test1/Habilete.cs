using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Habilete
    {
        private String nom { get; set; }
        private String description { get; set; }
        public Habilete(String nom, String description, Enum typeOfElement, int cost)
        {
            this.nom = nom;
            this.description = description;
           // this.typeOfElement = typeOfElement;
            //this.cost = cost;
        }
    }
}


