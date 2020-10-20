using System;

namespace FindMaximum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximun Program");
            Console.WriteLine("=====================");
        }

        public static int MaxInt(int n1, int n2, int n3)
        {
            return Math.Max(Math.Max(n1, n2), n3);
        }
    }
}
