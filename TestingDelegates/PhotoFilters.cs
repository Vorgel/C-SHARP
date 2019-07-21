using System;

namespace TestingDelegates
{
    class PhotoFilters
    {
        public void AddColour(Photo photo)
        {
            Console.WriteLine("Adding Colour");
        }

        public void ChangeSomething(Photo photo)
        {
            Console.WriteLine("Changing something");
        }
    }
}