using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Func<string, char[]> funcTocharArr = x => x.ToCharArray();
            Func<char, int> castFunc = y => (int)y;
            Func<string,bool> final= x => funcTocharArr(x).Select(castFunc).Sum() >= number;

            Console.WriteLine(Console.ReadLine().Split().FirstOrDefault(final));
         
        }
    }
}
