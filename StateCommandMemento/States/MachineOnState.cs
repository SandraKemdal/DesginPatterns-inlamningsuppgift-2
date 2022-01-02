using System;

namespace Assignment2.StateCommandMemento.States
{
    internal class MachineOnState : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning machine off.");
        }
    }
}