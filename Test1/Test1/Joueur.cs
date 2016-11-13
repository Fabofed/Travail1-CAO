using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Joueur
    {
        public static String nom { get; set; }
        public static int argent { get; set; }
        public static Inventaire inventaire { get; set; }
        public static Monstre monstreActif = new Monstre(); //Monstre 1 de depart obligatoire
        public static Monstre[] equipe = new Monstre[5];
        public static List<Monstre> monstresCaptures = new List<Monstre>();

        public Joueur(String nom, int argent, Inventaire inventaire, List<Monstre> monstresCaptures, Monstre[] equipe)
        {
            monstresCaptures.Add(monstreActif); //initialise le monstreActif dans la liste de monstresCapt
            equipe = new Monstre[5];
            equipe[0] = monstreActif; // Met le monstreActif dans l'equipe
        }
    }
}
