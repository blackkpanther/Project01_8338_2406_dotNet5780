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

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindowGuest.xaml
    /// </summary>
    public partial class MainWindowGuest : Window
    {
        public MainWindowGuest()
        {
            InitializeComponent();

          /*  this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = System.Windows.SystemParameters.WorkArea.Width - this.Width;
            this.Top = System.Windows.SystemParameters.WorkArea.Height - this.Height;
          */

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
        private void Button_Click_NewSearch(object sender, RoutedEventArgs e)
        {
            AddGuestRequest secondWindow = new AddGuestRequest();
            secondWindow.Show();
        }
        private void Button_Click_MyOrders(object sender, RoutedEventArgs e)
        {
            MyOrders secondWindow = new MyOrders();
            secondWindow.Show();


        }
    }
}
