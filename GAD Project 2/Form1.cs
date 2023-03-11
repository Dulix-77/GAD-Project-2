using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAD_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double no1;
            double no2;
            double ans;

            no1 = double.Parse(textBox1.Text);
            no2 = double.Parse(textBox2.Text);
            ans = no1 + no2;
            textBox3.Text = ans.ToString();
            //double = samman;
            // int no4 = double
                
        }
    }
}
