using System;
using System.Collections.Generic;
using System.Linq;


namespace PartyReservationFiletrModule
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> names = Console.ReadLine().Split().ToList();
            List<string> filters = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Print")
                {
                    break;
                }

                string[] tokens = input.Split(';');

                string command = tokens[0];
                string filterCommand = tokens[1];
                string criteria = tokens[2];
                string filter = filterCommand + "," + criteria;

   
                if (command == "Add filter")
                {
                    filters.Add(filter);

                }
 
                else if (command == "Remove filter")
                {
                    filters.Remove(filter);
                    
                    
                }
               

            }
            foreach (var item in filters)
            {
                string[] tokens = item.Split(',');
                string filterCommand = tokens[0];
                string criteria = tokens[1];
                if (filterCommand == "Starts with")
                {
                    names = names.Where(x => !x.StartsWith(criteria)).ToList();

                }
                else if (filterCommand == "Ends with")
                {
                    names = names.Where(x => !x.EndsWith(criteria)).ToList();


                }
                else if (filterCommand == "Length")
                {
                    names = names.Where(x => !(x.Length==int.Parse(criteria))).ToList();

                }
                else if (filterCommand == "Contains")
                {
                    names = names.Where(x => !x.Contains(criteria)).ToList();

                }
            }

            Console.WriteLine(string.Join(" ", names));
        }

      

    }
}
