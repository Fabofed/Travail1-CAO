using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    class Equipe
    {
        public Monstre monstreActif = new Monstre(); //Monstre 1 de depart obligatoire
        public Monstre monstre2 = new Monstre(); //Monstre 2
        public Monstre monstre3 = new Monstre(); //Monstre 3
        public Monstre monstre4 = new Monstre(); //Monstre 4
        public Monstre monstre5 = new Monstre(); //Monstre 5


        public Monstre[] equipe { get; set; }
        public int taille { get; private set; }

        public Equipe(Monstre[] equipe)
        {
            Monstre[] equipeJoueur = new Monstre[5];
            equipeJoueur[0] = monstreActif;
            equipeJoueur[1] = monstre2;
            equipeJoueur[2] = monstre3;
            equipeJoueur[3] = monstre4;
            equipeJoueur[4] = monstre5;

            taille = 0;
            this.equipe = equipeJoueur;
        }

        public Equipe()
        {
            Monstre[] equipeJoueur = new Monstre[5];
            equipeJoueur[0] = monstreActif;
            equipeJoueur[1] = monstre2;
            equipeJoueur[2] = monstre3;
            equipeJoueur[3] = monstre4;
            equipeJoueur[4] = monstre5;

            this.equipe = equipeJoueur;
        }



        //Parcours la liste de tout les monstres et presente 3 monstres. Le joueur en choisi 1 et donne un surnom a son monstre
        public Equipe ChoisirMonstreActif()
        {
            Equipe joueur = new Equipe(equipe); //Instancie l'equipe du joueur (avec 5 places)
            List<Monstre> temp = new List<Monstre>(); //Une liste temporaire pour les 3 propositions

            Console.WriteLine("Voici la liste de tous les monstres du jeux: /n");

            Random random = new Random();
            //monstres = la liste de tout les monstres du jeux
            //Genere 3 randoms parmi tout les monstres, les affichent et les rajoute a une liste temporaire
            for (int i = 1; i >= 3; i++)
            {
                int randomId = random.Next(monstres.Count); //Genere un random ID parmis tout la liste
                monstres.get.Id(randomId).ToString(); //Affiche le ToString du monstre selon l'ID fournit
                temp.Add(monstres[randomId].Id); //Ajoute le monstre a la liste temp
            }

            int choix1 = temp[0].id;
            int choix2 = temp[1].id;
            int choix3 = temp[3].id;

            int id;
            Console.WriteLine("Choisissez un monstre parmis les trois proposés. Il vous servira comme monstre de depart /nEntrer son ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            //Effectuer la boucle jusqua ce qu'un entree valide soit saisit
            bool estValide = false;
            do
            {
                if (monstres.Exists(x => x.MonstreId == id) && temp.Contains(choix1 || choix2 || choix3)) //Si le monstre existe et est dans les 3 choisis
                {
                    estValide = true;
                }

                else
                {
                    Console.WriteLine("Veuillez entrer un ID valide");
                }
            } while (estValide);

            string surnom;
            Console.WriteLine("Quel sera son surnom: /n");
            surnom = Console.ReadLine();

            Monstre monstreAAjouter = new Monstre(monstres.get.nom(id), surnom, monstres.get.caracteristiquesMonstre(id)); //Initialise le monstre
            joueur.Ajouter(monstreAAjouter, joueur); //Ajoute le monstre a l'equipe
            return joueur; //Retoure lequipe avec le monstreActif dedans
        }



        //Ajoute un monstre a l'equipe et retourne l'equipe
        public Equipe Ajouter(Monstre monstre, Equipe equipe)
        {
            if (equipe.monstreActif == null)
                equipe.monstreActif = monstre;
            else if (equipe.monstre2 == null)
                equipe.monstre2 = monstre;
            else if (equipe.monstre3 == null)
                equipe.monstre3 = monstre;
            else if (equipe.monstre4 == null)
                equipe.monstre4 = monstre;
            else if (equipe.monstre5 == null)
                equipe.monstre5 = monstre;
            else Console.WriteLine("Vous avez deja 5 monstres dans votre equipe!");

            equipe.taille = equipe.taille++;
            return equipe;
        }



        //Selon la difficulte choisi, on genere une equipe de taille equivalente a celle du joueur(0 a 5)
        public Equipe ChoisirEnnemis(Difficulte difficulte, Joueur joueur)
        {
            string difficulteMonstres = "Difficulte par defaut.";
            bool estValide;
            Equipe ennemi = new Equipe(equipe);
            int laDifficulte = (int)difficulte.LaDifficulte; //De 0(tresFacile) a 4(tresDifficile)

            //Mettre la difficulte (int) en String
            switch (laDifficulte)
            {
                case 0:
                    difficulteMonstres = "tres facile";
                    break;

                case 1:
                    difficulteMonstres = "facile";
                    break;

                case 2:
                    difficulteMonstres = "moyen";
                    break;

                case 3:
                    difficulteMonstres = "difficile";
                    break;

                case 4:
                    difficulteMonstres = "tres difficile";
                    break;
            }

            //Va chercher la taille de l'equipe du joueur
            int taille = joueur.Equipe.taille;

            do
            {
                estValide = false;

                //Selon la taille
                switch (taille)
                {
                    case 0:
                        Console.WriteLine("Vous n'avez aucun monstre dans votre equipe! Ceci est anormal.");
                        break;


                    case 1:
                        //selon la difficulte
                        switch (laDifficulte)
                        {
                            case 0:

                                break;

                            case 1:

                                break;

                            case 2:

                                break;

                            case 3:

                                break;

                            case 4:

                                break;
                        }

                        Console.WriteLine("Preparez vous a battre {0} monstre {1}!", taille, difficulteMonstres);
                        break;


                    case 2:
                        //selon la difficulte
                        switch (laDifficulte)
                        {

                        }

                        Console.WriteLine("Preparez vous a battre {0} monstres {1}!", taille, difficulteMonstres);
                        break;


                    case 3:
                        //selon la difficulte
                        switch (laDifficulte)
                        {

                        }

                        Console.WriteLine("Preparez vous a battre {0} monstres {1}!", taille, difficulteMonstres);
                        break;


                    case 4:
                        //selon la difficulte
                        switch (laDifficulte)
                        {

                        }

                        Console.WriteLine("Preparez vous a battre {0} monstres {1}!", taille, difficulteMonstres);
                        break;

                    case 5:
                        //selon la difficulte
                        switch (laDifficulte)
                        {

                        }

                        Console.WriteLine("Preparez vous a battre {0} monstres {1}!", taille, difficulteMonstres);
                        break;


                    default:
                        Console.WriteLine("Une erreur s'est produite avec la taille de votre equipe.");
                        estValide = true;
                        break;
                }
                return ennemi;
            } while (estValide);
        }



        //Permet au joueur de choisir une equipe de 1 a 5 monstres parmi les monstresCaptures
        public Equipe ChoisirEquipe()
        {

            throw new NotImplementedException();
        }



        //Affiche une equipe de 0 a 5 monstres
        public void AfficherEquipe()
        {
            foreach (Monstre monstre in equipe)
            {
                monstre.ToString();
            }
        }
    }
}

