using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkzamenProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoanaAmount_TextChanged(object sender, EventArgs e)
        {
            int LoanaAmount = int.Parse(Console.ReadLine());
        }

        private void Days_TextChanged(object sender, EventArgs e)
        {
            int Days = int.Parse(Console.ReadLine());
        }

        private void InterestRate_TextChanged(object sender, EventArgs e)
        {
            double InterestRate = Convert.ToDouble(Console.ReadLine());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Click += new System.EventHandler(this.button2_Click);
        }
    }
}
