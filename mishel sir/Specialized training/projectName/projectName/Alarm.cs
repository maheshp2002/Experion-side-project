using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectName
{
    internal class Alarm
    {
        public delegate void TaskDelegate();
        public Alarm(int timeInterval, TaskDelegate task)
        {
            Thread.Sleep(timeInterval * 1000);
            Console.Beep();
            task();
            //Console.WriteLine(message);
        }

    }
}
