using System;
using System.Collections.Generic;
using System.Text;

namespace Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var versions = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                int command = int.Parse(tokens[0]);

                switch(command)
                {
                    case 1:
                        versions.Push(text.ToString());
                        string textToAdd = tokens[1];
                        text.Append(textToAdd);
                        break;
                    case 2:
                        versions.Push(text.ToString());
                        int removeCount = int.Parse(tokens[1]);
                        text.Remove(text.Length - removeCount, removeCount);
                        break;

                    case 3:
                        int index = int.Parse(tokens[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(versions.Pop());
                        break;

                    default:
                        break;

                }
            

            }

        }
    }
}
