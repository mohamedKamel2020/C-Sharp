﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x=double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            MessageBox.Show((x+y).ToString()); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            MessageBox.Show((x - y).ToString());
        }
    }
}
