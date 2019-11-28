using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge_Kevin
{
    public class MyChallenge
    {
        public List<int> SortList(List<int> list)
        {
            list.Sort();
            return list;
        }

        public int GetPerimeterAndDecompose(Triangle triangle, out int a, out int b, out int c)
        {
            throw new NotImplementedException();
        }

        public void Abs(ref int a)
        {
            throw new NotImplementedException();
        }

        public List<int> RevertList(List<int> list)
        {
            list.Reverse();

            return list;
        }

        public bool TriangleAreEqual(Triangle t1, Triangle t2)
        {
                return t1.Equals(t2);           
        }

        public bool PerimeterAreEqual(Triangle t1, Triangle t2)
        {
            if (t1.A == t2.A && t1.B == t2.B && t1.C == t2.C)

                return true;
 
            else
                return false;
        }
    }
}
