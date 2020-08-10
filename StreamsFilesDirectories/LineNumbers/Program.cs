using System;
using System.IO;


namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt", true, System.Text.Encoding.UTF8))
                {

                    int counter = 1;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {

                            break;
                        }

                        line = $"{counter}. {line}";
                        counter++;




                        writer.WriteLine(line);

                    }

                }
                 

            }
        }
    }
}
