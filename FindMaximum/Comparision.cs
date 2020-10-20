using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FindMaximum
{
    public class Comparision<T> where T : IComparable
    {
        private T[] values;

        public Comparision(params T[] values)
        {
            this.values = values;
        }

        public T FindMax()
        {
            T max = values[0];
            foreach(T value in values)
            {
                if (value.CompareTo(max) > 0)
                    max = value;
            }
            return max;
        }
    }
}
