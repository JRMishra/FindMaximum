using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class Comparision
    {
        public static int FindMaxInt(int n1, int n2, int n3)
        {
            if (n1.CompareTo(n2) > 0)
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

        public static float FindMaxFloat(float f1, float f2, float f3)
        {
            if (f1.CompareTo(f2) > 0)
            {
                if (f1.CompareTo(f3) > 0)
                    return f1;
                else
                    return f3;
            }
            else
            {
                if (f2.CompareTo(f3) > 0)
                    return f2;
                else
                    return f3;
            }
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
