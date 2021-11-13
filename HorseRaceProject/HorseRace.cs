using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceProject
{
    public partial class HorseRace : Form
    {
        public HorseRace()
        {
            InitializeComponent();
        }
        Random rnd;

        private void startBTN_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
            rnd = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pcBox1.Left += rnd.Next(5, 16);
            pcBox2.Left += rnd.Next(5, 16);
            pcbox3.Left += rnd.Next(5, 16);

            if (pcBox1.Left > pcBox2.Left && pcBox1.Left > pcbox3.Left) 
            {
                InfoText.Text = "First horse is now leading the race";
            }
            else if (pcBox2.Left > pcBox1.Left && pcBox2.Left > pcbox3.Left)
            {
                InfoText.Text = "Second horse is now leading the race";
            }
            else if (pcbox3.Left > pcBox1.Left && pcbox3.Left > pcBox2.Left)
            {
                InfoText.Text = "Third horse is now leading the race";
            }
            if (pcBox1.Left+pcBox1.Width>=finishBTN.Left)
            {
                timer1.Stop();
                MessageBox.Show("First horse won the race. Congratulations.");
            }
            else if(pcBox2.Left+pcBox2.Width>=finishBTN.Left)
            {
                timer1.Stop();
                MessageBox.Show("Second horse won the race. Congratulations.");
            }
            else if(pcbox3.Left+pcbox3.Width>=finishBTN.Left)
            {
                timer1.Stop();
                MessageBox.Show("Third horse won the race. Congratulations.");
            }
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcBox1.Left = 0;
            pcBox2.Left = 0;
            pcbox3.Left = 0;
            InfoText.Text = " ";
        }

        private void betBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            BetForm bet = new BetForm();
            bet.Show();
        }
    }
}
