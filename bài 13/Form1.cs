using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnguon_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender; 
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1)) 
                this.errorProvider1.SetError(ctr, "This is not avalid number"); 
            else this.errorProvider1.Clear();
        }

        private void btnVNDtoUSD_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtnguon.Text);
            txtdich.Text = Math.Round(sotien * 17861, 2).ToString();
        }

        private void btnVNDtoEUR_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtnguon.Text);
            txtdich.Text = Math.Round(sotien * 17861, 2).ToString();
        }

        private void btnUSDtoVND_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtnguon.Text);
            txtdich.Text = Math.Round(sotien * 27043, 2).ToString();
        }

        private void btnEURtoVND_Click(object sender, EventArgs e)
        {
            double sotien = Convert.ToDouble(txtnguon.Text);
            txtdich.Text = Math.Round(sotien * 27043, 2).ToString();
        }
    }
