using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborotorka1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="Danial" && textBox2.Text == "1111")
            {
                label1.BackColor = Color.Green;
                label2.BackColor = Color.Green;
                MessageBox.Show("Hello Danial");
            }
            else
            {
                label1.BackColor = Color.Red; 
                label2.BackColor = Color.Red;
                MessageBox.Show("Error");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
