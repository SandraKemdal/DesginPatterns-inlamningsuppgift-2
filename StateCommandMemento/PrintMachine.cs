using Assignment2.StateCommandMemento.States;
using System;
using System.Collections.Generic;

namespace Assignment2.StateCommandMemento
{
    class PrintMachine : IMachineState, IMachine
    {
        public IMachineState MachineState { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public PrintMachine()
        {
            MachineState = new MachineOffState();
            WordList = new List<MachineCommand>();
        }


        public void PowerSwitch()
        {
            MachineState.PowerSwitch();

            if (MachineState is MachineOffState)
                {
                MachineState = new MachineOnState();
            }
            else
            {
                MachineState = new MachineOffState();
            }
        }

        public void Print(string word)
        {
            Console.WriteLine("\nPrinting.");
            Console.WriteLine($"{word}");
        }

        public MachineMemento CreateMemento()
        {
            return new MachineMemento(this, WordList);
        }

    }
}