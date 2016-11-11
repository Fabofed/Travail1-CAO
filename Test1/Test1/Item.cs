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
        private String nom { get; private set; }
        private String description { get; private set; }
        private int valeur { get; private set; }
        private Element type { get; private set; }
        private Effet effet { get; private set; }
    }
}
