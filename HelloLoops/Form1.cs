﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo);

            while (selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a Messagebox. Do you want another?", "While", MessageBoxButtons.YesNo);
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int upDownIterations = Convert.ToInt32(numLoops.Text);
            for (int m = 0; m < upDownIterations; m++)
            {
                MessageBox.Show("Here's Messagebox " + (m + 1));
            }
        }

        private void numLoops_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
