using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TravailSession;
namespace TravailSession
{
    class Difficulte//Recompense
    {
        private DifficulteCombat difficulte { get; set; }
        private int recompensePts { get; set; }
        private int recompenseArgent { get; set; }
        private Equipe ennemi;
        private Joueur joueur;

        public enum DifficulteCombat
        {
            tresFacile = 0, facile = 1, moyen = 2, difficile = 3, tresDifficile = 4
        };


        public Difficulte(DifficulteCombat difficulte, int recompensePts, int recompenseArgent)
        {
            this.difficulte = difficulte;
            this.recompensePts = recompensePts;
            this.recompenseArgent = recompenseArgent;
        }

        public Joueur Joueur
        {
            get
            {
                return joueur;
            }
        }

        public DifficulteCombat LaDifficulte
        {
            get
            {
                return difficulte;
            }
        }


        //Methode qui recoit une difficulte et genere une equipe avec les recompenses correspondantes
        //switch sur difficulte combat deja fournit plus haut
        public Equipe GenererEquipe(/*int difficulte*/)
        {
           /* bool estValide = false;

            do
            {
                estValide = false;

                switch (difficulte)
                {
                    //case DifficulteCombat.tresFacile
                    case 0:*/
                      /*  Difficulte tresFacile = new Difficulte(DifficulteCombat.tresFacile, 1000, 100);*/
                        ennemi = ennemi.ChoisirEnnemis(difficulte, this.joueur); //Difficulte.this.Joueur;
                  /*      Console.WriteLine("E-Z PEAZY!");*/
                       // break;
/*

                    case 1:
                        Difficulte facile = new Difficulte(DifficulteCombat.facile, 3000, 300);
                        ennemi = ennemi.ChoisirEnnemis(facile, this.joueur); //Methode choisi une liste de monstres
                        Console.WriteLine("Ca va etre du gateau!");
                        break;


                    case 2:
                        Difficulte moyen = new Difficulte(DifficulteCombat.moyen, 10000, 1000);
                        ennemi = ennemi.ChoisirEnnemis(moyen, this.joueur); //Methode choisi une liste de monstres
                        Console.WriteLine("C'est toujours bon d'etre dans la moyenne, il y a mieu et il y a pire!");
                        break;


                    case 3:
                        Difficulte difficile = new Difficulte(DifficulteCombat.difficile, 40000, 4000);
                        ennemi = ennemi.ChoisirEnnemis(difficile, this.joueur); //Methode choisi une liste de monstres
                        Console.WriteLine("Vous aimez ca avoir la vie difficile!");
                        break;


                    case 4:
                        Difficulte tresDifficile = new Difficulte(DifficulteCombat.tresDifficile, 100000, 10000);
                        ennemi = ennemi.ChoisirEnnemis(tresDifficile, this.joueur); //Methode choisi une liste de monstres
                        Console.WriteLine("Certains disent que l'etre humain est naturellement singlé....");
                        break;
                        

                    default:
                        Console.WriteLine("Vous devez choisir un nombre en 0 et 4.");
                        estValide = true;
                        break;
                }
                return ennemi;
            } while (estValide);*/
        }
    }
}

