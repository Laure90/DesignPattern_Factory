using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class PC : Presidents
    {
        public override string Trait { get; set; } = "Fou";
        public override string Slogan { get; } = "Ne me touchez pas ! Vous n'avez pas le droit de me toucher ! " +
            "Personne ne me touche, ma personne est sacrée. C'est moi Mélenchon avec mon écharpe tricolore...";
    }
}
