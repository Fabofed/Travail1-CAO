﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    //Herite de la classe Collection
    class Inventaire : Collection
    {
        private List<Item> items = new List<Item>();

        public Inventaire()
        {

        }

        public void Ajouter(Item item)
        {
            Item aAjouter = item;
        }

        public void Supprimer(Item item)
        {
            Item aRetirer = item;
        }
    }
}
