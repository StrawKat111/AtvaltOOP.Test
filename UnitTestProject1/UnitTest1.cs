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
            string szoveg = "21";
            bool vartEredm = true,
                kapottEredm = false;

            kapottEredm = atvalt.isDecimal(szoveg);

            Assert.AreEqual(kapottEredm, vartEredm);
        }
    }
}
