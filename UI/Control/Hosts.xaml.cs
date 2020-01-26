using BE;
using BL;
using System.Collections.Generic;
using System.Windows.Controls;

namespace UI.Control
{
    /// <summary>
    /// Interaction logic for Hosts.xaml
    /// </summary>
    public partial class Hosts : UserControl
    {
        Ibl bl;
        public List<Host> HostsList { get; set; }
        private Host currentHost;

        public Hosts()
        {

            InitializeComponent();
            bl = FactoryBL.GetFactory();
             HostsList = bl.GetHosts();
           // HostsList = new List<Host>();

            
           
            for (int i = 0; i < HostsList.Count; i++)
            {
                currentHost = HostsList[i];
                RowDefinition row = new RowDefinition();
                row.MinHeight = 120;

                MainGrid.RowDefinitions.Add(row);

                MiniControl.HostMini hostMini = new MiniControl.HostMini(HostsList[i]);
                MainGrid.Children.Add(hostMini);
                Grid.SetRow(hostMini, i);
            }



        }


    }
}
