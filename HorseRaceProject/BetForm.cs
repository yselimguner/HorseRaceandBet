using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HorseRaceProject
{
    public partial class BetForm : Form
    {
        public BetForm()
        {
            InitializeComponent();
        }

        private void racePageBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            HorseRace frm = new HorseRace();
            frm.Show();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            if (rdBtnFirstHorse.Checked==false&&rdBtnSecondHorse.Checked==false&&rdBtnThirdHorse.Checked==false)
            {
                MessageBox.Show("Please Choose Yout Bet");
            }
            else if(rdBtnFirstHorse.Checked==true)
            {
                double estimatedearnings = Convert.ToDouble(numericUpDown1.Value) * 1.7;
                EstimatedLbl.Text = estimatedearnings.ToString();
                MessageBox.Show("Your bet has been taken on the first horse."+"Your estimated earning is "+estimatedearnings+"$.");
            }
            else if(rdBtnSecondHorse.Checked==true)
            {
                double estimatedearnings = Convert.ToDouble(numericUpDown1.Value) * 1.9;
                EstimatedLbl.Text = estimatedearnings.ToString();
                MessageBox.Show("Your bet has been taken on the second horse."+"Your estimated earning is "+estimatedearnings+"$.");
            }
            else if(rdBtnThirdHorse.Checked==true)
            {
                double estimatedearnings = Convert.ToDouble(numericUpDown1.Value)*2.4;
                EstimatedLbl.Text = estimatedearnings.ToString();
                MessageBox.Show("Your bet has been taken on the third horse"+"Your estimated earning is "+estimatedearnings+"$.");
            }
            this.Hide();
            HorseRace frm = new HorseRace();
            frm.Show();
        }
    }
}
