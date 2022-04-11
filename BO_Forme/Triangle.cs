using System;

namespace BO_Forme
{
    /**
     * By Tanguy Camus
     */
    public class Triangle : Forme
    {
        public int? A { get; set; }
        public int? B { get; set; }
        public int? C { get; set; }
        public override double? getAire()
        {
            double s = (double)(this.getPerimetre() / 2);
            return Math.Sqrt((double)(s * (s-this.A)*(s-this.B)*(s-this.C)));
        }

        public override double? getPerimetre()
        {
            double? res = this.A + this.B + this.C;
            if(res < this.A || res < this.B || res < this.C) throw new NumberErrorDuringCalculExcpetion();
            return res;
        }
        public override bool isUsable()
        {
            return !(this.A is null) && !(this.B is null) && !(this.C is null);
        }

        override public string ToString()
        {
            return isUsable() ? String.Format(Texte.TRIANGLE_TEXT, this.A, this.B, this.C, this.getBaseAfichage()) : this.getErrorMessage();
        }
    }
}
