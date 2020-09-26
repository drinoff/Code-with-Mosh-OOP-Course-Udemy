using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            DateTime startTime;
            while (true)
            {
                Console.WriteLine("Please press \"Y\" to start the StopWatch");

                var userInput = Console.ReadKey();
                var pressedKey = userInput.KeyChar.ToString();
                if(pressedKey == "Y")
                {
                     startTime = stopWatch.Start();
                }
                Console.WriteLine("Please Press \"N\" to stop the StopWatch");
                userInput = Console.ReadKey();
                pressedKey = userInput.KeyChar.ToString();
                if(pressedKey == "N")
                {
                    stopWatch.Stop(startTime);
                }
                
            }
        }
    }
}
