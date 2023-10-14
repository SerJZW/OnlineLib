using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace OnlineLib
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Applications();
        }
    }

}

