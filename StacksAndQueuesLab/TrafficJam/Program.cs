using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int br = 0;
            while (true)
            {
                string car = Console.ReadLine();
                if (car == "end")
                {
                    break;
                }

                if (car == "green")
                {
                    if(cars.Count>=n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            br++;

                        }

                    }
                    else
                    {
                        while (cars.Count != 0) 
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            br++;

                        }

                    }
                    

                }
                else
                {
                    cars.Enqueue(car);
                }

            }
            Console.WriteLine($"{br} cars passed the crossroads.");
      
        }
    }
}
