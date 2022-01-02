using Assignment2.StateCommandMemento.States;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Assignment2.StateCommandMemento
{
    class MachineMemento
    {
        public PrintMachine Printer { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public MachineMemento(PrintMachine printer, List<MachineCommand> wordList)
        {
            Printer = printer;
            WordList = wordList;
        }

        public void Reset()
        {
            Console.WriteLine("\nReseting list and turning it off.");
            Printer.WordList.Clear();
            Printer.MachineState = new MachineOffState();

        }
    }
}