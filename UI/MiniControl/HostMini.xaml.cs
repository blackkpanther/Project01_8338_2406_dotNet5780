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
using BE;
namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for Host.xaml
    /// </summary>
    public partial class HostMini : UserControl
    {

        public Host CurrentHost { get; set; }

        public HostMini(Host host)
        {
            InitializeComponent();
            this.CurrentHost = host;

            this.DataContext = CurrentHost;
            MainGrid.DataContext = CurrentHost;



        }
        
        private void Delete_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}