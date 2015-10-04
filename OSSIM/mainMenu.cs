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
            updateText();

            //Creates new process depending on the probability (%) and if the new process list limit is not being passed.
            //with the parameters on CPU average usage time and IO usage time
            if (rnd.Next(1, 101) <= Int32.Parse(newProcessProbBox.Text) && newQueue.Count < Int32.Parse(limitNewBox.Text))
            {
                Process temp = new Process(Processes.Count, Int32.Parse(cpuAvgTimeBox.Text), Int32.Parse(ioTimeBox.Text));
                Processes.Add(temp);
                newQueue.Enqueue(temp);
            }
            updateText();

            if (readyQueue.Count < Int32.Parse(limitReadyBox.Text))
            {
                readyQueue.Enqueue(newQueue.Dequeue());
            }
            updateText();
            if (runningQueue.Count < 1)
            {
                runningQueue.Enqueue(readyQueue.Dequeue());
            }
            updateText();
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
