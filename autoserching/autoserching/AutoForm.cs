using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoserching
{
    public partial class AutoForm : Form
    {
        int disc;
        double priceauto, pricesale, withsale;

        public AutoForm()
        {
            InitializeComponent();
        }

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            int priceMercedes = 40000;
            priceauto = priceMercedes;
            picAuto.Image = autoserching.Properties.Resources._2018_Mercedes_Benz_C_Class_01;
            if (rbMercedes.Checked)
            {
                lbPriceModel.Text = priceauto.ToString();
            }
        }
        

        private void rbTesla_CheckedChanged(object sender, EventArgs e)
        {
            int priceTesla = 79500;
            priceauto = priceTesla;
            picAuto.Image = autoserching.Properties.Resources._2017_tesla;
            if (rbTesla.Checked)
            {
                lbPriceModel.Text = priceauto.ToString();
            }
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            int priceAudi = 67000;
            priceauto = priceAudi;
            picAuto.Image = autoserching.Properties.Resources.audi_q8;
            if (rbAudi.Checked)
            {
                lbPriceModel.Text = priceauto.ToString(); 
            }
        }

        private void paybycreditcard_CheckedChanged(object sender, EventArgs e)
        {
            if (paybycreditcard.Checked == true)
            {
                paybycheck.Enabled = false;
                paybycash.Enabled = false;
            }
            else
            {
                paybycheck.Enabled = true;
                paybycash.Enabled = true;
            }
        }

        private void paybycheck_CheckedChanged(object sender, EventArgs e)
        {
            if (paybycheck.Checked == true)
            {
                paybycreditcard.Enabled = false;
                paybycash.Enabled = false;
            }
            else
            {
                paybycreditcard.Enabled = true;
                paybycash.Enabled = true;
            }
        }

        private void paybycash_CheckedChanged(object sender, EventArgs e)
        {
            if (paybycash.Checked == true)
            {
                paybycheck.Enabled = false;
                paybycreditcard.Enabled = false;
                
            }
            else
            {
                paybycheck.Enabled = true;
                paybycreditcard.Enabled = true;
            }
        }

        private void cbAbs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAbs.Checked)
            {
                disc += 1200;
            }
        }

        private void cbExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExtra.Checked)
            {
                disc += 500;
            }

        }

        private void cbAlarma_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAlarma.Checked)
            {
                disc += 950;
            }
        }
        
        private void btnGetDiscount_Click(object sender, EventArgs e)
        {
            
            if (cbAbs.Checked && cbExtra.Checked && cbAlarma.Checked)
            {
                // 10% discount from the priceauto
                pricesale = withsale * 0.90;
                numOfDiscount.Text = pricesale.ToString();
            }
            else
            {
                pricesale = withsale;
                numOfDiscount.Text = pricesale.ToString();
            }

            if (paybycash.Checked == true)
            {
                // 5%  discount from the priceauto
                pricesale = withsale * 0.95;
                numOfDiscount.Text = pricesale.ToString();
            }
            else
            {
                pricesale = withsale;
                numOfDiscount.Text = pricesale.ToString();
            }
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            withsale = priceauto + disc;
            numOfPrice.Text = withsale.ToString();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            numOfTotal.Text = pricesale.ToString();          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbMercedes.Checked = false;
            rbAudi.Checked = false;
            rbTesla.Checked = false;
            paybycash.Checked = false;
            paybycheck.Checked = false;
            paybycreditcard.Checked = false;
            cbAbs.Checked = false;
            cbExtra.Checked = false;
            cbAlarma.Checked = false;
            lbPriceModel.Text = "$ 0";
            numOfDiscount.Text = "$ 0";
            numOfPrice.Text = "$ 0";
            numOfTotal.Text = "$ 0";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
