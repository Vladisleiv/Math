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

        public void disable() //Create one method to disable Calculator
        {
            //Follow are Disable when call me disable() function
 
            textBox1.Enabled = false;
            button1.Show();            // It will be still Display
            button2.Hide();            //It will bi Hide
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
        }


        public void enable() //Now create function to ON calculator
        {
            //Follow are Enabled when we call enable() function

            textBox1.Enabled = true;
            button2.Show();             //It will be still Dispaly
            button1.Hide();             //It will be Hide
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)// OFF Button
        {
            disable(); //Call disable() function to OFF Calculator
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable(); //Call enable() function to ON calculator
        }
    }
}
