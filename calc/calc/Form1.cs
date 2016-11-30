using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Display dot(.) in Textbox when press dot(.) button with Red color
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }
    }
}
