using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO_Forme;

namespace BO_Forme_Tests
{
    /**
     * By Tanguy Camus
     */
    [TestClass]
    public class CercleTest
    {
        [TestMethod]
        public void calculAireTest()
        {
            Cercle cercle = new Cercle { Rayon = 3 };
            Assert.AreEqual(cercle.getAire(), 28.274333882308138);
        }

        [TestMethod]
        public void calculPerimetreTest()
        {
            Cercle cercle = new Cercle { Rayon = 3 };
            Assert.AreEqual(cercle.getPerimetre(), 18.84955592153876);
        }

        [TestMethod]
        public void rayonVideTest()
        {
            Cercle cercle = new Cercle();
            Assert.AreEqual(cercle.ToString(), Texte.ERROR_NO_DATA);
        }

        [TestMethod]
        public void numberErrorTest()
        {
            Cercle cercle = new Cercle() { Rayon = 2147483647 };
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => cercle.getAire());
        }

        [TestMethod]
        public void isUsableTest()
        {
            Cercle cercle = new Cercle();
            Assert.IsFalse(cercle.isUsable());
            cercle.Rayon = 5;
            Assert.IsTrue(cercle.isUsable());
        }
    }
}
