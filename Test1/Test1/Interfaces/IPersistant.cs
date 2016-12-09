using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Items;


namespace TravailSession.Interfaces
{
    interface IPersistant
    {
        string SauvegardeXML(MonstreDescription monstre, ItemDescription item);
        string ChargerXML(MonstreDescription monstre, ItemDescription item);
    }
}
