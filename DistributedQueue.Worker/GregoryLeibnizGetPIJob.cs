using System;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class GregoryLeibnizGetPIJob : IComputePiJob
    {
        public Task ComputePyAsync(string name, int iterrations, CancellationToken token)
        {

            var startTime = DateTime.Now;
            string[] strings = {
                    "Black",
                    "DarkBlue",
                    "DarkGreen",
                    "DarkCyan",
                    "DarkRed",
                    "DarkMagenta",
                    "DarkYellow",
                    "Gray",
                    "DarkGray",
                    "Blue",
                    "Green",
                    "Cyan",
                    "Red",
                    "Magenta",
                    "Yellow",
                    "White"
                };
            int color = 0;
            Random r = new Random();
            for (int i = 0; i < iterrations; i++)
            {
                
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine($"{DateTime.Now}: Compute task: {name} Now {strings[i%16]} on iterration: {i}");
                color++;
                if(color > 15) color = 0;

                Thread.Sleep(50);
            }
            
            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine("################################");
            Console.WriteLine("################################");
            Console.ForegroundColor = (ConsoleColor)9;
            Console.WriteLine("################################");
            Console.WriteLine("################################");
            Console.ForegroundColor = (ConsoleColor)12;
            Console.WriteLine("################################");
            Console.WriteLine("################################");
            Console.ForegroundColor = (ConsoleColor)15;
            Console.WriteLine($"Nane potoka: {name}, Iterrations: {iterrations}");

            return Task.CompletedTask;
        }
    }
}
