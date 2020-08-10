using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            var extentions = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                if (!extentions.ContainsKey(info.Extension))
                {
                    extentions[info.Extension] = new List<FileInfo>();
                }
                extentions[info.Extension].Add(info);

            }
            using (var writer = new StreamWriter("report.txt"))
            {

                foreach (var kvp in extentions.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
                {
                    string ext = kvp.Key;
                    var info = kvp.Value;
                    writer.WriteLine(ext);
                    foreach (var fileinfo in info.OrderByDescending(x=>x.Length))
                    {

                        string name = fileinfo.Name;
                        double size = fileinfo.Length;

                        writer.WriteLine($"--{name} - {size:f3}kb");
                    }
                }


            }

               
                    
        }
    }
}
