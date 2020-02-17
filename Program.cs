using System;
using System.Collections.Generic;

namespace DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ecris un trait de caractère");
            string trait = Console.ReadLine();
            List<string> listCaractere = new List<string>();
            listCaractere.Add("Vénal");
            listCaractere.Add("Profiteur");
            listCaractere.Add("Indécis");
            listCaractere.Add("Fou");
            listCaractere.Add("Végétarien");
            listCaractere.Add("Psychopathe");
            listCaractere.Add("Xénophobe");

            while (!listCaractere.Contains(trait))
            {
                Console.WriteLine("Ecris un trait de caractère");
                trait = Console.ReadLine();
            }           
            
            Presidents result = PresidentFactory.CreatePresident(trait);
            Console.WriteLine(result.Slogan);  
        }
    }
}
