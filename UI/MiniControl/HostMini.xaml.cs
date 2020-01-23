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
namespace UI.MiniControl
{
    /// <summary>
    /// Interaction logic for Host.xaml
    /// </summary>
    public partial class HostMini : UserControl
    {
        private BE.Host host;

        //private BE.Host host1 { get; set; }
        //private BE.Host a = new BE.Host();


        // public HostMini CurrentHostMini { get; set; }
        public Host CurrentHost { get; set; }
      
        public HostMini(Host host)
        {
            //InitializeComponent();
            InitializeComponent();
            InitializeHostMini(host);
                                       
        }

        public HostMini(BE.Host host)
        {
            this.host = host;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException("gvjgvkh");
        }

        /*public HostMini(BE.Host host)
         {

             this.host1 = host;
         }
         public HostMini()
         {

             this.host1 = a;
         }*/

        private void InitializeHostMini(Host host)
        {
            this.CurrentHost = host;
        }



    }
}

/* {
*  this.DataContext = this;
* 
* private long hostKey;
private string privateName;
private string familyName;
private string phoneNumber;
private string mailAddress;
private BankBranch bankBranchDetails;
private int bankAccountNumber;
private bool collectionClearance;
private int numOfUnits;}*/
