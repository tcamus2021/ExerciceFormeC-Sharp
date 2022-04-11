using System;

namespace BO_Forme
{
    /**
     * By Tanguy Camus
     */
    public class Cercle : Forme
    {
        public int? Rayon { get; set; }

        public override double? getAire()
        {
            double res = (double)(Math.PI * (this.Rayon * this.Rayon));
            if (res < this.Rayon) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override double? getPerimetre()
        {
            double? res = (2 * Math.PI * this.Rayon);
            if (res < this.Rayon) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }

        public override bool isUsable()
        {
            return !(this.Rayon is null);
        }

        override public string ToString()
        {
            return isUsable() ? String.Format(Texte.CERCLE_TEXT, this.Rayon, this.getBaseAfichage()) : this.getErrorMessage();
        }
    }
}
