using BE;
using System.Windows;
using System.Windows.Controls;
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