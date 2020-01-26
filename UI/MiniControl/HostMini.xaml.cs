using BE;
using BL;
using System.Windows;
using System.Windows.Controls;
namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for Host.xaml
    /// </summary>
    public partial class HostMini : UserControl
    {
        Ibl bl;
        public Host CurrentHost { get; set; }

        public HostMini(Host host)
        {
            InitializeComponent();
            bl = FactoryBL.GetFactory();
            this.CurrentHost = host;

            this.DataContext = CurrentHost;
            MainGrid.DataContext = CurrentHost;



        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            bl.DeleteHost(CurrentHost);

        }

        private void SelectionChangedUpdate(object sender, RoutedEventArgs e)
        {
            Window UpdateHost = new Control.UpdateHost(CurrentHost);
            UpdateHost.Show();
        }

    }
}