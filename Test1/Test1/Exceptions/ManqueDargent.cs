using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession.Exceptions
{
    class ManqueDargent : Exception
    {
        public ManqueDargent(string erreur) : base(erreur)
        {
            Console.WriteLine("Vous n'avez pas assez d'argent!");
        }
    }
}
