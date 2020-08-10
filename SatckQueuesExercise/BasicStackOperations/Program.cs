using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = command[0];
            int s = command[1];
            int x = command[2];
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            int min = int.MaxValue;
            bool isfound= false;
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            while (stack.Count > 0)
            {
                int number = stack.Pop();
                if (number == x) 
                {
                    Console.WriteLine("true");
                    isfound = true;
                    break;

                }
                else
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    
                }
            }
           
            if(!isfound)
            {
                if(min==int.MaxValue)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(min);
                }
                
          
                  
            }




            
        }
    }
}
