using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OSSIM
{
    public partial class mainMenu : Form
    {
        List<Process> Processes = new List<Process>();
        private int clock;
        private int quantum;
        private bool pause;
        Random rnd = new Random();
        Queue<Process> holdQueue = new Queue<Process>();
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
            aTimer.Interval = 1000;
        }

        private void speedMedium_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 500;
        }

        private void speedFast_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 100;
        }

        // Where the magic happens
        private void aTimer_Tick(object sender, EventArgs e)
        {
            if (!checkMinimums())
                parameterError("Error: Can't use values below their minimum in parameters! \r\nClick HELP for minimum values.");
            updateClock();
            if (comboAlgorithm.Text == "FIFO" && checkMinimums())
                FIFO();
            else if (comboAlgorithm.Text == "RR" && checkMinimums())
                RoundRobin2();
            else if (comboAlgorithm.Text != "FIFO" && comboAlgorithm.Text != "RR")
            {
                parameterError("Error in algorithm parameter!");
            }

            updateText();

            if (pause == true)
            {
                aTimer.Stop();
            }
            if (!checkMinimums())
                clear();

        }

        private bool checkMinimums()
        {
            if (Int32.Parse(newProcessProbBox.Text) < 0)
                return false;
            if (Int32.Parse(quantumBox.Text) < 1)
                return false;
            if (Int32.Parse(limitNewBox.Text) < 1)
                return false;
            if (Int32.Parse(limitReadyBox.Text) < 1)
                return false;
            if (Int32.Parse(limitWaitingIOBox.Text) < 1)
                return false;
            if (Int32.Parse(cpuAvgTimeBox.Text) < 4)
                return false;
            if (Int32.Parse(ioTimeBox.Text) < 1)
                return false;
            return true;
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
            catch (DivideByZeroException e)
            {
                parameterError("Error in Quantum parameter!");
            }
            
        }

        private void updateText()
        {
            boxHold.Text = displayMembers(holdQueue);
            boxReady.Text = displayMembers(readyQueue);
            boxRunning.Text = displayMembers(runningQueue);
            boxUsingIO.Text = displayMembers(usingIOQueue);
            boxWaiting.Text = displayMembers(waitingQueue);
            boxFinished.Text = displayMembers(finishedQueue);
            updatePCB();
        }

        private void updatePCB()
        {
            string temp = "";
            foreach (Process p in Processes)
            {
                p.calculateAccumulated(clock);
                p.calculateSystemTime();
                p.calculateWaitTime();

                temp += p.id;
                temp += "\t";
                temp += p.logArrivalTime;
                temp += "\t";
                temp += p.logCPUUsageTime;
                temp += "\t";
                temp += p.logAccumulatedUsage;
                temp += "\t";
                temp += p.logIOStartTime;
                temp += "\t";
                temp += p.logIOUsageTime;
                temp += "\t";
                temp += p.logEndTime;
                temp += "\t";
                temp += p.logSystemTime;
                temp += "\t";
                temp += p.logWaitTime;
                temp += "\t";
                temp += p.status;
                temp += "\r\n";
            }

            PCBbox.Text = temp;
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

            holdQueue.Clear();
            readyQueue.Clear();
            runningQueue.Clear();
            waitingQueue.Clear();
            usingIOQueue.Clear();
            finishedQueue.Clear();

            boxHold.Text = "";
            boxReady.Text = "";
            boxRunning.Text = "";
            boxUsingIO.Text = "";
            boxWaiting.Text = "";
            boxFinished.Text = "";
            PCBbox.Text = "";
        }

        private void FIFO()
        {

            /*
             * 
             * This is a FIFO approach to the process management.
             * 
            */
            // Enqueues a process into usingIOQueue if it's empty
            // else it continues processing the I/O device usage


            if (usingIOQueue.Count < 1 && waitingQueue.Count > 0)
            {
                Process temp = waitingQueue.Peek();
                temp.status = "Waiting";
                usingIOQueue.Enqueue(waitingQueue.Dequeue());
            }
            else if (usingIOQueue.Count > 0)
            {
                Process temp = usingIOQueue.Peek();
                temp.status = "I/O";

                // Enqueues a process into the readyQueue if it's done using the I/O device
                // else it lowers the value of ioUsageTime which represents how long it needs to be using an I/O device
                if (temp.ioUsageTime == 0)
                {
                    if (readyQueue.Count >= Int32.Parse(limitReadyBox.Text))
                    {
                        temp.status = "Killed";
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(usingIOQueue.Dequeue());
                    }
                    else
                    {
                        temp.status = "Ready";
                        readyQueue.Enqueue(usingIOQueue.Dequeue());
                    }
                }
                else
                    temp.ioUsageTime -= 1;
            }

            updateText();

            if (runningQueue.Count > 0)
            {
                Process temp = runningQueue.Peek();

                // Enqueues a process into the waitingQueue if it needs to use an I/O device
                // else it lowers the value of ioStartTime which represents when it's going to need to use an I/O device
                if (temp.ioStartTime == 0 &&  runningQueue.Count > 0)
                {
                    if (waitingQueue.Count >= Int32.Parse(limitWaitingIOBox.Text))
                    {
                        temp.status = "Killed";
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else
                    {
                        // It lowers the value to -1 so that next time it comes to the runningQueue it doesn't go
                        // through this "if"
                        temp.ioStartTime -= 1;
                        temp.status = "Waiting";
                        waitingQueue.Enqueue(runningQueue.Dequeue());
                    }
                }
                else if (temp.ioStartTime > 0 && runningQueue.Count > 0)
                    temp.ioStartTime -= 1;

                updateText();

                // Enqueues a process into the finishedQueue if it no longer needs to use the CPU
                // else it lowers the value of cpuUsageTime which represents how long it needs to be running
                if (temp.cpuUsageTime == 0 && runningQueue.Count > 0)
                {
                    temp.status = "Finished";
                    temp.logEndTime = clock;
                    finishedQueue.Enqueue(runningQueue.Dequeue());
                }
                else if (runningQueue.Count > 0)
                    temp.cpuUsageTime -= 1;

                updateText();

            }

            

            // Enqueues a process into the runningQueue if it's empty
            // else it continues running the process that's already inside
            if (runningQueue.Count < 1 && readyQueue.Count > 0)
            {
                Process temp = readyQueue.Peek();
                temp.status = "Running";
                runningQueue.Enqueue(readyQueue.Dequeue());
            }

            // Enqueues a process into the readyQueue if it's not going over the limit and the holdQueue has more than 0 elements
            try
            {
                if (readyQueue.Count < Int32.Parse(limitReadyBox.Text) - 2 && holdQueue.Count > 0)
                {
                    Process temp = holdQueue.Peek();
                    temp.status = "Ready";
                    readyQueue.Enqueue(holdQueue.Dequeue());
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in ready list limit parameter!");
            }

            // Creates new process depending on the probability (%) and if the new process list limit is not being passed
            // with the parameters on CPU average usage time and IO usage time
            try
            {
                if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && holdQueue.Count < Int32.Parse(limitNewBox.Text))
                {
                    Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                    temp.logArrivalTime = clock;
                    Processes.Add(temp);
                    holdQueue.Enqueue(temp);
                    temp.status = "New";
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in parameters!");
            }
        }

        private void RoundRobin2()
        {

            // Enqueues a process into usingIOQueue if it's empty
            // else it continues processing the I/O device usage
            if (usingIOQueue.Count < 1 && waitingQueue.Count > 0)
            {
                Process temp = waitingQueue.Peek();
                temp.status = "Waiting";
                usingIOQueue.Enqueue(waitingQueue.Dequeue());
            }
            else if (usingIOQueue.Count > 0)
            {
                Process temp = usingIOQueue.Peek();
                temp.status = "I/O";

                // Enqueues a process into the readyQueue if it's done using the I/O device
                // else it lowers the value of ioUsageTime which represents how long it needs to be using an I/O device
                if (temp.ioUsageTime == 0)
                {
                    if (readyQueue.Count <= Int32.Parse(limitReadyBox.Text))
                    {
                        temp.status = "Ready";
                        readyQueue.Enqueue(usingIOQueue.Dequeue());
                    }
                    else
                    {

                        temp.status = "Killed";
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(usingIOQueue.Dequeue());
                    }
                }
                else
                    temp.ioUsageTime -= 1;
            }

            updateText();


            if (runningQueue.Count > 0)
            {
                Process temp = runningQueue.Peek();
                if (clock % Int32.Parse(quantumBox.Text) == 0 && runningQueue.Count > 0)
                {
                    if (readyQueue.Count >= Int32.Parse(limitReadyBox.Text))
                    {
                        temp.status = "Killed";
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else
                    {
                        temp.status = "Ready";
                        readyQueue.Enqueue(runningQueue.Dequeue());
                    }

                }

                // Enqueues a process into the waitingQueue if it needs to use an I/O device
                // else it lowers the value of ioStartTime which represents when it's going to need to use an I/O device
                if (temp.ioStartTime == 0 && runningQueue.Count > 0)
                {
                    if (waitingQueue.Count == Int32.Parse(limitWaitingIOBox.Text))
                    {
                        temp.status = "Killed";
                        temp.logEndTime = clock;
                        finishedQueue.Enqueue(runningQueue.Dequeue());
                    }
                    else
                    {
                        // It lowers the value to -1 so that next time it comes to the runningQueue it doesn't go
                        // through this "if"
                        temp.ioStartTime -= 1;
                        temp.status = "Waiting";
                        waitingQueue.Enqueue(runningQueue.Dequeue());
                    }
                }
                else if (temp.ioStartTime > 0 && runningQueue.Count > 0)
                    temp.ioStartTime -= 1;

                updateText();

                // Enqueues a process into the finishedQueue if it no longer needs to use the CPU
                // else it lowers the value of cpuUsageTime which represents how long it needs to be running
                if (temp.cpuUsageTime == 0 && runningQueue.Count > 0)
                {
                    temp.status = "Finished";
                    temp.logEndTime = clock;
                    finishedQueue.Enqueue(runningQueue.Dequeue());
                }
                else if(runningQueue.Count > 0)
                    temp.cpuUsageTime -= 1;

                updateText();

            }

            

            // Enqueues a process into the runningQueue if it's empty
            // else it continues running the process that's already inside
            if (runningQueue.Count < 1 && readyQueue.Count > 0)
            {
                Process temp = readyQueue.Peek();
                temp.status = "Running";
                runningQueue.Enqueue(readyQueue.Dequeue());
            }

            // Enqueues a process into the readyQueue if it's not going over the limit and the holdQueue has more than 0 elements
            try
            {
                if ( holdQueue.Count > 0 && readyQueue.Count < Int32.Parse(limitReadyBox.Text) - 2)
                {
                    Process temp = holdQueue.Peek();
                    temp.status = "Ready";
                    readyQueue.Enqueue(holdQueue.Dequeue());
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in ready list limit parameter!");
            }

            // Creates new process depending on the probability (%) and if the new process list limit is not being passed
            // with the parameters on CPU average usage time and IO usage time
            try
            {
                if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && holdQueue.Count < Int32.Parse(limitNewBox.Text))
                {
                    Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                    temp.logArrivalTime = clock;
                    Processes.Add(temp);
                    holdQueue.Enqueue(temp);
                    temp.status = "New";
                }
            }
            catch (FormatException e)
            {
                parameterError("Error in parameters!");
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

        private void speedFlash_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\School\CETYS\SEM_5\OS\OS_Simulator\OSSIM\Resources\Woof.wav");
            player.Play();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string temp = "";

            temp += "HOW TO USE:\r\n";
            temp += "1. Write down all your parameters for the manager (VIEW MINIMUM VALUES)\r\n";
            temp += "2. Pick an algorithm. This simulation only has First In First Out (FIFO) and Round Robin (RR)\r\n";
            temp += "3. You may* want to choose one of the four speeds (Slow, normal, fast and flash)\r\n";
            temp += "*If you don't pick any, normal will be the default\r\n";
            temp += "4. Press the play button for the simulation to start\r\n\n";
            temp += "MINIMUM VALUES PER PARAMETER:\r\n";
            temp += "-Quantum > 0\r\n";
            temp += "-Probability >= 0\r\n";
            temp += "-Limits > 0\r\n";
            temp += "-CPU Avg. Usage > 3\r\n";
            temp += "-I/O usage > 0\r\n\n";
            temp += "NOTES:\r\n";
            temp += "-The pause button will let you look at everything that has been done after the current cycle ends\r\n";
            temp += "-The pause button will let you modify parameters during the current simulation\r\n";
            temp += "-The stop button will automatically delete every process and make every box empty\r\n";
            temp += "-You can't modify parameters while running the simulation";

            MessageBox.Show(temp);
        }

        private void killProcess(Process temp)
        {

        }
    }
}
