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
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindowHost.xaml
    /// </summary>
    public partial class MainWindowHost : Window
    {
        public MainWindowHost()
        {
            InitializeComponent();
        }
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Button)sender).Width *= 1.1;
            ((Button)sender).Height *= 1.1;
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Button)sender).Width /= 1.1;
            ((Button)sender).Height /= 1.1;
        }
        private void Button_Click_CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_MinimizeWindow(object sender, RoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }
        private void Button_Click_MaximizeWindow(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                SystemCommands.RestoreWindow(this);
            else
                SystemCommands.MaximizeWindow(this);
        }
        private void Button_Click_NewUnit(object sender, RoutedEventArgs e)
        {
            AddUnit secondWindow = new AddUnit();
            secondWindow.Show();
        }
        private void Button_Click_MyUnits(object sender, RoutedEventArgs e)
        {
            MyUnits secondWindow = new MyUnits();
            secondWindow.Show();
        }
        private void Button_Click_AllOrders(object sender, RoutedEventArgs e)
        {
            MyOrders secondWindow = new MyOrders();
            secondWindow.Show();
        }
       


    }
}
