using System;

namespace BO_Forme
{
    /**
     * By Tanguy Camus
     */
    public class Rectangle : Forme
    {
        public int? Largeur { get; set; }
        public int? Longueur { get; set; }

        public override double? getAire()
        {
            double? res = this.Largeur * this.Longueur;
            if (res < this.Largeur || res < this.Longueur) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override double? getPerimetre()
        {
            double? res = (this.Largeur + this.Longueur) * 2;
            if (res < this.Largeur || res < this.Longueur) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override bool isUsable()
        {
            return !(this.Longueur is null) && !(this.Largeur is null);
        }

        override public string ToString()
        {
            return isUsable() ? String.Format(Texte.RECTANGLE_TEXT, this.Longueur, this.Largeur, this.getBaseAfichage()) : this.getErrorMessage();
        }
    }
}
