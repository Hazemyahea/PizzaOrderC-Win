﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(label3.Text) + 10;
            label3.Text = Convert.ToString(value);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(label3.Text) + 15;
            label3.Text = Convert.ToString(value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(label3.Text) + 10;
            label3.Text = Convert.ToString(value);
        }

        private void button14_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Are You Sure to reset Price?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                label3.Text = Convert.ToString(0);
            }
        }

        
    }
}
