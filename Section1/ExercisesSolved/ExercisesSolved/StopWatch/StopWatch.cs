using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace StopWatch
{
   public class StopWatch
    {
        public bool isStarted { get; private set; }
        public TimeSpan duration { get; private set; }

        public  DateTime Start()
        {
            this.duration = TimeSpan.Zero; 
            if (this.isStarted == true)
            {
               throw new InvalidOperationException(message: "StopWatch is alread Started");
            }
            this.isStarted = true;
            return DateTime.Now;
            
        }

        public  TimeSpan Stop(DateTime startTime)
        {
            if(this.isStarted == false)
            {
                throw new InvalidOperationException(message: "StopWatch is already Stopped");
            }
            this.isStarted = false;
            return this.duration = DateTime.Now - startTime;
            
        }
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
        public  bool  Status()
        {
            return this.isStarted;
        }
    }
}
