using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximun Program");
            Console.WriteLine("=====================");

            new Comparision<int>(12, 6, 9, 7, 41, 18).PrintMax();
            new Comparision<float>(12.1f, 6.9f, 31.6f, 4, 5f, 9.7f).PrintMax();
            new Comparision<string>("Apple", "Banana", "Lichi", "Mango", "Cheery").PrintMax();
            new Comparision<char>('A', 'D', 'X', 'V', 'F').PrintMax();
        }
    }
}
