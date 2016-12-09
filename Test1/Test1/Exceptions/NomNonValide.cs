using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession.Exceptions
{
    class NomNonValide : Exception
    {
        public override string Message
        {
            get
            {
                return "Votre nom de personnage doit contenir seulement des lettres!";
            }
        }
    }
}
