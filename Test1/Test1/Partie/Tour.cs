using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession
{
    class Tour
    {
        public Monstre monstreEnnemi { get; set; }
        public Monstre monstreJoueur { get; set; }

        public List<Action> Actions { get; set; }
    }
}
