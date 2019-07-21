using System;
using System.Collections.Generic;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string> {{"Konrad", "To ja"}, {"Zosia", "Baba z Bydgoszczy"}};

            Console.WriteLine(dictionary["Konrad"] + ", " + dictionary["Zosia"]);

            var number = new Nullable<int>();
            Console.WriteLine("Value of a number: {0}", number.ValueOfObj());
            Console.ReadKey();
        }
    }
}

