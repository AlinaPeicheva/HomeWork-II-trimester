using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDListBoxes
{
    public partial class PosManager : Form
    {
        List<string> result = new List<string>();
        public PosManager()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string input = tbEnter.Text.Trim();
            if (input != "")
            {
                result.Add(input);
                lbResult.Items.Clear();
                lbResult.Items.AddRange(result.ToArray());
                tbEnter.Text = "";
            }
            else
            {
                MessageBox.Show("Enter valid data!");
            }
        }

        private void tbEnter_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click_1(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int currentIndex = lbResult.SelectedIndex;
                result.RemoveAt(currentIndex);
                lbResult.Items.RemoveAt(currentIndex);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item!");
            }
        }

        private void lbResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void btnUP_Click_1(object sender, EventArgs e)
        {
            if (lbResult.SelectedIndex > 0)
            {
                lbResult.Items.Insert(lbResult.SelectedIndex - 1, lbResult.SelectedItem);
                lbResult.SelectedIndex = (lbResult.SelectedIndex - 2);
                lbResult.Items.RemoveAt(lbResult.SelectedIndex + 2);
            }
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {

            if ((lbResult.SelectedIndex != -1) && (lbResult.SelectedIndex < lbResult.Items.Count - 1))
            {
                int currentIndex = lbResult.SelectedIndex;
                lbResult.Items.Insert(lbResult.SelectedIndex + 2, lbResult.SelectedItem);
                lbResult.SelectedIndex = (lbResult.SelectedIndex + 2);
                lbResult.Items.RemoveAt(currentIndex);
            }
        }

        private void btnTop_Click_1(object sender, EventArgs e)
        {
            int index = lbResult.SelectedIndex;
            try
            {
                var item = lbResult.Items[index];
                lbResult.Items.RemoveAt(index);
                lbResult.Items.Insert(0, item);
                lbResult.Refresh();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item!");
            }
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {

            int index = lbResult.SelectedIndex;
            try
            {
                var item = lbResult.Items[index];
                lbResult.Items.RemoveAt(index);
                lbResult.Items.Add(item);
                lbResult.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Select an item!");
            }
        }

        private void tbEnter_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

