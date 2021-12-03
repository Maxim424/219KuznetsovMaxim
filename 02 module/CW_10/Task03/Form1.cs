using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int resize = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            if (resize==1)
            {
                if (this.Width > 100 && this.Height > 220)
                {
                    button1.Text = "Уменьшить форму";
                    this.Width -= 50;
                    this.Height -= 50;
                }
                else
                {
                    resize = 2;
                }
            }
            else
            {
                if (this.Width < 700 && this.Height < 1000)
                {
                    button1.Text = "Увеличить форму";
                    this.Width += 50;
                    this.Height += 50;
                }
                else
                {
                    resize = 1;
                }
            }
            
            
            
        }
    }
}
