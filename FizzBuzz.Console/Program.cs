using System;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var specifications = new Dictionary<int, string>();
            var calculator = new FizzBuzzCalculator();
            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("Input your parameters by typing 'divisor,message'");
            Console.WriteLine("Type 'ready' when finished adding specifications");
            while (true)
            {
                try
                {
                    var input = Console.ReadLine() ?? "";
                    if (input.Equals("ready", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.Write("Enter your starting index:");
                        input = Console.ReadLine() ?? "";
                        var start = int.Parse(input);
                        Console.Write("Enter your ending (exclusive) index:");
                        input = Console.ReadLine() ?? "";
                        var end = int.Parse(input);
                        var result = calculator.Calculate(start, end, specifications);
                        foreach (var entry in result)
                        {
                            Console.WriteLine(entry.Key + "-" + entry.Value);
                        }
                        Console.WriteLine("Thanks for playing! Press enter to quit.");
                        Console.ReadLine();
                        break;
                    }

                    var kvp = ParseKvpInput(input);
                    specifications.Add(kvp.Key, kvp.Value);
                }
                catch(Exception e)
                {
                    Console.WriteLine("Application error: Likely bad input, error: " + e.Message);
                    Console.ReadLine();
                    break;
                }
            }
        }

        private static KeyValuePair<int, string> ParseKvpInput(string input)
        {
            var splitArray = input.Split(',');
            if (splitArray.Length != 2)
                throw new Exception("Bad input");

            var divisor = int.Parse(splitArray[0]);
            var message = splitArray[1];
            return new KeyValuePair<int, string>(divisor, message);
        }
    }
}
