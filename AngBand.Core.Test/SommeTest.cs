using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AngBand.Core.Addition;
using System.Linq;

namespace AngBand.Core.Test
{
    [TestCategory("Unit")]
    [TestClass]
    public class SommeTest
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(16)]
        [DataRow(3675)]
        public void Une_Somme_De_N_Zeros_Fait_Zero(int n)
        {
            var somme = new Somme(Enumerable.Repeat(0, n));
            Assert.AreEqual(0, somme.Resultat);
        }

        [DataTestMethod]
        [DataRow(1, 6)]
        [DataRow(16, 45)]
        [DataRow(3675, -3)]
        public void Une_Somme_De_N_Fois_X_Est_Une_Multiplication(int n, int x)
        {
            var somme = new Somme(Enumerable.Repeat(x, n));
            Assert.AreEqual(n * x, somme.Resultat);
        }
    }
}
