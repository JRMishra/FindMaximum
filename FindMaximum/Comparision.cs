using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FindMaximum
{
    public class Comparision
    {
        public static T FindMax<T>(T n1, T n2, T n3) where T : IComparable
        {
            if (n1.CompareTo(n2)>0)
            {
                if (n1.CompareTo(n3) > 0)
                    return n1;
                else
                    return n3;
            }
            else
            {
                if (n2.CompareTo(n3) > 0)
                    return n2;
                else
                    return n3;
            }
        }
    }
}
