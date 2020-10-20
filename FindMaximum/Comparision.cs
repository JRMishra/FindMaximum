using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class Comparision
    {
        public static int FindMaxInt(int n1, int n2, int n3)
        {
            return Math.Max(Math.Max(n1, n2), n3);
        }

        public static float FindMaxFloat(float f1, float f2, float f3)
        {
            return Math.Max(Math.Max(f1, f2), f3);
        }

        public static string FindMaxString(string s1, string s2, string s3)
        {
            if(s1.CompareTo(s2)>0)
            {
                if (s1.CompareTo(s3) > 0)
                    return s1;
                else
                    return s3;
            }
            else
            {
                if (s2.CompareTo(s3) > 0)
                    return s2;
                else
                    return s3;
            }
        }
    }
}
