using System;
using System.Linq;
using System.Collections.Generic;

namespace aPpliedArtihmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

          



            while (true)
            {

                Func<int, int> func;
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                if (input == "add")
                {

                    func = number => number + 1;
                    for (int i = 0; i < list.Count; i++)
                    {

                        list[i]=func(list[i]);
                    }


                }
                else if (input == "multiply")
                {

                    func = number => number * 2;
                    for (int i = 0; i < list.Count; i++)
                    {

                        list[i] = func(list[i]);
                    }
                }
                else if (input == "subtract")
                {

                    func = number => number - 1;
                    for (int i = 0; i < list.Count; i++)
                    {

                        list[i] = func(list[i]);
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(" ",list));

                }
               
             
                    
                        
                        



            }
                
                
                
        }
    }
}
