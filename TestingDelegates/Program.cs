using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestingDelegates
{
    class Program
    {
       static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilters filters = new PhotoFilters();

            PhotoProcessor.PhotoFiltersHandler filtersHandler = filters.AddColour;
            filtersHandler += filters.ChangeSomething;
            filtersHandler += DestroyQuality;

            processor.Process("gdzies", filtersHandler);

            Console.ReadKey();
        }
        public static void DestroyQuality(Photo photo)
        {
            Console.WriteLine("Quality destroyed");
        }

    }
}
