using System;
using System.IO;

namespace ScribbleScrubber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Serialize(Process(File.ReadAllLines("path"))));
        }
        private static string[] Process(string[] input)
        {
            string[] output = new string[input.Length];
            for(int i =0; i < input.Length; i++)
                output[i] = input[i].Split('-')[1].Trim();
            return output;
        }
        private static string Serialize(string[] input)
        {
            string output = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                    output += input[i] + ", ";
                else
                    output += input[i];
            }
            return output;
        }
    }
}
