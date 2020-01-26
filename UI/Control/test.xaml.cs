using BE;
using System.Collections.Generic;
using System.Windows.Controls;

namespace UI.Control
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : UserControl
    {
        public List<Host> HostsList { get; set; }
        private Host currentHost;

        public test()
        {
            HostsList = new List<Host>();
            currentHost = new Host
            {
                HostKey = 10000001,
                PrivateName = "Accccccc",
                FamilyName = "AA",
                PhoneNumber = "0000000000",
                MailAddress = "aaa@gmail.com",
                BankBranchDetails = new BankBranch
                {
                    BankNumber = 1,
                    BankName = "Leumi",
                    BranchNumber = 111,
                    BranchAddress = "aaaa aaaa",
                    BranchCity = "Afula"
                },
                BankAccountNumber = 111,
                CollectionClearance = true,

            };
            InitializeComponent();
            //InitializeTest();
            for (int i = 0; i < 6; i++)//רק לבדיקה
            {
                HostsList.Add(currentHost);
            }

            for (int i = 0; i < 6; i++)
            {
                // row.Height.Value() = "120";

                RowDefinition row = new RowDefinition();
                row.MinHeight = 120;

                MainGrid.RowDefinitions.Add(row);

                MiniControl.miniTest miniTes1t = new MiniControl.miniTest(HostsList[i]);
                MainGrid.Children.Add(miniTes1t);
                Grid.SetRow(miniTes1t, i);
            }

        }
        protected void InitializeTest()
        {

            /* for (int i = 0; i < 6; i++)
             {
                 RowDefinition row = new RowDefinition();
                 row.MinHeight = 120;
                 MainGrid.RowDefinitions.Add(row);

             }*/
            //MainGrid.Children.Clear();
            /*for (int i =0; i<6;i++)
            {

                // row.Height.Value() = "120";

                RowDefinition row = new RowDefinition();
                row.MinHeight = 120;

                MainGrid.RowDefinitions.Add(row);

                MiniControl.miniTest miniTes1t = new MiniControl.miniTest();
                MainGrid.Children.Add(miniTes1t);
                Grid.SetRow(miniTes1t, i);
            }*/

            //Grid.SetRow(miniTes1t, 0);


        }


    }
}
