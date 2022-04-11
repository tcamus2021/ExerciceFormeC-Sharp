using System;

namespace BO_Forme
{    
    /**
     * By Tanguy Camus
     */
    public class Carre : Forme
    {
        public int? Longueur { get; set; }

        public override double? getAire()
        {
            double? res = this.Longueur * this.Longueur;
            if(res < this.Longueur) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override double? getPerimetre()
        {
            double? res = this.Longueur * 4;
            if (res < this.Longueur) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override bool isUsable()
        {
            return !(this.Longueur is null);
        }

        override public string ToString()
        { 
            return isUsable() ? String.Format(Texte.CARRE_TEXT, this.Longueur, this.getBaseAfichage()) : this.getErrorMessage();
        }
    }
}
