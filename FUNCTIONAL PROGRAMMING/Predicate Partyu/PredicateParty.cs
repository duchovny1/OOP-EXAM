namespace PredicateParty
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class PredicateParty
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList()
                ;

            string command;

            Func<string, string,  bool> FuncStartsWith = (x, y) => x.StartsWith(y);

            while ((command = Console.ReadLine()) != "Party!")
            {
                if (command.Contains("Double"))
                {
                    string[] inputOfCommands = command.Split();
                    string currentCommand = inputOfCommands[1];
                    string infoForCommand = inputOfCommands[2];
                    switch (currentCommand)
                    {
                        case "StartsWith"
                            :
                            names = names.Where(name , infoForCommand => FuncStartsWith).ToList();
                            break;
                        case "EndsWith"
                            :
                            break;
                        case "Length"
                            :
                            break;

                    }

                }
                else if (command.Contains("Remove"))
                {
                    string[] inputOfCommands = command.Split();
                    string currentCommand = inputOfCommands[1];
                    string infoForCommand = inputOfCommands[2];
                    switch (currentCommand)
                    {
                        case "StartsWith"
                            :
                            break;
                        case "EndsWith"
                            :
                            break;
                        case "Length"
                            :
                            break;

                    }
                }
            }

        }
    }
}
