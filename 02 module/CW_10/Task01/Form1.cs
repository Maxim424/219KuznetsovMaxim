﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p1 = 1;
        int p2 = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            int p3 = p1 + 2 * p1;
            if (p3 < 0)
            {
                MessageBox.Show("Переполнение. Начнем ряд сначала");
                p1 = 1;
                p2 = 2;
                p3 = p1 + 2 * p1;
            }
            else
            {
                label1.Text = "Член ряда Пелла: " + p3;
                p1 = p2;
                p2 = p3;

            }
            
        }
    }
}
