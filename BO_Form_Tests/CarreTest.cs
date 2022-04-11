using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO_Forme;

namespace BO_Forme_Tests
{
    /**
     * By Tanguy Camus
     */
    [TestClass]
    public class CarreTest
    {
        [TestMethod]
        public void calculAireTest()
        {
            Carre carre = new Carre { Longueur = 3 };
            Assert.AreEqual(carre.getAire(), 9);
        }

        [TestMethod]
        public void calculPerimetreTest()
        {
            Carre carre = new Carre { Longueur = 3 };
            Assert.AreEqual(carre.getPerimetre(), 12);
        }

        [TestMethod]
        public void longueurVideTest()
        {
            Carre carre = new Carre();
            Assert.AreEqual(carre.ToString(), Texte.ERROR_NO_DATA);
        }

        [TestMethod]
        public void numberErrorTest()
        {
            Carre cercle = new Carre() { Longueur = 2147483647 };
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => cercle.getAire());
        }

        [TestMethod]
        public void isUsableTest()
        {
            Carre carre = new Carre();
            Assert.IsFalse(carre.isUsable());
            carre.Longueur = 5;
            Assert.IsTrue(carre.isUsable());
        }
    }
}
