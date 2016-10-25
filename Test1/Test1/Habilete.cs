using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Habilete
    {
        private String name;
        private String description;
        public Habilete(String name, String description, Enum typeOfElement, int cost)
        {
            this.name = name;
            this.description = description;
            this.typeOfElement = typeOfElement;
            this.cost = cost;
        }
    }
}


