using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class RSP : Form
    {
        int UWinss = 0;
        int CWinss = 0;

        public RSP()
        {
            InitializeComponent();
        }

        private void RockChoise_Click(object sender, EventArgs e)
        {
            pbUserChoise.Image = RockPaperScissors.Properties.Resources.rock;
            OpponentSelection();
        }

        private void PaperChoise_Click(object sender, EventArgs e)
        {
            pbUserChoise.Image = RockPaperScissors.Properties.Resources.paper;
            OpponentSelection();
        }

        private void ScissorsChoise_Click(object sender, EventArgs e)
        {
            pbUserChoise.Image = RockPaperScissors.Properties.Resources.scissors;
            OpponentSelection();
        }

        void OpponentSelection()
        {
            Random r = new Random();
            int choice = r.Next(1, 3);
            if (choice == 1)
            {
                pbCompChoise.Image = RockPaperScissors.Properties.Resources.rock;
                VictoryCheck(true);
            }
            
            if (choice == 2)
            {
                pbCompChoise.Image = RockPaperScissors.Properties.Resources.paper;
                VictoryCheck(false);
            }
            
            if (choice == 3)
            {
                pbCompChoise.Image = RockPaperScissors.Properties.Resources.scissors;
                VictoryCheck(true);
            }
        }

        void VictoryCheck(bool playerWon)
        {
            if (playerWon)
            {
                UWinss++;
                lbUserWinss.Text = Convert.ToString(UWinss);
                DialogResult result = MessageBox.Show("User win!");
            }
            else
            {
                CWinss++;
                lbCompWinss.Text = Convert.ToString(CWinss);
               DialogResult result = MessageBox.Show("Computer win!");
            }
            
        }   

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbUserName.Text = tbUserName.Text.ToString();   
            
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            lbUserName.Text = tbUserName.Text;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            UWinss = 0;
            CWinss = 0;

            pbCompChoise.Image = null;
            lbUserName.Text = "Enter your name";
            pbUserChoise.Image = null;
            lbUserWinss.Text = "0";
            lbCompWinss.Text = "0";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
