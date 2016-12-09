﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailSession.Exceptions
{
    class ChoixInvalid : Exception
    {
        public override string Message
        {
            get
            {
                return "Votre choix est invalid, veuillez recommencer.";
            }
        }
    }
}
