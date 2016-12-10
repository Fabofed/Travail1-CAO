using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Interfaces
{
    interface IUtilisable
    {
        string Utiliser(Effet unEffet, Monstre cible, Monstre depart);
    }
}
