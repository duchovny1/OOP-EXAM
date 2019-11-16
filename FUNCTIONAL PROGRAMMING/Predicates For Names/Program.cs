
namespace Predicates_For_Names
{
    using System;
    using System.Linq;
    using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split().ToList();

            Predicate<string> eachName = x => x.Length <= number;

            names = names.Where(name => eachName(name)).ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
