using System;
using System.Linq;
using System.Collections.Generic;


namespace FUNCTIONAL_PROGRAMMING
{
    class PartyReservationFilterMode
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            List<string> filteredNames = new List<string>();

            string command;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }
                else
                {
                    string[] arrOfCommands = command.Split(';');
                    string filterType = arrOfCommands[1];
                    string parameter = arrOfCommands[2];

                    if (arrOfCommands[0].Contains("Add"))
                    {
                        filteredNames.Add($"{filterType}:{parameter}");
                    }
                    else if (arrOfCommands[0].Contains("Remove"))
                    {
                        filteredNames.Remove($"{filterType}:{parameter}");
                    }
                }

            }

            foreach (var item in filteredNames)
            {
                string[] typeOfFilter = item.Split(":");
                string filter = typeOfFilter[0];
                // if (x[0] == parameter
                switch (filter)
                {
                    case "Starts with"
                            :
                        string parameter = typeOfFilter[1];
                        invitations = invitations.Where(name => StartsWithFilter(name, parameter)).ToList();
                        break;
                    case "Ends with"
                            :
                        string symbol = typeOfFilter[1];
                        invitations = invitations.Where(name => EndsWithFilter(name, symbol)).ToList();
                        break;
                    case "Length"
                            :
                        int numbersToDelete = int.Parse(typeOfFilter[1]);
                        invitations = invitations.Where(name => LengthFunc(name, numbersToDelete)).ToList();
                        break;
                    case "Contains"
                           :
                        string symbolToRemove = typeOfFilter[1];
                        invitations = invitations.Where(name => Contains(name, symbolToRemove)).ToList();
                        break;


                }
            }
            Console.WriteLine(string.Join(" ", invitations));

        }

        static Func<string, string, bool> StartsWithFilter = (name, parameter) => !name.StartsWith(parameter);
        static Func<string, string, bool> EndsWithFilter = (name, parameter) => !name.EndsWith(parameter);
        static Func<string, int, bool> LengthFunc = (name, lengh) => name.Length != lengh;
        static Func<string, string, bool> Contains = (name, symbol) => !name.Contains(symbol);  
    }
}



