using BE;
using BL;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;


namespace UI.Control
{
    /// <summary>
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : UserControl
    {
        Ibl bl;
        public List<HostingUnit> HostingUnitsList { get; set; }
       public HostingUnit currentHostingUnit { get; set; }

        public Units()
        {
            InitializeComponent();
            bl = FactoryBL.GetFactory();
            // HostingUnitsList = new List<HostingUnit>();
            HostingUnitsList = bl.GetHostingUnits();
                  

            for (int i = 0; i < HostingUnitsList.Count ; i++)
            {
                //currentHostingUnit = bl.GetHostingUnit(HostingUnitsList[i].HostingUnitKey);
                RowDefinition row = new RowDefinition();
                row.MinHeight = 120;

                MainGrid.RowDefinitions.Add(row);

                MiniControl.UnitMini unitMini = new MiniControl.UnitMini(HostingUnitsList[i]);
                MainGrid.Children.Add(unitMini);
                Grid.SetRow(unitMini, i);
            }


        }

        private void AddUnit_Click(object sender, RoutedEventArgs e)
        {
            Window AddUnit = new Control.AddUnit();
            AddUnit.Show();
        }
    }
}
