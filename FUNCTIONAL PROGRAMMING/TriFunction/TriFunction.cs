using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int givenNumbers = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> largerNumbers = (x, y) => x.Sum(b => b) >= y;

            names = names.Where(name => largerNumbers(name, givenNumbers)).ToList();

            if (names.Count != 0)
            {
                Console.WriteLine(names[0]);
            }

        }
    }
}
