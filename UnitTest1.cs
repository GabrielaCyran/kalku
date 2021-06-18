using Microsoft.VisualStudio.TestTools.UnitTesting;
using projektMiniKalk;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Form1spliterTest_Dodawanie_RownanieOdpowiadaWynikowi()
        {
            //Arrange
            Form1 ob = new Form1();
            int wynik;
            //Act
          
            wynik = ob.SpliterTest("1+1*3+4");
            //Assert
            Assert.AreEqual(wynik, 8);
        }
        
        [TestMethod]
        public void Form1spliterTest_Odejmowanie_RownanieOdpowiadaWynikowi()
        {
            //Arrange
            Form1 ob = new Form1();
            int wynik;
            //Act
          
            wynik = ob.SpliterTest("1+1*3-2");
            //Assert
            Assert.AreEqual(wynik, 2);
        } 
        
        [TestMethod]
        public void Form1spliterTest_Dzielenie_RownanieOdpowiadaWynikowi()
        {
            //Arrange
            Form1 ob = new Form1();
            int wynik;
            //Act
          
            wynik = ob.SpliterTest("1+1*3+2/1");
            //Assert
            Assert.AreEqual(wynik, 6);
        }  
        [TestMethod]
        public void Form1spliterTest_Mnozenie_RownanieOdpowiadaWynikowi()
        {
            //Arrange
            Form1 ob = new Form1();
            int wynik;
            //Act
          
            wynik = ob.SpliterTest("1+1*3+2*1");
            //Assert
            Assert.AreEqual(wynik,6 );
        }
       
    }
}
