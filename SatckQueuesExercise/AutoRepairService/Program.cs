using System;
using System.Collections.Generic;
using System.Linq;


namespace AutoRepairService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> cars = new Queue<string>(line);

            List<string> served = new List<string>();
            bool isUsed = false;
            int flag = 0;
           
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split('-');
                string command = tokens[0];

                if (command == "Service")
                {
                    if (cars.Count != 0)
                    {
                        string car = cars.Dequeue();
                        Console.WriteLine($"Vehicle {car} got served.");
                        served.Add(car);
                    }
                    if (isUsed)
                    {
                        flag = 1;
                    }
                        
                  
                }
                else if (command == "CarInfo")
                {
                    string car = tokens[1];

                    if (served.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                    if (cars.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }

                }
                else if (command == "History")
                {
                    served.Reverse();
                    Console.WriteLine(string.Join(", ", served));
                    isUsed = true;
                 
                }
                        

                
            }
            if(!isUsed)
            {
                served.Reverse();
            }
            if (isUsed == true && flag == 1)
            {
                served.Reverse();
            }

            if (cars.Count != 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", cars)}");
            }
      
         
            Console.WriteLine($"Served vehicles: {string.Join(", ", served)}");

        }
    }
}
