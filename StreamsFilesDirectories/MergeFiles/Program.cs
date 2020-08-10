using System;
using System.IO;
using System.Collections.Generic;


namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            using (var reader = new StreamReader("FileOne.txt"))
            {

                while(true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    int number = int.Parse(line);
                    list.Add(number);
                    
                }
            }

            using (var reader = new StreamReader("FileTwo.txt"))
            {

                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    int number = int.Parse(line);
                    list.Add(number);

                }
            }
            list.Sort();
            using (var writer = new StreamWriter("Output.txt"))
            {
                foreach(var number in list)
                {
                    writer.WriteLine(number);
                }

            }


        }
    }
}
