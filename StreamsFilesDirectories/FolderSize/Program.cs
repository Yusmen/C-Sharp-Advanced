using System;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("Test");

            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);

                sum += fileinfo.Length;
            }
            Console.WriteLine(sum);
                
                
        }
    }
}
