using BE;
using System.Windows.Controls;

namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for miniTest.xaml
    /// </summary>
    public partial class miniTest : UserControl
    {


        public Host CurrentHost { get; set; }


        public miniTest(Host host)
        {

            InitializeComponent();
            this.CurrentHost = host;

            this.DataContext = CurrentHost;
            miniTestGrid.DataContext = CurrentHost;


        }


    }
}
