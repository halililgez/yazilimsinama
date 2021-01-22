using Microsoft.VisualStudio.TestTools.UnitTesting;
using proje3;
using System.Data.SqlTypes;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            test f = new test();
            int i = f.gunHesapla(5);
            Assert.AreEqual(10, i);
        }

        [TestMethod]
        public void TestMethod2()
        {
            test f = new test();
            int i = f.gunHesapla(3);
            Assert.AreEqual(6, i);
        }

        [TestMethod]
        public void TestMethod3()
        {
            test f = new test();
            int i = f.projeHesap(2);
            Assert.AreEqual(2, i);
        }

    }
}
