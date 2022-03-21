using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_BTH1_Week1
{
    public partial class Lab1_Bai02 : Form
    {
        int num1, num2, num3, min, max;
        public Lab1_Bai02()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = max.ToString();
            textBox5.Text = min.ToString();
        }
        private void checkmin(object sender, EventArgs e)
        {  
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            num3 = Int32.Parse(textBox3.Text.Trim());
            min = num1;
            if (min > num2)
            {
                min = num2;
            }
            else if (min > num3)
            {
                min = num3;
            }
        }
        private void checkmax(object sender, EventArgs e)
        {
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            num3 = Int32.Parse(textBox3.Text.Trim());
            max = num1;
            if(max < num2)
            {
                max = num2;
            }
            else if(max < num3)
            {
                max = num3;
            }
        }
    }
}
