using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSIM
{
    class Process
    {
        //properties
        public int id { get; set; }
        public int cpuUsageTime { get; set; }
        public int ioUsageTime { get; set; }
        public int ioStartTime { get; set; }

        //logs
        public int logArrivalTime { get; set; }
        public int logCPUUsageTime { get; set; }
        public int logIOStartTime { get; set; }
        public int logIOUsageTime { get; set; }
        public int logEndTime { get; set; }

        public int logAccumulatedUsage { get; set; }
        public int logSystemTime { get; set; }
        public int logWaitTime { get; set; }

        public string status { get; set; }

        public Process()
        {
        }

        public Process(int ident, int runTimeAverage, int ioTime)
        {
            id = ident;
            Random rnd = new Random();
            cpuUsageTime = rnd.Next(runTimeAverage - 2, runTimeAverage + 3);
            ioUsageTime = ioTime;
            ioStartTime = rnd.Next(1, cpuUsageTime-1);

            logCPUUsageTime = cpuUsageTime;
            logIOStartTime = ioStartTime;
            logIOUsageTime = ioUsageTime;
        }

        public void calculateAccumulated(int actualTime)
        {
            if (logEndTime == 0)
                logAccumulatedUsage = actualTime - logArrivalTime;
        }

        public void calculateSystemTime()
        {
            if (logEndTime != 0)
                logSystemTime = logEndTime - logArrivalTime + 1;
        }

        public void calculateWaitTime()
        {
            if (logSystemTime != 0)
                logWaitTime = logSystemTime - logCPUUsageTime - logIOUsageTime;

        }
    }
}
