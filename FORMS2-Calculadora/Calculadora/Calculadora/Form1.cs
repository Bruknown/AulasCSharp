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
        private Double number1;
        private Double number2;
        private String operation;
        public txtDisplay()
        {
            InitializeComponent();
        }

        private void clearField()
        {
            textBox1.Clear();
            number1 = 0;
            number2 = 0;
            operation = String.Empty;
        }

        private void numberAddition(String character)
        {
            if (textBox1.Text.Trim().Equals("0"))
            {
                textBox1.Text = character;
            }
            else
            {
                textBox1.Text = textBox1.Text + character;
            }
        }

        private void addOperationCharacter(String character)
        {
            if (textBox1.Text.Trim().Equals(String.Empty))
            {
                number1 = Convert.ToDouble(textBox1.Text.Trim());
                operation = character;
            }
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
            numberAddition("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numberAddition("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numberAddition("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numberAddition("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numberAddition("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numberAddition("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numberAddition("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numberAddition("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numberAddition("9");
        }

        private void txtDisplay_Load(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            addOperationCharacter("/");
        }
    }
}
