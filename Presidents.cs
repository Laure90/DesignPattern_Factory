using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPattern_Factory
{
    abstract class Presidents
    {
        public abstract string Slogan { get; }

        public abstract string Trait { get; set; }

        public Presidents()
        { }


    }
}
