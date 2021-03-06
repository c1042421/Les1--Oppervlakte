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

namespace oefOppervlakte
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {
            double straal;

            if (!double.TryParse(txtStraal.Text, out straal))
            {
                MessageBox.Show("Gelieve een numeriek getal in te geven", "Fout!", MessageBoxButton.OK,MessageBoxImage.Error);
            } else
            {
                Cirkel cirkel = new Cirkel(straal);
                lblOutput.Content = cirkel.ToString();
            }
        }
    } 
}
