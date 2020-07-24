using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngBandTest
{
    [TestCategory("Unit")]
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Zero_Plus_Zero_Font_Zero()
        {
            var addition = new Addition(0, 0);
            Assert.AreEqual(0, addition.Resultat);
        }

        [DataTestMethod]
        [DataRow(1, 6, 7)]
        [DataRow(31, -6, 25)]
        public void X_Plus_Y_Font_La_Somme_Des_Deux(int x, int y, int resultat)
        {
            var addition = new Addition(x, y);
            Assert.AreEqual(resultat, addition.Resultat);
        }
    }
}
