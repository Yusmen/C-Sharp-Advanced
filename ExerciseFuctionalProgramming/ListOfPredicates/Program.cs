using System;
using System.Collections.Generic;
using System.Linq;


namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i <= number; i++) 
            {
                CheckNumber(list, i);
            }


        }
        public static void CheckNumber(List<int> list, int n)
        {

            bool isPossible = true;


            for (int i = 0; i < list.Count; i++)
            {
                if (n % list[i] != 0)
                {
                    isPossible = false;
                    break;
                }

            }

            if(isPossible)
            {
                Console.Write(n + " ");
            }
                    
                  
        }
    }
}
