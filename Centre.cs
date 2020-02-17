using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class Centre : Presidents
    {
        public override string Trait { get; set; } = "Indécis";
        public override string Slogan { get; } = "Je sais pas";
    }
}
