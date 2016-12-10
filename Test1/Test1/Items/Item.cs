using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using System.Xml.Serialization;
using TravailSession.Items;

namespace TravailSession
{
    //Cette classe est termine - Dave

    [Serializable]

    public abstract class Item : ItemDescription
    {
        #region propriete
       
        public int Quantite { get; set; }

        #endregion
    }
}