﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        int j = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Visible = !button1.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label2.Text = i.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            j++;
            label1.Text = j.ToString();
        }
    }
}
