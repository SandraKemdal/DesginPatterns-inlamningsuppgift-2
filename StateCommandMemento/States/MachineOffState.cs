using System;

namespace Assignment2.StateCommandMemento.States
{
    internal class MachineOffState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning machine on.");
        }
    }
}