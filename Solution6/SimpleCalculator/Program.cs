using System;
using System.Collections.Generic;
using System.Linq;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Stack<string> symbols = new Stack<string>(input.Reverse());


            int result = int.Parse(symbols.Pop());

            while (symbols.Any())
            {
                var nextSymbol = symbols.Pop();

                if (nextSymbol == "+")
                {
                    int number = int.Parse(symbols.Pop());
                    result +=number;
                }
                else if (nextSymbol == "-") 
                {
                    int number = int.Parse(symbols.Pop());
                    result -=number;
                }
            }
            Console.WriteLine(result);



       
        }
    }
}
