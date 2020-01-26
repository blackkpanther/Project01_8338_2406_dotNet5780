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

namespace UI.Control
{
    /// <summary>
    /// Interaction logic for Hosts.xaml
    /// </summary>
    public partial class Hosts : UserControl
    {
        public List<Host> HostsList { get; set; }
        private Host currentHost;

        public Hosts()
        {
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
            InitializeComponent();

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
