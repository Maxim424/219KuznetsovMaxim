﻿using System;
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

namespace Task03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock tb = new TextBlock();
            StackPanel sp = new StackPanel();
            Slider slider = new Slider();
            slider.Minimum = -10;
            slider.Maximum = 10;
            slider.Orientation = Orientation.Horizontal;
            slider.Margin = new Thickness(10);
            slider.ValueChanged += (s, e) =>
            {
                tb.Text = slider.Value.ToString("F2");
            };

            sp.Children.Add(slider);
            tb.FontSize = 30;
            tb.Background = new SolidColorBrush(Colors.LightGray);
            tb.Width = 85;
            HorizontalAlignment = HorizontalAlignment.Center;
            tb.Text = "0";
            sp.Children.Add(tb);
            this.Content = sp;

        }
    }
}
