using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWolrd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check if any arguments are provided
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments were provided.");
                return;
            }

            // Print all provided arguments
            Console.WriteLine("Provided Arguments:");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            // Example operation: Perform actions based on specific arguments
            if (args.Contains("hello"))
            {
                Console.WriteLine("Hello, world!");
            }
            else if (args.Contains("bye"))
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Undefined arguments were provided.");
            }
        }
    }
}
