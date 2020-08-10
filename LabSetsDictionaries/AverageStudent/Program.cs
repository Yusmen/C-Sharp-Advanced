using System;
using System.Linq;
using System.Collections.Generic;


namespace AverageStudent
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            int n = int.Parse(Console.ReadLine());

            var grades = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();

                string name = line[0];
                double grade = double.Parse(line[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
   
                
                    grades[name].Add(grade);
                


               
               


            }

            foreach (var kvp in grades)
            {
                string name = kvp.Key;
                var studentGrades = kvp.Value;
                var average = studentGrades.Average();

                Console.WriteLine($"{name} -> {string.Join(" ", studentGrades)} (avg: {average})");

                
                
            }
            

          



            
        }
    }
}
