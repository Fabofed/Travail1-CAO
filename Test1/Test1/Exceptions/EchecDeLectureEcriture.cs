using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession.Exceptions
{
    class EchecDeLectureEcriture : Exception
    {
        public override string Message
        {
            get
            {
                return "Il y a un probleme avec l'ecriture ou la lecture dans le fichier.";
            }
        }
    }
}
