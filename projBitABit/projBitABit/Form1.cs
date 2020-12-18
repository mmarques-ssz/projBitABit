using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projBitABit
{
    public partial class Form1 : Form
    {
        private Bits bits;

        public Form1()
        {
            InitializeComponent();
            bits = this.bits = new Bits();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bits.setBits(byte.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(bits.getBits());
            label2.Text = Convert.ToString(bits.getBits(), 2);
            label3.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            lblBit1.Text = (bits.getBits(1)) ? "1" : "0";
            lblBit2.Text = (bits.getBits(2)) ? "1" : "0";
            lblBit3.Text = (bits.getBits(3)) ? "1" : "0";
            lblBit4.Text = (bits.getBits(4)) ? "1" : "0";
            lblBit5.Text = (bits.getBits(5)) ? "1" : "0";
            lblBit6.Text = (bits.getBits(6)) ? "1" : "0";
            lblBit7.Text = (bits.getBits(7)) ? "1" : "0";
            lblBit8.Text = (bits.getBits(8)) ? "1" : "0";
        }
    }
}
