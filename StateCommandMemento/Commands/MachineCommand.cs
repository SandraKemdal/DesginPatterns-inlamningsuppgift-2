using Assignment2.StateCommandMemento.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.StateCommandMemento
{
    class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public string Word { get; set; }
        public MachineCommand(IMachine machine, string word)
        {
            Machine = machine;
            Word = word;
        }
        public void Execute()
        {
            Machine.Print(Word);
        }
    }
}
