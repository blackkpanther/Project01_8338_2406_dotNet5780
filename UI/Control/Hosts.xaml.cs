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
       
       // public List<Host> HostsList; //{ get; set; }
        public List<Host> currentHostList { get; set; }
        public Host currentHost { get; set; }
        public void getList()//test
        {
            currentHostList = new List<Host>();
            var host1 = new Host()
            {
                HostKey = 10000001,
                PrivateName = "A",
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
                CollectionClearance = true
            };
            currentHostList.Add(host1);
            host1 = new Host()
            {
                HostKey = 10000002,
                PrivateName = "B",
                FamilyName = "BB",
                PhoneNumber = "0000000000",
                MailAddress = "bbb@gmail.com",
                BankBranchDetails = new BankBranch
                {
                    BankNumber = 2,
                    BankName = Enums.BankName.BankLeumi,
                    BranchNumber = 222,
                    BranchAddress = "bbbb bbbb",
                    BranchCity = Enums.SubArea.Afula
                },
                BankAccountNumber = 222,
                CollectionClearance = false

            };
            currentHostList.Add(host1);
            host1 = new Host()
            {
                HostKey = 10000003,
                PrivateName = "C",
                FamilyName = "CC",
                PhoneNumber = "0000000000",
                MailAddress = "ccc@gmail.com",
                BankBranchDetails = new BankBranch
                {
                    BankNumber = 3,
                    BankName = Enums.BankName.BankLeumi,
                    BranchNumber = 333,
                    BranchAddress = "cccc cccc",
                    BranchCity = Enums.SubArea.Afula
                },
                BankAccountNumber = 333,
                CollectionClearance = true

            };
        }
       // public Grid MainGrid = new Grid();
      // public Grid UpGrid = new Grid();

        public Hosts()//(List<Host> hosts)//test
        {
            InitializeComponent();
            getList();
            InitializeHost(currentHostList);//(hosts);//test

        }
        protected void InitializeHost(List<Host> hosts)
        {
           
            // MainGrid.Children.RemoveRange(1, 3);
            MainGrid.SetValue(Grid.RowProperty, 1);
            
            MainGrid.Children.Clear();
            MainGrid.RowDefinitions.Clear();
            currentHostList = hosts;
            MiniControl.HostMini hostMini = null;
            hostMini = new MiniControl.HostMini(currentHostList[0]);
            MainGrid.Children.Add(hostMini);
            Grid.SetRow(hostMini,  1);
            //UpGrid.DataContext = currentHost;
             for (int i = 0; i < hosts.Count; i++)
             {
                 MainGrid.RowDefinitions.Add(new RowDefinition());
                 //currentHost = currentHostList[i];
                 hostMini = new MiniControl.HostMini(currentHostList[i]);
                 MainGrid.Children.Add(hostMini);
                 /*Hosts a = new Hosts(getList());
                 MainGrid.Children.Add(a);*/
                 Grid.SetRow(hostMini, i + 1);

             }
        }



    }
}
