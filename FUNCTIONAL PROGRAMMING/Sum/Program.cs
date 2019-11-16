using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    class AppliedArithmetics 
    {
        public delegate int Calculator(List<int> x);

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            Func<int, int> Add = x => x += 1;
            Func<int, int> Multiply = x => x *= 2;
            Func<int, int> Subtract = x => x -= 1;
            Action<List<int>> Print = x => Console.WriteLine(string.Join(" ", x)); ;
           
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add"
                        :
                        numbers = numbers.Select(Add).ToList();
                        break;
                    case "multiply"
                        :
                        numbers = numbers.Select(Multiply).ToList();
                        break;
                    case "subtract"
                        :
                        numbers = numbers.Select(Subtract).ToList();
                        break;
                    case "print"
                        :
                        Print(numbers);
                        break;
                }

            }
        }

       

    }
}
