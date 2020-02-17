using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class Droite : Presidents
    {
        public override string Trait { get; set; } = "Psychopathe";
        public override string Slogan { get; } = "Je vais tout nettoyer au karcher !";
    }
}
