using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;


namespace TravailSession
{
    //Cette classe n'est pas terminer - Dave
    //Il reste a corriger l'erreur dans la methode ChoisirMonstreDepart()

    [Serializable]
    public class Equipe : IEnumerable
    {
        public static List<Monstre> monstres = new List<Monstre>(); //Tout les monstres du jeux.

        public Monstre[] Monstres { get; private set; }

        public Monstre MonstreActif { get; private set; }

        private int Taille { get; set; }


        public Equipe()
        {
            Monstre[] EquipeJoueur = new Monstre[5]
            {
            new Monstre(),
            new Monstre(),
            new Monstre(),
            new Monstre(),
            new Monstre()
        };
            Taille = 5;
        }

        public IEnumerator GetEnumerator()
        {
            return Monstres.GetEnumerator();
        }

        //Parcours la liste de tout les monstresDescription du jeu et presente 3 monstres. Le joueur en choisi 1 et donne un surnom a son monstre. (Cree un monstre avec un id choisi)
        public Equipe ChoisirMonstreDepart()
        {
            Equipe equipeJoueur = new Equipe(); //Instancie l'equipe du joueur (avec 5 monstres)
            List<Monstre> temp = new List<Monstre>(); //Une liste temporaire pour les 3 propositions

            Random random = new Random();
            //monstres = la liste de tout les monstres du jeux
            //Genere 3 randoms parmi tout les monstres, les affichent et les rajoute a une liste temporaire
            for (int i = 1; i >= 3; i++)
            {
                int randomId = random.Next(monstres.Count); //Genere un random ID parmis tout la liste
                Console.WriteLine("Monstre" + i + " choisi au hasard: ");
                Monstre monstreRandom = monstres.Find(x => x.Id.Equals(randomId));
                monstreRandom.ToString(); //Affiche le ToString du monstre selon l'ID fournit
                temp.Add(monstreRandom); //Ajoute le monstre a la liste temp
            }

            int choix1 = temp[0].Id;
            int choix2 = temp[1].Id;
            int choix3 = temp[2].Id;

            int id;
            Console.WriteLine("Choisissez un monstre parmis les trois proposés. Il vous servira comme monstre de depart /nEntrer son ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            //Effectuer la boucle jusqua ce qu'un entree valide soit saisit
            bool estValide = false;
            do
            {
                if (monstres.Contains(temp[0]) && temp.Contains(temp.Where(monstre => monstre.Id.Equals(choix1)))) //Si le monstre existe et est dans les 3 choisis
                {
                    estValide = true;
                }

                else if (monstres.Contains(temp[1]) && temp.Contains(temp.Where(monstre => monstre.Id.Equals(choix2)))) //Si le monstre existe et est dans les 3 choisis
                {
                    estValide = true;
                }

                else if (monstres.Contains(temp[3]) && temp.Contains(temp.Where(monstre => monstre.Id.Equals(choix3)))) //Si le monstre existe et est dans les 3 choisis
                {
                    estValide = true;
                }

                else
                {
                    Console.WriteLine("Veuillez entrer un ID valide");
                }
            }
            while (estValide);

            string surnom;
            Console.WriteLine("Saisisser un surnom: /n");
            surnom = Console.ReadLine();

            Monstre monstreAAjouter = new Monstre(surnom); //Initialise le monstre avec le surnom
            equipeJoueur.MonstreActif = monstreAAjouter; //Ajoute le monstre a l'equipe
            equipeJoueur.Ajouter(monstreAAjouter);
            return equipeJoueur; //Retourne lequipe avec le monstreActif dedans
        }


        //Ajoute un monstre a l'equipe
        private void Ajouter(Monstre monstre)
        {
            if (this.Monstres[0] == null)
                this.Monstres[0] = monstre;
            else if (this.Monstres[1] == null)
                this.Monstres[1] = monstre;
            else if (this.Monstres[2] == null)
                this.Monstres[2] = monstre;
            else if (this.Monstres[3] == null)
                this.Monstres[3] = monstre;
            else if (this.Monstres[4] == null)
                this.Monstres[4] = monstre;
            else Console.WriteLine("Vous avez deja 5 monstres dans votre equipe!");

            this.Taille++;
        }


        //Selon la difficulte choisi, on genere une equipe de taille equivalente a celle du joueur(0 a 5)
        public Equipe ChoisirEnnemis(Recompense.DifficulteCombat difficulte, Joueur joueur)
        {
            Equipe EquipeEnnemi = new Equipe();
            int laTaille = joueur.Equipe.Taille;

            // Boucler pour i allant de 0 a la taille de lequipe. Ajouter un monstre en fonction de la difficulte.
            for (int i = 0; i < laTaille; i++)
            {
                string surnomMonstre = "Ennemi Computer";

                Monstre monstreAAjouter = new Monstre(surnomMonstre); //Ajoute le monstre avec le surnom precedent
                EquipeEnnemi.Ajouter(monstreAAjouter);
            }

            Console.WriteLine("Preparez vous a battre {0} monstre {1}!", laTaille, difficulte);

            return EquipeEnnemi;
        }


        //Permet au joueur de choisir une equipe de 1 a 5 monstres parmi les monstresCaptures
        public Equipe ChoisirEquipe(Monstre[] monstresCaptures)
        {
            Equipe EquipeJoueur = new Equipe();

            Console.WriteLine("Voici la liste de vos monstres captures: ");

            foreach (Monstre Monstre in monstresCaptures)
            {
                Monstre.ToString();
            }

            int id;
            Console.WriteLine("Choisissez un monstre parmis vos monstres captures /nEntrez son ID");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < EquipeJoueur.Taille; i++)
            {
                string surnomMonstre;
                Console.WriteLine("Entrez un surnom pour votre monstre");
                surnomMonstre = Console.ReadLine();

                Monstre monstreAAjouter = new Monstre(surnomMonstre);
                EquipeJoueur.Ajouter(monstreAAjouter);
            }

            return EquipeJoueur;
        }


        //Affiche une equipe de 0 a 5 monstres
        public void Afficher()
        {
            foreach (Monstre monstre in Monstres)
            {
                monstre.ToString();
            }
        }
    }
}

