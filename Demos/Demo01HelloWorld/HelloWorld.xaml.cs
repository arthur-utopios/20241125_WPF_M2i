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
using System.Windows.Shapes;

namespace Demo01HelloWorld
{
    /// <summary>
    /// Logique d'interaction pour HelloWorld.xaml
    /// </summary>
    public partial class HelloWorld : Window
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(sender is Button button)
            {
                MessageBox.Show("Salut!");
                button.Content = "J'ai été cliqué !";
            }

        }
    }
}
