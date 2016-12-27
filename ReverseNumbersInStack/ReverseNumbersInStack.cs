using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersInStack
{
    public class ReverseNumbersInStack
    {
        public static void Main()
        {
            var numberStack = new Stack<string>();
            var input = Console.ReadLine();

            if (input != null)
            {
                input.Split(' ')
                .ToList()
                .ForEach(item => numberStack.Push(item));
            }
                
            Console.WriteLine(string.Join(" ", numberStack.Select(num => num.ToString())));
        }
    }
}
