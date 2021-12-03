using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "9";
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            label.Content += ".";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "0";
        }

        private void buttonSharp_Click(object sender, RoutedEventArgs e)
        {
            label.Content += "#";
        }
    }
}
