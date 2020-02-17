using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class Vert : Presidents
    {
        public override string Trait { get; set; } = "Végétarien";
        public override string Slogan { get; } = "Je ne mange pas de graine !";
    }
}
