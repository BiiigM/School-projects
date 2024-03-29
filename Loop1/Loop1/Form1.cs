﻿using System;
using System.Windows.Forms;

namespace Schleifen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LabelClear(Label text)
        {
            text.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Clear label 1
            LabelClear(label1);

            int a = 0;

            while (a <= 5)
            {
                label1.Text += a + ", ";
                a++;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Clear label 2
            LabelClear(label2);

            int a = 0;

            do
            {
                label2.Text += a + ", ";
                a++;
            } while (a <= 5);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Clear label 3
            LabelClear(label3);

            for (int a = 0; a < 6; a++)
            {
                label3.Text += a + ", ";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Clear label 4
            LabelClear(label4);

            string[] list = new string[] { "Justin", "Nick", "Maxim" };

            foreach (string name in list)
            {
                label4.Text += name + ", ";
            }
            //Join would be easy
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Clearing all Buttons
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Label))
                    c.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //close the Forms
            this.Close();
        }
    }
}
