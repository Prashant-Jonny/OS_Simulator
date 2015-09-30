using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSIM
{
    class Process
    {
        private int id;
        private int runningTime;
        private int ioUsageTime;

        public Process()
        {
            runningTime = 1;
            ioUsageTime = 1;
        }
    }
}
