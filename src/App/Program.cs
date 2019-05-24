using System;

namespace App
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.WriteLine(GetMessage());

            return 0;
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
