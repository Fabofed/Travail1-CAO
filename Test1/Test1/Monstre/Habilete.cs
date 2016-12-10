using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravailSession.Interfaces;

namespace TravailSession
{
  
    public enum CibleHabilete { Soi, Ennemi}

    public enum EffetHabilete { Guerison, Degat, Regeneration, Sommeil, Paralysie, Force, Faiblesse} 

    public class Habilete : IUtilisable
    {

        public bool UtilisableFeu { get; set; }

        public bool UtilisableMagma { get; set; }

        public bool UtilisableTerre { get; set; }

        public bool UtilisableVegetation { get; set; }

        public bool UtilisableEau { get; set; }

        public bool UtilisableGlace { get; set; }

        public bool UtilisableAir { get; set; }

        public bool UtilisableElectricite { get; set; }


        public string Nom { get; private set; }
        public string Description { get; private set; }
        public int Gain { get; private set; }
        public int Puissance { get; private set; }
        private EffetHabilete effet { get; set; }


        // public TypeElement element { get; private set; }


        public Habilete(string nom, string description, int gain, int puissance, EffetHabilete effet /*TypeElement element = TypeElement.PretaAttaquer*/)
        {
            this.Nom = nom;
            this.Description = description;
            this.Gain = gain;
            this.Puissance = puissance;
            this.effet = effet;
            //this.Element = element;
        }

        //Determine quel type de monstre peut utiliser l'item
        private void DeterminerUtilisable(Element.Elements Type)
        {
            UtilisableFeu = false;
            UtilisableMagma = false;
            UtilisableTerre = false;
            UtilisableVegetation = false;
            UtilisableEau = false;
            UtilisableGlace = false;
            UtilisableAir = false;
            UtilisableElectricite = false;

            switch (Type)
            {
                case Element.Elements.Air:
                    UtilisableAir = true;
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

        public string Utiliser(Effet unEffet, Monstre cible, Monstre depart)
        {
            throw new NotImplementedException();
        }
    }
}