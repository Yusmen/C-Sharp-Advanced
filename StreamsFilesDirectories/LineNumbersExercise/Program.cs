using System;
using System.IO;

namespace LineNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt")) 
                {


                    while (true)
                    {
                        int countLetters = 0;
                        int countpSigns = 0;
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }
                        var arr = line.ToCharArray();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] >= 'A' && arr[i] <= 'Z' || arr[i] >= 'a' && arr[i] <= 'z')
                            {

                                countLetters++;
                            }
                            if (arr[i] == '.' || arr[i] == ',' || arr[i] == '!' || arr[i] == '?' || arr[i] == '\''||arr[i]=='-')
                            {

                                countpSigns++;
                            }
                        }
                        
                        writer.WriteLine($"Line {count}: {string.Join("",arr)} ({countLetters})({countpSigns})");
                         count++;
                    }


                }
                   
            }
        }
    }
}
