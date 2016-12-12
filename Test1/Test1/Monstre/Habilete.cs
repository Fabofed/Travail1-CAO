using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession.Interfaces;

namespace TravailSession
{
    //Les deux methodes sont a refaire

    public class Habilete 
    {
        private Habilete habilete;
        private Joueur joueur;
        private Monstre depart;
        private Monstre cible;

        public bool UtilisableFeu { get; set; }

        public bool UtilisableMagma { get; set; }

        public bool UtilisableTerre { get; set; }

        public bool UtilisableVegetation { get; set; }

        public bool UtilisableEau { get; set; }

        public bool UtilisableGlace { get; set; }

        public bool UtilisableAir { get; set; }

        public bool UtilisableElectricite { get; set; }


        public string Nom { get; set; }
        public string Description { get; set; }
        public int Puissance { get; set; }
        public int Cout { get; set; }

        public Element.Elements ElementsPermise { get; set; }


        public Habilete(string nom, string description, int puissance, int cout, List<Element.Elements> elementsPermise)
        {
            this.Nom = nom;
            this.Description = description;
            this.Puissance = puissance;
            this.Cout = cout;
            List < Element.Elements > ElementsPermise = elementsPermise;
        }

        //Determine quel type de monstre peut utiliser l'habilete
        private bool DeterminerUtilisable(Monstre monstre)
        {
            UtilisableFeu = false;
            UtilisableMagma = false;
            UtilisableTerre = false;
            UtilisableVegetation = false;
            UtilisableEau = false;
            UtilisableGlace = false;
            UtilisableAir = false;
            UtilisableElectricite = false;

            switch (monstre.Type)
            {
                case Element.Elements.Air:
                    UtilisableAir = true;
                    return true;
                    break;

                case Element.Elements.Eau:
                    UtilisableEau = true;
                    break;

                case Element.Elements.Electricite:
                    UtilisableElectricite = true;
                    break;

                case Element.Elements.Feu:
                    UtilisableFeu = true;
                    break;

                case Element.Elements.Glace:
                    UtilisableGlace = true;
                    break;

                case Element.Elements.Magma:
                    UtilisableMagma = true;
                    break;

                case Element.Elements.Vegetation:
                    UtilisableVegetation = true;
                    break;

                case Element.Elements.Terre:
                    UtilisableTerre = true;
                    break;

                default:
                    break;
            }
        }

        //Cette methode est a faire.
        public void Effectuer()
        {
            if (habilete.DeterminerUtilisable == true) //si l'habilete est utilisable pour ce type de monstre
            {
                if (this.monstre.CaracteristiquesMonstre.PtsEnergieActuels > this.habilete.Cout) //Si le monstre a assez de points d'energie
                {
                    habilete.Effectuer(this.cible); //Ajoute la  a la cible
                    joueur.Inventaire.Supprimer(this.potionDeForce); //Enleve les points denergie au monstre
                    Console.WriteLine("Vous consommez votre potion. /nVous reprenez " + force.Magnitude + " points de force.");
                }
                else
                {
                    Console.WriteLine("Vous ne pouvez pas utiliser cette habilete!");
                }
            }
        }
    }
}