using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    public class Main
    {
        //Instancier les monstres
        Monstre monstre = new Monstre("Saroumane", "Le sorcier Blanc", new Caracteristiques(Caracteristiques.GenererValeur(), 10));

        Console.WriteLine(monstre);

            monstre.PtsVieActuels = 200;
            Console.WriteLine(monstre);


            //Instancier les items
            //Instancier le joueur avec les I/O de l'utilisateur
            //Instancier les effets
            //Instancier le magasin et l'inventaire
            //Instancier l'equipe

    }
}
