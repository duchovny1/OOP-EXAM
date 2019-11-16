namespace List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int upperbound = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1 , upperbound).ToList();
            List<int> divisibleNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToList();
            for (int i = 0; i < divisibleNumbers.Count; i++)
            {
                Predicate<int> isDivisible = num => { return num % divisibleNumbers[i] == 0; };
                numbers = numbers.FindAll(isDivisible);
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
