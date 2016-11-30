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

        private void button22_Click(object sender, EventArgs e)
        {
            //Displayed 0 in Textbox when press 0 button with Red color
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Displayed 2 in Textbox when press 1 button with Red color
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Blue;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Displayed 2 in Textbox when press 2 button with Red color
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Green;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Displayed 3 in Textbox when press 3 button with Red color
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Orange;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Displayed 4 in Textbox when press 4 button with Red color
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Pink;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Displayed 5 in Textbox when press 5 button with Red color
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Brown;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Displayed 6 in Textbox when press 6 button with Red color
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.BurlyWood;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Displayed 7 in Textbox when press 7 button with Red color
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.BlueViolet;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Displayed 8 in Textbox when press 8 button with Red color
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Gray;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Displayed 9 in Textbox when press 9 button with Red color
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.LightCoral;
        }
    }
}
