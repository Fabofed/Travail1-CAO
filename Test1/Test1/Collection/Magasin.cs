using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession;
using TravailSession.Exceptions;
using TravailSession.Items;

namespace TravailSession
{
    //Cette classe est terminer - Dave

    //Herite de la classe abstraite generique Collection. Represente le magasin auquel le joueur a acces.
    public class Magasin : ItemCollection<Item>
    {
        private Joueur joueur;
        public static readonly Magasin ItemsMagasin = new Magasin();

        public const int SPHERE = 0;
        public const int POTION_DE_VIE_ID = 1;
        public const int POTION_DE_REGENERATION_ID = 2;
        public const int POTION_DE_FORCE_ID = 3;
        
                
        public ItemCollection<Item> Details { get; set; }
        public int Quantite { get; set; }

        public Magasin() : base()
        {
            //Herite de tous ce qu'il a besoin
        }

        public override void Ajouter(Item item)
        {
            ItemsMagasin.items.Add(item);
        }

        //On doit generer le magasin a chaque ouverture du magasin
        public void GenererMagasin()
        {
            ItemsMagasin.Ajouter(new Sphere(0, "Pokeball", "Cette boule vous permez de capturer des monstres!", 2000, 3)); 
            ItemsMagasin.Ajouter(new PotionDeVie(1, "Potion de vie", "Cette potion vous donne un regain de vie, vous etes maintenant moins pres de la mort!", 50, 3));
            ItemsMagasin.Ajouter(new PotionDeRegeneration(2, "Potion de regeneration", "Cette potion vous donne un regain de vie sur plusieurs tours, soyez patient!", 100, 3));
            ItemsMagasin.Ajouter(new PotionDeForce(3, "Potion de force", "Cette potion vous donne un regain de force, vous etes maintenant plus fort que jamais!", 150, 3));
        }
    }
}
