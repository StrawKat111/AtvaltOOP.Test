using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtvaltOOP;
using System;

namespace AtvaltOOP.Tests
{
    [TestClass]
    public class AtvaltTests
    {
        [TestMethod]
        public void TestBinarisToTizes()
        {
            Atvalt atvalt = new Atvalt();
            atvalt.SetSzam(0b1101); 

            
            atvalt.Atvalt();

            
            Assert.Equals(13, atvalt.GetEredmeny());
        }

        [TestMethod]
        public void TestTizesToBinaris()
        {
            
            Atvalt atvalt = new Atvalt();
            atvalt.SetSzam(13);


            atvalt.Atvalt(); 

            
            Assert.Equals(0b1101, atvalt.GetEredmeny());
        }

        [TestMethod]
        public void TestHibasBinarisSzam()
        {
            
            Atvalt atvalt = new Atvalt();
            atvalt.SetSzam(1234);  

            
            var exception = Assert.ThrowsException<ArgumentException>(() => atvalt.Atvalt());
            Assert.Equals("Hibás bináris szám!", exception.Message);
        }

        [TestMethod]
        public void TestHibasTizesSzam()
        {
           
            Atvalt atvalt = new Atvalt();
            atvalt.SetSzam(1);  

            
            var exception = Assert.ThrowsException<ArgumentException>(() => atvalt.Atvalt());
            Assert.Equals("Hibás tizes szám!", exception.Message);
        }
    }
}
