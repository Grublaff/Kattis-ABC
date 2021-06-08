using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis_ABC
{
    internal class Program
    {
        private static void Main()
        {
            List<string> inputList = new List<string>(Console.ReadLine().Split(" "));
            List<int> input = inputList.Select(s => int.Parse(s)).ToList();
            string order = Console.ReadLine();
            input.Sort();
            string temp = string.Empty;

            foreach (char item in order)
            {
                if (item.ToString() == "A")
                {
                    temp += input[0] + " ";
                }
                if (item.ToString() == "B")
                {
                    temp += input[1] + " ";
                }
                if (item.ToString() == "C")
                {
                    temp += input[2] + " ";
                }
            }
            Console.WriteLine(temp);
        }
    }
}