﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1;

namespace TravailSession
{
    class Program
    {
        static void Main(string[] args)
        {

            Monstre monstre = new Monstre("Saroumane", "Le sorcier Blanc", new Caracteristiques(Caracteristiques.GenererValeur(), 10));

            Console.WriteLine(monstre);

            monstre.PtsVieActuels = 200;
            Console.WriteLine(monstre);
           
        }
    }
}
