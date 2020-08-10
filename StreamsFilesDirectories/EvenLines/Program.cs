using System;
using System.IO;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int count = 1;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        if (count % 2 != 0)
                        {



                            line.Replace(" ", "@");
                            Console.WriteLine(line);

                            string[] arr = line.Split();
                            Array.Reverse(arr);
                            writer.WriteLine(string.Join(" ", arr));



                        }
                        count++;

                    }
                    
                        

                }
            }

            
        }
    }
}
