using Assignment2.StateCommandMemento.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento.Commands
{
    class CommandManager
    {
        public PrintMachine Printer { get; set; }
        public CommandManager(PrintMachine printer)
        {
            Printer = printer;
        }


        public void Execute(string userInput)
        {
            var word = new MachineCommand(Printer, userInput);

            if (Printer.MachineState is MachineOffState)
            {
                Printer.WordList.Add(word);
                Console.WriteLine("\nPrinter is off. Saving word until printer is on.");
            }
            else
            {
                word.Execute();
            }
        }
    }
}
