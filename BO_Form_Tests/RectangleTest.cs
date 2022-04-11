using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO_Forme;


namespace BO_Forme_Tests
{
    /**
     * By Tanguy Camus
     */
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void calculAireTest()
        {
            Rectangle rectangle = new Rectangle { Largeur = 3, Longueur = 4 };
            Assert.AreEqual(rectangle.getAire(), 12);
        }

        [TestMethod]
        public void calculPerimetreTest()
        {
            Rectangle rectangle = new Rectangle { Largeur = 3, Longueur = 4 };
            Assert.AreEqual(rectangle.getPerimetre(), 14);
        }

        [TestMethod]
        public void longueurVideTest()
        {
            Rectangle rectangle = new Rectangle();
            Assert.AreEqual(rectangle.ToString(), Texte.ERROR_NO_DATA);
            rectangle.Longueur = 4;
            Assert.AreEqual(rectangle.ToString(), Texte.ERROR_NO_DATA);
        }

        [TestMethod]
        public void numberErrorTest()
        {
            Rectangle rectangle = new Rectangle() { Longueur = 2147483647, Largeur = 50 };
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => rectangle.getAire());
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => rectangle.getPerimetre());
        }

        [TestMethod]
        public void isUsableTest()
        {
            Rectangle rectangle = new Rectangle();
            Assert.IsFalse(rectangle.isUsable());
            rectangle.Longueur = 5;
            Assert.IsFalse(rectangle.isUsable());
            rectangle.Largeur = 5;
            Assert.IsTrue(rectangle.isUsable());
        }
    }
}
