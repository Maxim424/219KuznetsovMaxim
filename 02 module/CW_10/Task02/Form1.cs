﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] str = new string[] { "one", "two", "three" };

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = string.Join(" ", textBox1.Lines);
            MessageBox.Show(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
