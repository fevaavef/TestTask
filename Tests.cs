using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumFunc;

namespace TestMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = SumMethod.Sum(new int[] { 4, 0, 3, 19, 492, -10, 1 });
            int expected = -10;
            Assert.AreEqual(expected, res, 0.001, "Wrong result");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod2()
        {
            int res = FuncClass.Sum(new int[] { });
        }

        [TestMethod]
        public void TestMethod3()
        {
            int res = FuncClass.Sum(new int[] { -435225, -666520, 330148, 32124, -982125, 642548, -232883, 93953, -145405 
                -410975, -342179, 14223, -11750, -106185, 365119, -504492, -13995, 754063, -838410,
                285348, 317867, -637511, -286379, -204314, -866566, -795777, 511382, -885599, - 452393, -654165, 225923, 
                298815, -134432, 977892, -504113, -39959, 350042, 924676, 688286, -145484, 302951, 581063, -625195, -942474, 
                -380914, -217358, 25675, -666575, 153506, -333397 });
            int expected = -1924599;
            Assert.AreEqual(expected, res, 0.001, "Wrong result when array is empty");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod4()
        {
            int res = FuncClass.Sum(new int[] {int.MaxValue, int.MaxValue });
        }

        [TestMethod]
        public void TestMethod5()
        {
            int res = FuncClass.Sum(new int[] { int.MinValue, int.MaxValue });
            int expected = -1;
            Assert.AreEqual(expected, res, 0.001, "Wrong result");
        }
    }
}
