using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class PresidentFactory
    {
        public static Presidents CreatePresident(string trait)
        {
            if(trait == "Vénal")
            {
                return new LREM();
            }
            if (trait == "Indécis")
            {
                return new Centre();
            }
            if (trait == "Fou")
            {
                return new PC();
            }
            if (trait == "Végétarien")
            {
                return new Vert();
            }
            if (trait == "Profiteur")
            {
                return new Gauche();
            }
            if (trait == "Psychopathe")
            {
                return new Droite();
            }
            if (trait == "Xénophobe")
            {
                return new RN();
            }
            else
            {
                return null;
            }        
        }

    
    }
}
