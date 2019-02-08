using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoshaCalculator
{
    public partial class GoshaCalcul : Form
    {
        int firstnumber = 0;
        int secondnumber = 0;

        public GoshaCalcul()
        {
            InitializeComponent();
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            firstnumber = int.Parse(tbFirstNum.Text);
            secondnumber = int.Parse(tbSecondNum.Text);
            

            for (int i = 0; i < 20; i++)
            {
                int numbers = rnd.Next(firstnumber, secondnumber);
                lbAllNumbers.Items.Add(numbers.ToString());
            }
        }
        
        private void lbAllNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbFirstNum.Text = "";
            tbSecondNum.Text = "";
            lbAllNumbers.Text = "";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = lbAllNumbers.SelectedIndex;
                lbAllNumbers.Items.RemoveAt(currentIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Enter num before removing!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
