using System;
using System.Linq;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            while (true)
            {

                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                string[] tokens = line.Split(", ");
                string command = tokens[0];
                string number = tokens[1];

                if (command == "IN")
                {
                    set.Add(number);
                }
                else
                {
                    set.Remove(number);
                }
                 
            }
         
            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var n in set)
                {
                    Console.WriteLine(n);
                }
            }
        
        }
    }
}
