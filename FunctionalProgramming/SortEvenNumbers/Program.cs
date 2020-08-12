using System;
using System.Linq;
using System.IO;


namespace SortEvenNumbers
{
    class Program
    {
        

        static void Main()
        {


            /*  var list = Console.ReadLine()
                  .Split(", ")
                  .Select(int.Parse)
                  .Where(x => x % 2 == 0)
                  .OrderBy(x => x)
                  .ToList();

              Console.WriteLine(string.Join(", ", list));*/

            Log("Error: Something went wrong!!", msg=>Console.WriteLine(msg));

            Log("Everything works!", msg => File.WriteAllText("log.txt", msg));




      
           

        }
        public static void Log(string message,Action<string> logAction)
        {

            if(message.StartsWith("Error"))
            {
                message = message.ToUpper();
            }
            else
            {
                message = $"Warning: {message}";
            }

            logAction(message);
        }
            
            


        
 
        
    }

   
}
