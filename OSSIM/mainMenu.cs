using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSSIM
{
    public partial class mainMenu : Form
    {
        delegate void SetTextCallback(int time);
        List<Process> Processes = new List<Process>();
        private int clock;
        Random rnd = new Random();
        /*List<String> newProcess = new List<String>();
        List<String> ready = new List<String>();
        List<String> running = new List<String>();
        List<String> waiting = new List<String>();
        List<String> usingIO = new List<String>();
        List<String> finished = new List<String>();*/
        Queue<Process> newQueue = new Queue<Process>();
        Queue<Process> readyQueue = new Queue<Process>();
        Queue<Process> runningQueue = new Queue<Process>();
        Queue<Process> waitingQueue = new Queue<Process>();
        Queue<Process> usingIOQueue = new Queue<Process>();
        Queue<Process> finishedQueue = new Queue<Process>();


        public mainMenu()
        {
            InitializeComponent();
            aTimer.Interval = 1000;
            clock = 0;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!aTimer.Enabled)
            {
                aTimer.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (aTimer.Enabled)
            {
                aTimer.Stop();
            }
            clearQueues();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (aTimer.Enabled)
            {
                aTimer.Stop();
            }
        }

        private void speedSlow_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 2000;
        }

        private void speedMedium_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 1000;
        }

        private void speedFast_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 500;
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            updateClock();

            /*
             * 
             * This is a FIFO approach to the process management.
             * 
            */


            // Creates new process depending on the probability (%) and if the new process list limit is not being passed
            // with the parameters on CPU average usage time and IO usage time
            if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && newQueue.Count < Int32.Parse(limitNewBox.Text))
            {
                Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                temp.logArrivalTime = clock;
                Processes.Add(temp);
                newQueue.Enqueue(temp);
            }


            // Enqueues a process into the readyQueue if it's not going over the limit and the newQueue has more than 0 elements
            if (readyQueue.Count < Int32.Parse(limitReadyBox.Text) && newQueue.Count > 0)
            {
                readyQueue.Enqueue(newQueue.Dequeue());
            }


            // Enqueues a process into the runningQueue if it's empty
            // else it continues running the process that's already inside
            if (runningQueue.Count < 1 && readyQueue.Count > 0)
            {
                runningQueue.Enqueue(readyQueue.Dequeue());
            }
            else if (runningQueue.Count > 0)
            {
                Process temp = runningQueue.Peek();

                // Enqueues a process into the finishedQueue if it no longer needs to use the CPU
                // else it lowers the value of cpuUsageTime which represents how long it needs to be running
                if (temp.cpuUsageTime == 0)
                {
                    finishedQueue.Enqueue(runningQueue.Dequeue());
                }
                else
                    temp.cpuUsageTime -= 1;

                // Enqueues a process into the waitingQueue if it needs to use an I/O device
                // else it lowers the value of ioStartTime which represents when it's going to need to use an I/O device
                if (temp.ioStartTime == 0)
                {
                    // It lowers the value to -1 so that next time it comes to the runningQueue it doesn't go
                    // through this "if"
                    temp.ioStartTime -= 1;
                    waitingQueue.Enqueue(runningQueue.Dequeue());
                }
                else
                    temp.ioStartTime -= 1;

            }


            // Enqueues a process into usingIOQueue if it's empty
            // else it continues processing the I/O device usage
            if (usingIOQueue.Count < 1 && waitingQueue.Count > 0)
            {
                usingIOQueue.Enqueue(waitingQueue.Dequeue());
            }
            else if (usingIOQueue.Count > 0)
            {
                Process temp = usingIOQueue.Peek();

                // Enqueues a process into the readyQueue if it's done using the I/O device
                // else it lowers the value of ioUsageTime which represents how long it needs to be using an I/O device
                if (temp.ioUsageTime == 0)
                {
                    readyQueue.Enqueue(usingIOQueue.Dequeue());
                }
                else
                    temp.ioUsageTime -= 1;
            }
        }

        private void updateClock()
        {
            clock++;
            clockNumLabel.Text = clock.ToString();
        }

        private void updateText()
        {

        }

        private string displayMembers()
        {
            foreach (Process p in newQueue)
            {
                return p.id.ToString();
            }
            return null;
        }

        private void clearQueues()
        {
            newQueue.Clear();
            readyQueue.Clear();
            runningQueue.Clear();
            waitingQueue.Clear();
            usingIOQueue.Clear();
            finishedQueue.Clear();
        }
    }
}
