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

        public Equipe(Monstre[] equipe)
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

           public Monstre monstreAAjouter = new Monstre(som, surnom, caracteristiques);
        joueur.Ajouter(monstreAAjouter, joueur);

            return joueur;
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

        return equipe;
    }



    //Selon la difficulte choisi, on genere une equipe de taille equivalente a celle du joueur(0 a 5)
    public Equipe ChoisirEnnemis(Difficulte difficulte)
    {
        throw new NotImplementedException();
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



    //Methode qui appel la classe choisir habilete de la classe Monstre et permet au joueur de choisir les habiletes des monstres dans son equipe un a un
    public void ChoisirHabilete()
    {

    }
}
}
