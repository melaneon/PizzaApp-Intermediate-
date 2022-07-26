using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem10
{
    public partial class Form1 : Form
    {
        float total;
        public Form1()
        {
            InitializeComponent();
            total = 0f;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked)
            {
                total = 10;
            }

            if (rdoMediumSize.Checked)
            {
                total = 15;
            }

            if (rdoLargeSize.Checked)
            {
                total = 20;
            }

            txtTotal.Text = String.Format("{0:C}", total);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoSmallSize.Checked == true || rdoMediumSize.Checked == true || rdoLargeSize.Checked == true)
                {
                if (checkBox3.Checked == true)
                {
                    total = total + 5;
                }
                if (checkBox3.Checked == false)
                {
                    total = total - 5; ;
                }
                txtTotal.Text = String.Format("{0:C}", total);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked == true || rdoMediumSize.Checked == true || rdoLargeSize.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    total = total + 3;
                }
                if (checkBox2.Checked == false)
                {
                    total = total - 3; ;
                }
                txtTotal.Text = String.Format("{0:C}", total);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmallSize.Checked == true || rdoMediumSize.Checked == true || rdoLargeSize.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    total = total + 2;
                }
                if (checkBox1.Checked == false)
                {
                    total = total - 2; ;
                }
                txtTotal.Text = String.Format("{0:C}", total);
            }
        }
    }
}
