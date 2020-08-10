using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
         var customers = new Queue<string>();
           while (true)
            {
                string customer = Console.ReadLine();
    
                   if (customer == "End")
                   {
                       break;
                   }
                   if (customer == "Paid")
                   {
                       while (customers.Count > 0) 
                       {
                           Console.WriteLine(customers.Dequeue());

                       }

                   }
                   else
                   {
                       customers.Enqueue(customer);
                   }

                   
            }
            Console.WriteLine($"{customers.Count} people remaining.");
            


        }
    }
}
