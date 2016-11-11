using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Main
    {
        Monstre monstre = new Monstre("Saroumane", "Le sorcier Blanc", new Caracteristiques(Caracteristiques.GenererValeur(), 10));

        Console.WriteLine(monstre);

            monstre.PtsVieActuels = 200;
            monstre.Etat.Add(EtatActif.Empoisonne);
            Console.WriteLine(monstre);
    }
}
