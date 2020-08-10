using System;
using System.Collections.Generic;

namespace BalancedParenthess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            if (input.Length == 2)
            {

                if (input[0] == '}')
                {
                    if (input[1] == '{')
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (input[0] == ')')
                {
                    if (input[1] == '(')
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (input[0] == ']')
                {
                    if (input[1] == '[')
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }




            }
            var stack = new Stack<char>(input);
            var queue = new Queue<char>(input);
            var list = new List<char>();
      
  
            for (int i = 0; i < stack.Count / 2; i++) 
            {
                list.Add(stack.Pop());
                list.Add(queue.Dequeue());
                char firstSymbol = list[0];
                char secondSymbol = list[1];

               if(firstSymbol=='}')
                {
                    if (secondSymbol == '{')
                    {
                        list.Clear();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                        
                       
              else if(firstSymbol==')')
                {
                    if (secondSymbol == '(')
                    {
                        list.Clear();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                        
                        
              else if(firstSymbol==']')
                {
                    if (secondSymbol == '[')
                    {
                        list.Clear();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
             

            }
                        
                Console.WriteLine("YES");

            
           
           


          
            
        }
    }
}
