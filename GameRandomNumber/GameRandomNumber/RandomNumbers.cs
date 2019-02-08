using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRandomNumber
{
    public partial class RandomNumbers : Form
    {
        int countTry = 0;
        int number;
        bool random = false;

        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void getRandomNumber(int index)
        {
            random = true;
            Random rand = new Random();
            switch (index)
            {
                case 0:
                    number = rand.Next(1, 11);
                   label4.Text = Convert.ToString(number);
                    break;
                case 1:
                    number = rand.Next(1, 31);
                   label4.Text = Convert.ToString(number);
                    break;
                case 2:
                    number = rand.Next(1, 51);
                   label4.Text = Convert.ToString(number);
                    break;
                case 3:
                    number = rand.Next(1, 101);
                 label4.Text = Convert.ToString(number);
                    break;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int item_selected = cbLevels.SelectedIndex;
            int num_textbox = 0;
            if (!string.IsNullOrEmpty(tbInputByUser.Text) && int.TryParse(tbInputByUser.Text, out int test))
            {
                num_textbox = Convert.ToInt32(tbInputByUser.Text);
            }

            if (countTry == 10)
            {
                pbresalt.Visible = true;
                pbresalt.Image = GameRandomNumber.Properties.Resources.fingerDown;
                random = false;
                countTry = 0;
            }

            if (item_selected == -1)
            {
                MessageBox.Show("Error, try one more time");
                return;
            }

            if (!random)
            {
                getRandomNumber(item_selected);
            }

            if (num_textbox == number)
            {
                pbresalt.Image = GameRandomNumber.Properties.Resources.fingerUp;
                countTry = 0;
                random = false;
                lbtry.Text = Convert.ToString(countTry);
                MessageBox.Show("Congratulations!");
            }
            else
            {
                countTry += 1;
                lbtry.Text = Convert.ToString(countTry);
                if (num_textbox > number)
                {
                    pbUporDown.Image = GameRandomNumber.Properties.Resources.down;
                }

                else if (num_textbox < number)
                {
                    pbUporDown.Image = GameRandomNumber.Properties.Resources.up;
                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
    }
}
