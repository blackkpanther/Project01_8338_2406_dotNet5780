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
            // HostsList = bl.GetHosts();
            HostsList = new List<Host>();

            currentHost = new Host//לבדיקה
            //אחרי :למחוק שורה ולבדוק אם צריך constructor
            {
                HostKey = 10000001,
                PrivateName = "Accccccc",
                FamilyName = "AA",
                PhoneNumber = "0000000000",
                MailAddress = "aaa@gmail.com",
                BankBranchDetails = new BankBranch
                {
                    BankNumber = 1,
                    BankName = Enums.BankName.BankLeumi,
                    BranchNumber = 111,
                    BranchAddress = "aaaa aaaa",
                    BranchCity = Enums.SubArea.Afula
                },
                BankAccountNumber = 111,
                CollectionClearance = true,

            };
            for (int i = 0; i < 6; i++)//רק לבדיקה
            {
                HostsList.Add(currentHost);
            }
            for (int i = 0; i < 6; i++)
            {
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
