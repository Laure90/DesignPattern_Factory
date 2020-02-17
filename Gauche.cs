using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class Gauche : Presidents
    {
        public override string Trait { get; set; } = "Profiteur";
        public override string Slogan { get; } = "Parfois les mous peuvent atteindre la perfection";
    }
}
