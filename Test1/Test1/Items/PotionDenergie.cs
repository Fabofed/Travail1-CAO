using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;

namespace TravailSession.Items
{
    class PotionDenergie : Item
    {
        private Collection collection;
        private Item item;
        private Joueur joueur;
        private Monstre monstre;

        public PotionDenergie(string nom, string description, int valeur, Element type, List<Effet> effets) : base(nom, description, valeur, type, effets)
        {
        }

        public override void Utiliser(Joueur joueur, Monstre monstre)
        {
            //Inserer un traitement ici
            joueur.Inventaire.Supprimer(this.item, this.collection); //Enleve l'item de l'inventaire
        }
    }
}
