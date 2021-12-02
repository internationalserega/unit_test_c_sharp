using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unit_test_c_sharp;

namespace createrepositoryTest2
{
    [TestClass]
    public class Untitled
    {
        [TestMethod]
    public void TestMethod1()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;
        }

    }
}