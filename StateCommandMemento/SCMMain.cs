using Assignment2.StateCommandMemento.Commands;
using System;

namespace Assignment2.StateCommandMemento
{
    internal class SCMMain
    {
        /*
         * Skapa en maskin som kan vara av eller på. !Använd State Pattern!
         * Om man ger den ett kommando när den är av så ska den spara det kommandot och sen köra alla sparade kommandon när den sätts på. !Använd Command Pattern!
         * Kommandot ska vara att skriva ut en sträng text som användaren anger.
         * Det ska också finnas en reset funktion som tar bort alla sparade kommandon och stänger av maskinen. !Använd Memento Pattern!
         */
        public void Run()
        {
            PrintMachine printer = new();
            var commandManager = new CommandManager(printer);
            MachineMemento machineMemento = printer.CreateMemento();

            Console.WriteLine("\n--- Machine Commands ---\n");
            Console.WriteLine("Press enter to print text");
            Console.WriteLine("Press A to turn On Machine");
            Console.WriteLine("Press B for reset and turn Off Machine");
            Console.WriteLine("Press Space to Exit Program\n");

            while (true)
            {
                var userInput = Console.ReadKey(true).Key;

                switch (userInput)      
                {
                    case ConsoleKey.Enter:
                        Console.WriteLine("Enter text to print here: ");
                        var userWord = Console.ReadLine();
                        commandManager.Execute(userWord);
                        break;
                    case ConsoleKey.A:
                        printer.PowerSwitch();
                        foreach(var word in printer.WordList)
                        {
                            commandManager.Execute(word.Word);
                        }
                        printer.WordList.Clear();
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("\nReset and turn off.");
                        machineMemento.Reset();
                        break;
                    case ConsoleKey.Spacebar:
                        Console.WriteLine("\nExiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nUnkown command, please try again\n");
                        break;
                }
            }
        }
    }
}