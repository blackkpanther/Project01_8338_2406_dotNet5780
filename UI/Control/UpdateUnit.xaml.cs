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
using BE;
using BL;

namespace UI.Control
{
    /// <summary>
    /// Interaction logic for UpdateUnit.xaml
    /// </summary>
    public partial class UpdateUnit : Window
    {
        Ibl bl;
        public HostingUnit CurrentHostingUnit { get; set; }
        public UpdateUnit(HostingUnit hostingUnit)
        {
            InitializeComponent();
            bl = FactoryBL.GetFactory();
            this.CurrentHostingUnit = hostingUnit;
            this.DataContext = CurrentHostingUnit;
            MainGrid.DataContext = CurrentHostingUnit;
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.UpdateHostingUnit(CurrentHostingUnit);
                MessageBox.Show("UpDate Success!", "", MessageBoxButton.OK, MessageBoxImage.Information);
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
