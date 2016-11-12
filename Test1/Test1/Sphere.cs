using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession
{
    class Sphere : Item
    {
        public Sphere(String nom, String description, int valeur, Element type, List<Effet> effets) : base(nom, description, valeur, type, effets)
        {
            //mettre capturer dans la liste d'effets
        }
    }
}
