using System;
using CompareCharactersCount;

namespace Open_Lab_03._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the first word");
            string word1 = Console.ReadLine();

            Console.WriteLine("Write the second word");
            string word2 = Console.ReadLine();

            Compare compare = new Compare();
            bool result = compare.CompareLenght(word1, word2);
            Console.WriteLine(result);
        }
    }
}
