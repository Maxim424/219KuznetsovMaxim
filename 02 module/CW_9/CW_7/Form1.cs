﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void buttonLabel_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            buttonLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonLabel.Visible = true;
            button1.Visible = false;
        }
    }
}
