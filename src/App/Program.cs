﻿using System;

namespace App
{
    public class Program
    {
        public static object Get { get; set; }

        public static int Main(string[] args)
        {
            Console.WriteLine(GetMessage());
            return 0;
        }

        public static string GetMessage()
        {
            return "Hello World!";
        }
    }
}