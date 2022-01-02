using System;

namespace Assignment2.Adapter
{
    internal class ReturningStringsAdapter
    {
        public ReturningStrings ReturningStrings { get; set; }

        public ReturningStringsAdapter()
        {
            ReturningStrings = new ReturningStrings();
        }

        public int ReturnString()
        {
            return Int32.Parse(ReturningStrings.ReturnString());
        }
    }
}