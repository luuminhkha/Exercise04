using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIscontain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4 };
            bool result0 = Program.Iscontain5(Arr1);
            Assert.AreEqual(false.result0);

            int[] Arr2 = new int[] { 1, 2, 3, 4 };
            bool result1 = Program.Iscontain5(Arr2);
            Assert.AreEqual(true.result1);
        }
    }
}
