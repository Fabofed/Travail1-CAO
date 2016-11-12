using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Sphere : Item
    {
        private String nom { get; set; }
        private String description { get; set; }
        private int valeur { get; set; }
        private Element type { get; set; }
        private List<Effet> etat = new List<Effet>();
    }
}
