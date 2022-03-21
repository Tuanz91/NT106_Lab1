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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1_Bai01 Tong2SDK = new Lab1_Bai01();
            Tong2SDK.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab1_Bai02 timminmax = new Lab1_Bai02();
            timminmax.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab1_Bai03 Doc = new Lab1_Bai03();
            Doc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
