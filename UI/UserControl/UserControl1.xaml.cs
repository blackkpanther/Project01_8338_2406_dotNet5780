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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
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
