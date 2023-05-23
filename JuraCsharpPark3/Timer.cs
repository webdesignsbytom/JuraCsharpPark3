using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace JuraCsharpPark3
{
    internal class Timer
    {
        public int TimeElapsed { get; set; } = 0;
        public bool TimerStarted { get; set; } = true;

        public Timer()
        {
            // Create timer instance
            System.Timers.Timer timer = new(interval: 1000);
            timer.Elapsed += (sender, e) => HandleTimer();
            timer.Start();

            AlphaGame game = new AlphaGame();


            void HandleTimer()
            {
                TimeElapsed++;
                Console.WriteLine(TimeElapsed);

                if (TimeElapsed > 10)
                {
                    EndTimer();
                    return;
                }
            }

            void EndTimer()
            {
                Console.WriteLine("Out of Time!");
                TimerStarted = false;
                timer.Stop();
                timer.Dispose();
                Console.WriteLine("Press Enter To Continue");
                
                return;
            }

            return;
        }
    }
}
