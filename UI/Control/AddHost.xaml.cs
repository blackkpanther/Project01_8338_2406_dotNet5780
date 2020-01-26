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
using BE;
using BL;

namespace UI.Control
{
    /// <summary>
    /// Interaction logic for AddHost.xaml
    /// </summary>
    public partial class AddHost : Window
    {
        Ibl bl;
        public Host CurrentHost { get; set; }

        public AddHost()
        {
            InitializeComponent();
            bl = FactoryBL.GetFactory();
            this.CurrentHost.BankBranchDetails= new BankBranch
            {
                BankNumber = 1,
                BankName = "Leumi",
                BranchNumber = 111,
                BranchAddress = "aaaa aaaa",
                BranchCity = "Afula"
            };

            this.DataContext = CurrentHost;
            MainGrid.DataContext = CurrentHost;
        }

        private void AddHost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddHost(CurrentHost);
                MessageBox.Show("add Success!", "", MessageBoxButton.OK, MessageBoxImage.Information);
                Close();

            }
            catch (Exception error_str)
            {
                MessageBox.Show(error_str.Message, "UpDate Failed!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
