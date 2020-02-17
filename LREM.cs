using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class LREM : Presidents
    {
        public override string Trait { get; set; } = "Vénal";
        public override string Slogan { get; } = "Il faut des jeunes Français qui aient envie de devenir milliardaires.";
    }
}
