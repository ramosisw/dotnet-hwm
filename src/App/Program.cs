using System;
using System.Runtime.InteropServices;

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

        public static string GetArchitecture()
        {
            return RuntimeInformation.ProcessArchitecture.ToString();
        }
    }
}
