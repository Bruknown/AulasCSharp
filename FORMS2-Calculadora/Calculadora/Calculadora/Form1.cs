using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class txtDisplay : Form
    {
        public txtDisplay()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }
    }
}
