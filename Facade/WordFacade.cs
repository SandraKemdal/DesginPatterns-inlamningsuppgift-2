using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Facade
{
    class WordFacade
    {
        readonly List<char> one = new();
        readonly List<char> two = new();
        readonly List<char> three = new();
        readonly List<char> four = new();
        readonly List<char> five = new();


        public void Save()
        {
            Console.WriteLine("Write something, It must be 5 characters long: \n");
            string input = Console.ReadLine();

            if (input.Length != 5)
            {
                Console.WriteLine("\nExiting program - Error - The string needs to be EXACTLY 5 characters long");
                Console.ReadKey(true);

            } else {

                one.Add(input[0]);
                two.Add(input[1]);
                three.Add(input[2]);
                four.Add(input[3]);
                five.Add(input[4]);
            }
        }

        public void Load()
        {
            if (one.Count > 0)
            {
                char[] word = { one.Last(), two.Last(), three.Last(), four.Last(), five.Last() };
                Console.WriteLine(word);
            }
        }
    }
}
