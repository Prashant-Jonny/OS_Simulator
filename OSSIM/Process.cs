using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSIM
{
    class Process
    {
        public int id { get; set; }
        private int runningTime { get; set; }
        private int ioUsageTime { get; set; }
        private int ioStartTime { get; set; }

        public Process()
        {
            runningTime = 5;
            ioUsageTime = 2;
            ioStartTime = 2;
        }

        public Process(int id, int runTimeAverage, int ioTime)
        {
            Random rnd = new Random();
            runningTime = rnd.Next(runTimeAverage - 2, runTimeAverage + 2);
            ioUsageTime = ioTime;
            ioStartTime = rnd.Next(2, runningTime);
        }
    }
}
