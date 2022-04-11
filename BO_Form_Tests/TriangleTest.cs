using Microsoft.VisualStudio.TestTools.UnitTesting;
using BO_Forme;

namespace BO_Forme_Tests
{
    /**
     * By Tanguy Camus
     */
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void calculAireTest()
        {
            Triangle triangle = new Triangle { A = 4, B = 5, C = 6 };
            Assert.AreEqual(triangle.getAire(), 9.921567416492215);
        }

        [TestMethod]
        public void calculPerimetreTest()
        {
            Triangle triangle = new Triangle { A = 4, B = 5, C = 6 };
            Assert.AreEqual(triangle.getPerimetre(), 15);
        }

        [TestMethod]
        public void longueurVideTest()
        {
            Triangle triangle = new Triangle();
            Assert.AreEqual(triangle.ToString(), Texte.ERROR_NO_DATA);
            triangle.A = 6;
            Assert.AreEqual(triangle.ToString(), Texte.ERROR_NO_DATA);
            triangle.B = 6;
            Assert.AreEqual(triangle.ToString(), Texte.ERROR_NO_DATA);
        }

        [TestMethod]
        public void numberErrorTest()
        {
            Triangle triangle = new Triangle() { A = 2147483647, B = 50, C = 2147483647 };
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => triangle.getAire());
            Assert.ThrowsException<NumberErrorDuringCalculExcpetion>(() => triangle.getPerimetre());
        }

        [TestMethod]
        public void isUsableTest()
        {
            Triangle triangle = new Triangle();
            Assert.IsFalse(triangle.isUsable());
            triangle.A = 5;
            Assert.IsFalse(triangle.isUsable());
            triangle.B = 5;
            Assert.IsFalse(triangle.isUsable());
            triangle.C = 5;
            Assert.IsTrue(triangle.isUsable());
        }
    }
}
