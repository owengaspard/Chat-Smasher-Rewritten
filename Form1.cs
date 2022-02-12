using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Chat_Smasher_Rewritten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void spamBox_TextChanged(object sender, EventArgs e)
        {
            int count = textBox2.TextLength;
            charCount.Text = count.ToString();
        }

        private void siticoneVTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = siticoneVTrackBar1.Value;
            string Interval = timer1.Interval.ToString();
            timerValue.Text = Interval + "ms";
        }

        private void appInitialize_Tick(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            statusIdle.Text = "Idle";
            statusIdle.ForeColor = Color.Yellow;
            timer1.Stop();
            Console.WriteLine("Stop clicked");
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            Process windowNow = Process.GetCurrentProcess();
            timer1.Start();
            statusIdle.Text = "Active";
            statusIdle.ForeColor = Color.Green;
            Console.WriteLine("Start clicked");
        }

        private void onTopCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (onTopCheck.Checked)
            {
                TopMost = true;
                Console.WriteLine("Top most was checked.");
            }
            else
            {
                TopMost = false;
                Console.WriteLine("Top most was unchecked.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) //If Discord bypass is cheked 
            {
                siticoneVTrackBar1.Enabled = false;
                timer1.Interval = 2000;
                Console.WriteLine("Chill zone bypass enabled");
                timerValue.Text = 2000 + "ms";
            }
            else if (checkBox1.Checked == false) //If not checked
            {
                siticoneVTrackBar1.Enabled = true;
                checkBox1.ForeColor = Color.White;
                Console.WriteLine("Chill zone bypass disabled");
                string IntChbx = timer1.Interval.ToString();
                timerValue.Text = IntChbx + "ms";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox2.Text);
            SendKeys.Send("{Enter}");
        }


        private void timerValue_Click(object sender, EventArgs e)
        {

        }
    }
}
