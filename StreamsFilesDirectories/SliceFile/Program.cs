using System;
using System.IO;

namespace SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {

            int fileCount = int.Parse(Console.ReadLine());

            using (var fs = new FileStream("sliceMe.txt",FileMode.Open))
            {

                var partLength = Math.Ceiling((double)fs.Length / fileCount);

                for (int i = 1; i <= fileCount; i++) 
                {

                    var currentName = $"slice-{i}.txt";
                    var currentFileTotalBytes = 0;
                    using (var writer = new FileStream(currentName, FileMode.Create))
                    {

                        while (true)
                        {
                            var buffer = new byte[4096];

                            var total = fs.Read(buffer, 0, buffer.Length);
                            if (total == 0)
                            {
                                break;
                            }

                            currentFileTotalBytes += total;

         
                              writer.Write(buffer, 0, total);
                            if (currentFileTotalBytes >= partLength)
                            {
                                break;
                            }


                        }

                    }

                      


                }
            }
            
        }
    }
}
