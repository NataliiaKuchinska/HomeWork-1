using System;
using TaskLibWithExpts;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sa = "friday";
            string sb = "monday";
            TaskLib.Swap(ref sa, ref sb);
            Console.WriteLine($"{ sa} , {sb}");
        }
    }
}
