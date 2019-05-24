using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMessage());
        }

        public static string GetMessage()
        {
            return $"Hello World from {GetArchitecture()} CPU";
        }

        private static string GetArchitecture()
        {
            return System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
        }
    }
}
