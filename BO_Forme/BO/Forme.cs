using System;

namespace BO_Forme
{
    /**
     * By Tanguy Camus
     */
    public abstract class Forme
    {
        /**
         * Permet de calculer l'aire d'une forme
         */
        public abstract double? getAire();
        /**
         * Permet de calculer le périmètre d'une forme
         */
        public abstract double? getPerimetre();
        /**
         * Permet de savoir si une forme possède toutes les données nécéssaires pour les calculs
         */
        public abstract bool isUsable();

        /**
         * Permet l'affichage de l'aire et du périmètre
         */
        public virtual string getBaseAfichage()
        {
            string res = "";
            try
            {
                res = String.Format(Texte.ALL_TEXT, this.getAire(), this.getPerimetre());
            } catch(NumberErrorDuringCalculExcpetion e)
            {
                res = e.Message;
            } catch(Exception e)
            {
                res = Texte.ERROR_UNEXPECTED;
            }
            return res;
        }

        /**
         * Permet d'afficher le message d'erreur
         */
        public virtual string getErrorMessage()
        {
            return Texte.ERROR_NO_DATA;
        }
    }
}
