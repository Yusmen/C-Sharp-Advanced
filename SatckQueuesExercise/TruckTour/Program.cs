using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> difference = new Queue<int>();
            for (int i = 0; i < n; i++)
            {

                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                difference.Enqueue(numbers[0] - numbers[1]);

            }
            int index = 0;
      


            while(true)
            {
                var copyDifference = new Queue<int>(difference);
                int fuel = -1;
     

                while (copyDifference.Any())
                {
                    if (copyDifference.Peek() > 0 && fuel == -1)
                    {
                        fuel = copyDifference.Dequeue();
                        difference.Enqueue(difference.Dequeue());
                    }
                    else if (copyDifference.Peek() < 0 && fuel == -1)
                    {
                        copyDifference.Enqueue(copyDifference.Dequeue());
                        difference.Enqueue(difference.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copyDifference.Dequeue();
                        if (fuel < 0)
                        {

                           
                            break;
                          
                        }
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                index++;


               
            }
           
        }
    }
}
