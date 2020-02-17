using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Factory
{
    class RN : Presidents
    {
        public override string Trait { get; set; } = "Xénophobe";
        public override string Slogan { get; } = "Si je ne suis pas présidente, je deviendrai Dalida !";
    }
}
