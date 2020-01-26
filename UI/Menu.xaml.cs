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
using BE;

namespace UI
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        
        public Menu()
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
        
        private void SelectionChanged(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

           // switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
           switch (((MenuItem)((MenuItem)sender)).Name)
            {
                
                   
                case "AdminOrders":
                    usc = new Control.Orders();
                    GridMain.Children.Add(usc);
                    break;
                case "AdminUnits":
                    usc = new Control.Units();
                    GridMain.Children.Add(usc);
                    break;
                case "AdminUsers":
                    usc = new Control.Hosts();
                    GridMain.Children.Add(usc);
                    break;
                case "AdminRemove":
                    usc = new Control.UserControl1();
                    GridMain.Children.Add(usc);
                    break;
                case "AddUnit":
                    usc = new Control.UserControl1();
                    GridMain.Children.Add(usc);
                    break;
                case "HostOrders":
                    usc = new Control.Orders();
                    GridMain.Children.Add(usc);
                    break;
                case "HostSomething":
                    usc = new Control.UserControl1();
                    GridMain.Children.Add(usc);
                    break;
                case "GuestReq":
                    usc = new Control.GuestReq();
                    GridMain.Children.Add(usc);
                    break;
                case "GuestOrder":
                    usc = new Control.Orders();
                    GridMain.Children.Add(usc);
                    break;
                case "GuestSomething":
                    usc = new Control.UserControl1();
                    GridMain.Children.Add(usc);
                    break;
                case "testUserControl":
                    //usc = new MiniControl.miniTest();
                    usc = new Control.test();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
            toggleButton.IsChecked = false;
        }


    }
}
