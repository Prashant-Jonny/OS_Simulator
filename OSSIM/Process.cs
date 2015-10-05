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
        public int logAccumulatedUsage { get; set; }
        public int logIOUsageTime { get; set; }
        public int logEndTime { get; set; }
        public int logSystemTime { get; set; }

        public Process()
        {
        }

        public Process(int ident, int runTimeAverage, int ioTime)
        {
            id = ident;
            Random rnd = new Random();
            cpuUsageTime = rnd.Next(runTimeAverage - 2, runTimeAverage + 2);
            ioUsageTime = ioTime;
            ioStartTime = rnd.Next(2, cpuUsageTime);

            logCPUUsageTime = cpuUsageTime;
            logIOStartTime = ioStartTime;
            logIOUsageTime = ioUsageTime;
        }
    }
}
