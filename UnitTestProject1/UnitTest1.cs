using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;

namespace UnitTestProject1
{
    [TestClass]
    public class Atvalt_ClassUnitTest
    {
        Atvalt atvalt = new Atvalt();

        [TestMethod]
        public void isDecimal_True()
        {
            string szoveg = "28";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isDecimal_False()
        {
            string szoveg = "2.8";
            bool vartEredm = false,
                kapottEredm = true;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isBinaris_True()
        {
            string szoveg = "100101";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isBinaris(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
        [TestMethod]
        public void isBinaris_False()
        {
            string szoveg = "666";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isBinaris(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
