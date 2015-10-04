using System;
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

        private int clock;

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
            clock++;
            clockNumLabel.Text = clock.ToString();
        }

    }
}
