using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSIM
{
    class Process
    {
        private int id { get; set; }
        private int runningTime { get; set; }
        private int ioUsageTime { get; set; }
        private int ioStartTime { get; set; }

        public Process()
        {
            runningTime = 5;
            ioUsageTime = 2;
            ioStartTime = 2;
        }

        public Process(int identificator, int runTimeAverage, int ioTimeAverage)
        {

        }
    }
}
