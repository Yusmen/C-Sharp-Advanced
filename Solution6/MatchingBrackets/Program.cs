using System;
using System.Collections.Generic;
using System.Linq;


namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
  
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                     stack.Push(i);
                  
                }
                else if (ch == ')') 
                {
                     int startindex = stack.Pop();

               
                    string content = input.Substring(startindex, i - startindex + 1);
                    Console.WriteLine(content);
                  


                }

            }


        }
    }
}
