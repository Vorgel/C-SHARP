
using System;

namespace NullableTypes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime? date = null;
            
            DateTime date2 = date.GetValueOrDefault();

            DateTime? date3 = (date2 == DateTime.Today) ? date2 : date;

            DateTime date4 = date3 ?? new DateTime(5002, 4, 2);

            Console.WriteLine(date4);
            Console.WriteLine(date.GetValueOrDefault());

            Console.WriteLine(returnDefault(date4));
               

            Console.ReadKey();
        }

        public static DateTime returnDefault(DateTime date)
        {
            return default;
        }
    }
}
