using System;

namespace BO_Forme
{
    public class NumberErrorDuringCalculExcpetion : Exception
    {
        public NumberErrorDuringCalculExcpetion()
        : base(Texte.ERROR_NUMBER)
        {}
    }
}
