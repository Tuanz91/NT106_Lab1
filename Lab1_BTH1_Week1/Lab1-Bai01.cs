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
    public partial class Lab1_Bai01 : Form
    {
        public Lab1_Bai01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(IsNumber(textBox1.Text) == false)
            {
                MessageBox.Show("Vui long nhap lai");
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lab1_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (IsNumber(textBox2.Text) == false)
            {
                MessageBox.Show("Vui long nhap lai");
                textBox1.Text = "";
            }
        }
    }
}

