using Challenge_Kevin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Challenge_KevinTest
{
    [TestClass]
    public class ChallengeTest
    {
        [TestMethod]
        public void SortList1()
        {
            var list = new List<int> { 9, 4, 7, 3, 8, 6 };

            var mc = new MyChallenge();
            var result = mc.SortList(list);

            CollectionAssert.AreEqual(new List<int> { 3, 4, 6, 7, 8, 9 }, result);
        }

        [TestMethod]
        public void SortList2()
        {
            var list = new List<int> { 8, 4, 7 };

            var mc = new MyChallenge();
            var result = mc.SortList(list);

            CollectionAssert.AreEqual(new List<int> { 4, 7, 8 }, result);
        }

        [TestMethod]
        public void GetPerimeterAndDecompose1()
        {
            var triangle = new Triangle(1, 8, 3);

            var mc = new MyChallenge();
            var result = mc.GetPerimeterAndDecompose(triangle, out int a, out int b, out int c);

            Assert.AreEqual(12, result);
            Assert.AreEqual(1, a);
            Assert.AreEqual(8, b);
            Assert.AreEqual(3, c);
        }

        [TestMethod]
        public void GetPerimeterAndDecompose2()
        {
            var triangle = new Triangle(4, 7, 6);

            var mc = new MyChallenge();
            var result = mc.GetPerimeterAndDecompose(triangle, out int a, out int b, out int c);

            Assert.AreEqual(17, result);
            Assert.AreEqual(4, a);
            Assert.AreEqual(7, b);
            Assert.AreEqual(6, c);
        }

        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(-5, 5)]
        [DataRow(6, 6)]
        [DataRow(-6, 6)]
        public void Abs(int a, int expected)
        {
            var mc = new MyChallenge();
             mc.Abs(ref a);

            Assert.AreEqual(expected, a);
        }

        [TestMethod]
        public void RevertList1()
        {
            var list = new List<int> { 9, 4, 7, 3, 8, 6 };

            var mc = new MyChallenge();
            var result = mc.RevertList(list);

            CollectionAssert.AreEqual(new List<int> { 6, 8, 3, 7, 4, 9 }, result);
        }

        [TestMethod]
        public void RevertList2()
        {
            var list = new List<int> { 8, 4, 7 };

            var mc = new MyChallenge();
            var result = mc.RevertList(list);

            CollectionAssert.AreEqual(new List<int> { 7, 4, 8 }, result);
        }

        [TestMethod]
        public void TriangleAreEqual1()
        {
            var t1 = new Triangle(4, 7, 6);
            var t2 = new Triangle(4, 7, 6);

            var mc = new MyChallenge();
            var result = mc.TriangleAreEqual(t1, t2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TriangleAreEqual2()
        {
            var t1 = new Triangle(4, 7, 6);
            var t2 = new Triangle(9, 2, 8);

            var mc = new MyChallenge();
            var result = mc.TriangleAreEqual(t1, t2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PerimeterAreEqual1()
        {
            var t1 = new Triangle(4, 4, 2);
            var t2 = new Triangle(5, 2, 3);

            var mc = new MyChallenge();
            var result = mc.PerimeterAreEqual(t1, t2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PerimeterAreEqual2()
        {
            var t1 = new Triangle(4, 4, 2);
            var t2 = new Triangle(6, 2, 3);

            var mc = new MyChallenge();
            var result = mc.PerimeterAreEqual(t1, t2);

            Assert.IsFalse(result);
        }
    }
}

