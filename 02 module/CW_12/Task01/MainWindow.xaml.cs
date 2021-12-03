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

namespace Task01
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

        int type = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (type==0)
            {
                type = 1;
                canvas.Background = Brushes.Aquamarine;
                grid.Background = Brushes.White;
            }
            else
            {
                type = 0;
                canvas.Background = Brushes.White;
                grid.Background = Brushes.Aquamarine;
            }
        }
    }
}
