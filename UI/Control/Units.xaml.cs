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
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : UserControl
    {

        public List<HostingUnit> HostingUnitsList { get; set; }
        private HostingUnit currentHostingUnit;

        public Units()
        {
            HostingUnitsList = new List<HostingUnit>();
            currentHostingUnit = new HostingUnit//לבדיקה
            //אחרי :למחוק שורה ולבדוק אם צריך constructor
            {
                HostingUnitKey = 100000001,
                Owner = new Host
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
                },
                UnitName = "aa",
                Diary = null,//לבדוק!!!!
                SubArea = Enums.SubArea.Dimona,
                Type=Enums.Type.Apartment,
                Adults=4,
                Children=5,
                Pool=Enums.Option.possible,
                Jacuzzi= Enums.Option.possible,
                Garden= Enums.Option.possible,
                ChildrensAttractions= Enums.Option.possible,
                PricePerNight=300,
                Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }

            };
            InitializeComponent();

            for (int i = 0; i < 6; i++)//רק לבדיקה
            {
                HostingUnitsList.Add(currentHostingUnit);
            }

            for (int i = 0; i < 6; i++)
            {
                RowDefinition row = new RowDefinition();
                row.MinHeight = 120;

                MainGrid.RowDefinitions.Add(row);

                MiniControl.UnitMini unitMini = new MiniControl.UnitMini(HostingUnitsList[i]);
               MainGrid.Children.Add(unitMini);
                Grid.SetRow(unitMini, i);
            }


        }

    }
}
