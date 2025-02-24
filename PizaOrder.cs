using System;
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
    public partial class PizaOrder : Form
    {
        public PizaOrder()
        {
            InitializeComponent();
        }
        
        private void FinalResult()
        {
            int result = Convert.ToInt32(label14.Text) + Convert.ToInt32(label15.Text) + Convert.ToInt32(label16.Text);
            label8.Text = Convert.ToString(result);
        }
        void ResetProgram()
        {
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            radioButton1.Checked = true;
            radioButton9.Checked = true;
            radioButton6.Checked = true;
            radioButton10.Checked = true;


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = radioButton1.Text;
            label14.Text = Convert.ToString(radioButton1.Tag);
            groupBox1.Tag = radioButton1.Tag;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = radioButton2.Text;
            label14.Text = Convert.ToString(radioButton2.Tag);
            groupBox1.Tag = radioButton2.Tag;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = radioButton3.Text;
            label14.Text = Convert.ToString(radioButton3.Tag);
            groupBox1.Tag = radioButton3.Tag;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = radioButton9.Text;
            label15.Text = Convert.ToString(radioButton9.Tag);
          
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = radioButton8.Text;
            label15.Text = Convert.ToString(radioButton8.Tag);
          
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = radioButton6.Text;
            label16.Text = Convert.ToString(radioButton6.Tag);
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = radioButton5.Text;
            label16.Text = Convert.ToString(radioButton5.Tag);
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = radioButton4.Text;
            label16.Text = Convert.ToString(radioButton4.Tag);
          
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton10.Text;
 
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = radioButton7.Text;
         
        }

        private void label14_TextChanged(object sender, EventArgs e)
        {
            FinalResult();
        }
        private void label15_TextChanged(object sender, EventArgs e)
        {
            FinalResult();
        }
        private void label16_TextChanged(object sender, EventArgs e)
        {
            FinalResult();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label14.Text == "0"|| label15.Text == "0"|| label16.Text == "0")           {
                MessageBox.Show("There are some empty options!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Thanks , Oreder Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetProgram();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                ResetProgram();

            }
        }
    }
}
