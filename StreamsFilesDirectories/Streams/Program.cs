using System;
using System.IO;
using System.Text;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {


            string line = Console.ReadLine();
            var arr = line.ToCharArray();
            arr.R
            Console.WriteLine(line);            
            
            /*
            using (var fs = new FileStream("SomeFile.txt", FileMode.Create))
            {

                var buffer = Encoding.UTF8.GetBytes("Something new!!!!!");
                fs.Write(buffer, 0, buffer.Length);
            }*/





     

           /*
            using (var reader = new StreamReader("Input.txt")) 
            {
                int count = 0;
                while (true)
                {

                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }


                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    count++;


                }


                

            }*/
         
            
           
           


        }
    }
}
