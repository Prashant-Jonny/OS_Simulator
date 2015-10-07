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
        private int quantum;
        private bool pause;
        Random rnd = new Random();
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
            clockNumLabel.Text = "0";
            quantum = 0;
            quantumNumLabel.Text = "0";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!aTimer.Enabled)
            {
                aTimer.Start();
                pause = false;
            }
            disableParameters();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (aTimer.Enabled)
            {
                aTimer.Stop();
            }
            clear();
            enableParameters();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (aTimer.Enabled)
            {
                pause = true;
            }
            enableParameters();
        }

        private void speedSlow_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 1500;
        }

        private void speedMedium_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 750;
        }

        private void speedFast_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 250;
        }

        // Where the magic happens
        private void aTimer_Tick(object sender, EventArgs e)
        {

            updateClock();
            if (comboAlgorithm.Text == "FIFO")
                FIFO();
            else if (comboAlgorithm.Text == "RR")
                RoundRobin();
            else
            {
                parameterError("Error in algorithm parameter!");
            }

            updateText();

            if (pause == true)
            {
                aTimer.Stop();
            }

        }

        private void updateClock()
        {
            clock++;
            clockNumLabel.Text = clock.ToString();
            try
            {
                if (clock % Int32.Parse(quantumBox.Text) == 0)
                    quantum++;
                quantumNumLabel.Text = quantum.ToString();
            }
            catch (FormatException e)
            {
                parameterError("Error in Quantum parameter!");
            }
            
        }

        private void updateText()
        {
            boxNew.Text = displayMembers(newQueue);
            boxReady.Text = displayMembers(readyQueue);
            boxRunning.Text = displayMembers(runningQueue);
            boxUsingIO.Text = displayMembers(usingIOQueue);
            boxWaiting.Text = displayMembers(waitingQueue);
            boxFinished.Text = displayMembers(finishedQueue);
        }


        private string displayMembers(Queue<Process> Queue)
        {
            string temp = "";

            foreach (Process p in Queue)
            {
                temp += p.id.ToString();
                temp += "\r\n";
            }

            return temp;
        }


        // Deletes every value from the objects and clears the text boxes.
        private void clear()
        {
            quantum = 0;
            quantumNumLabel.Text = quantum.ToString();

            clock = 0;
            clockNumLabel.Text = clock.ToString();

            Processes.Clear();

            newQueue.Clear();
            readyQueue.Clear();
            runningQueue.Clear();
            waitingQueue.Clear();
            usingIOQueue.Clear();
            finishedQueue.Clear();

            boxNew.Text = "";
            boxReady.Text = "";
            boxRunning.Text = "";
            boxUsingIO.Text = "";
            boxWaiting.Text = "";
            boxFinished.Text = "";
        }

        private void FIFO()
        {

            /*
             * 
             * This is a FIFO approach to the process management.
             * 
            */


            // Creates new process depending on the probability (%) and if the new process list limit is not being passed
            // with the parameters on CPU average usage time and IO usage time
            try
            {
                if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && newQueue.Count < Int32.Parse(limitNewBox.Text))
                {
                    Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                    temp.logArrivalTime = clock;
                    Processes.Add(temp);
                    newQueue.Enqueue(temp);
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in parameters!");
            }

            updateText();

            // Enqueues a process into the readyQueue if it's not going over the limit and the newQueue has more than 0 elements
            try
            {
                if (readyQueue.Count < Int32.Parse(limitReadyBox.Text) - 1 && newQueue.Count > 0)
                {
                    readyQueue.Enqueue(newQueue.Dequeue());
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in ready list limit parameter!");
            }

            updateText();

            // Enqueues a process into the runningQueue if it's empty
            // else it continues running the process that's already inside
            if (runningQueue.Count < 1 && readyQueue.Count > 0)
            {
                runningQueue.Enqueue(readyQueue.Dequeue());
                updateText();
            }
            else if (runningQueue.Count > 0)
            {
                Process temp = runningQueue.Peek();

                if (temp.ioStartTime != 0)
                {
                    // Enqueues a process into the finishedQueue if it no longer needs to use the CPU
                    // else it lowers the value of cpuUsageTime which represents how long it needs to be running
                    if (temp.cpuUsageTime == 0)
                    {
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else
                        temp.cpuUsageTime -= 1;
                }

                updateText();

                // Enqueues a process into the waitingQueue if it needs to use an I/O device
                // else it lowers the value of ioStartTime which represents when it's going to need to use an I/O device
                if (temp.ioStartTime == 0 && waitingQueue.Count < Int32.Parse(limitWaitingIOBox.Text))
                {
                    // It lowers the value to -1 so that next time it comes to the runningQueue it doesn't go
                    // through this "if"
                    temp.ioStartTime -= 1;
                    waitingQueue.Enqueue(runningQueue.Dequeue());
                }
                else if (temp.ioStartTime > 0)
                    temp.ioStartTime -= 1;
                
                updateText();

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

        private void RoundRobin()
        {
            /*
             * 
             * This is a Round Robin approach to the process management.
             * 
            */


            // Creates new process depending on the probability (%) and if the new process list limit is not being passed
            // with the parameters on CPU average usage time and IO usage time
            try
            {
                if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && newQueue.Count < Int32.Parse(limitNewBox.Text))
                {
                    Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                    temp.logArrivalTime = clock;
                    Processes.Add(temp);
                    newQueue.Enqueue(temp);
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in parameters!");
            }

            updateText();

            // Enqueues a process into the readyQueue if it's not going over the limit and the newQueue has more than 0 elements
            try
            {
                if (readyQueue.Count < Int32.Parse(limitReadyBox.Text) - 1 && newQueue.Count > 0)
                {
                    readyQueue.Enqueue(newQueue.Dequeue());
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in ready list limit parameter!");
            }

            updateText();

            // Enqueues a process into the runningQueue if it's empty
            // else it continues running the process that's already inside
            if (readyQueue.Count > 0 && clock % Int32.Parse(quantumBox.Text) == 0)
            {
                runningQueue.Enqueue(readyQueue.Dequeue());

                if (runningQueue.Count > 1)
                    readyQueue.Enqueue(runningQueue.Dequeue());
                updateText();
            }
            else if (runningQueue.Count > 0)
            {

                updateText();

                Process temp = runningQueue.Peek();

                if (temp.ioStartTime != 0)
                {
                    // Enqueues a process into the finishedQueue if it no longer needs to use the CPU
                    // else it lowers the value of cpuUsageTime which represents how long it needs to be running
                    if (temp.cpuUsageTime == 0)
                    {
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else
                        temp.cpuUsageTime -= 1;
                }
                updateText();
                try
                {
                    // Enqueues a process into the waitingQueue if it needs to use an I/O device
                    // else it lowers the value of ioStartTime which represents when it's going to need to use an I/O device
                    if (temp.ioStartTime == 0 && waitingQueue.Count < Int32.Parse(limitWaitingIOBox.Text))
                    {
                        // It lowers the value to -1 so that next time it comes to the runningQueue it doesn't go
                        // through this "if"
                        temp.ioStartTime -= 1;
                        waitingQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else if (temp.ioStartTime > 0)
                        temp.ioStartTime -= 1;
                }
                catch (FormatException e)
                {
                    parameterError("Error in waiting list limit!");
                }
                updateText();

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

        private void parameterError(string error)
        {
            aTimer.Stop();
            clear();
            MessageBox.Show(error);
            enableParameters();
        }

        private void disableParameters()
        {
            newProcessProbBox.Enabled = false;
            comboAlgorithm.Enabled = false;
            quantumBox.Enabled = false;
            limitNewBox.Enabled = false;
            limitReadyBox.Enabled = false;
            limitWaitingIOBox.Enabled = false;
            cpuAvgTimeBox.Enabled = false;
            ioTimeBox.Enabled = false;
        }

        private void enableParameters()
        {
            newProcessProbBox.Enabled = true;
            comboAlgorithm.Enabled = true;
            quantumBox.Enabled = true;
            limitNewBox.Enabled = true;
            limitReadyBox.Enabled = true;
            limitWaitingIOBox.Enabled = true;
            cpuAvgTimeBox.Enabled = true;
            ioTimeBox.Enabled = true;
        }
    }
}
