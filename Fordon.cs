using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pr1
{
    public class Fordon
    {
        private string marke;
        private int ar;
        private string modell;
        public string Marke{
            get{return marke;}
            set{marke = value;}

        }
         public int Ar{
            get{return ar;}
            set{ar = value;}
    }
         public string Modell{
            get{return modell;}
            set{modell = value;}
}
    public Fordon (int ar, string modell, string marke ){
        this.ar = ar;
        this.modell = modell;
        this.marke = marke;
    }
    }
    
}