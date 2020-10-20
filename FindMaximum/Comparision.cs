using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FindMaximum
{
    public class Comparision<T> where T : IComparable
    {
        private T v1, v2, v3;

        public Comparision(T v1, T v2, T v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public T FindMax()
        {
            if (v1.CompareTo(v2)>0)
            {
                if (v1.CompareTo(v3) > 0)
                    return v1;
                else
                    return v3;
            }
            else
            {
                if (v2.CompareTo(v3) > 0)
                    return v2;
                else
                    return v3;
            }
        }
    }
}
