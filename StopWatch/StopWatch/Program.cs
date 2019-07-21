using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARP
{
    class Stopwatch
    {
        public bool Active { get; set; }

        public bool EverStarted { get; set; }

        public DateTime DateStart { get; set; }

        private readonly List<decimal> _laps = new List<decimal>();

        public void Start()
        {
            if (!EverStarted)
            {
                EverStarted = true;
                Active = true;
                DateStart = DateTime.Now;
            }
            else
                WrongButton("start");
        }

        public void Stop()
        {
            if (Active)
            {
                Active = false;
                var diffrence = DateTime.Now - DateStart;
                Console.WriteLine("{0} - Stopping the watch.", diffrence.TotalSeconds);
            }
            else
                WrongButton("stop");
        }

        public void ClockContinue()
        {
            if (EverStarted && !Active)
                Active = true;
            else
                WrongButton("continue");
        }

        public void Reset()
        {
            if (EverStarted)
            {
                _laps.Clear();
                Active = false;
                EverStarted = false;
            }
            else
                WrongButton("reset");
        }

        public void Lap()
        {
            if (EverStarted)
            {
                var diffrence = DateTime.Now - DateStart;
                _laps.Add(Convert.ToDecimal(diffrence.TotalSeconds));
                Console.WriteLine("{0} - New lap added.", diffrence.TotalSeconds);
            }
            else
                WrongButton("lap");
        }

        public void PrintLap()
        {
            Console.WriteLine("\nLaps:");

            foreach (var lap in _laps)
                Console.WriteLine(lap);
        }

        private void WrongButton(string functionName)
        {
            Console.WriteLine($"Wrong button fella ({functionName})");
            System.Threading.Thread.Sleep(3000);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var run = true;

            while (run)
            {
                Console.WriteLine("1. Start\n2. Lap\n3. Continue\n4. Stop\n5. Finish");

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        watch.Start();
                        break;
                    case '2':
                        watch.Lap();
                        break;
                    case '3':
                        watch.ClockContinue();
                        break;
                    case '4':
                        watch.Stop();
                        break;
                    case '5':
                        run = false;
                        break;
                }

                Console.Clear();
            }

            watch.PrintLap();
            Console.ReadKey();
        }
    }
}