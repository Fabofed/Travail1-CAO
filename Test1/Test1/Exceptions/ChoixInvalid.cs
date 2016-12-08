using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession.Exceptions
{
    class ChoixInvalid : Exception
    {
        public ChoixInvalid(string erreur) : base(erreur)
        {
            Console.WriteLine("Votre choix est invalid, veuillez recommencer.");
        }
    }
}
