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
            a = triangle.A;
            b = triangle.B;
            c = triangle.C;

            int perimeter = a + b + c;

            return perimeter;
        }

        public void Abs(ref int a)
        { 
          a = Math.Abs(a);         
        }

        public List<int> RevertList(List<int> list)
        {
            list.Reverse();

            return list;
        }

        public bool TriangleAreEqual(Triangle t1, Triangle t2)
        {
            if (t1.A == t2.A && t1.B == t2.B && t1.C == t2.C)
                return true;
            else
                return false;
        }

        public bool PerimeterAreEqual(Triangle t1, Triangle t2)
        {
            int t1Perimeter = t1.A + t1.B + t1.C;
            int t2Perimeter = t2.A + t2.B + t2.C;

            if (t1Perimeter == t2Perimeter)
                return true;
            else
                return false;
        }
    }
}
