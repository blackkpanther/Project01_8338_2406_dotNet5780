using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class BL_imp : Ibl
    {
        Idal IDAL;

        public BL_imp()
        {
            IDAL = DAL.FactoryDAL.GetFactory();
            InitList();// בשביל לבדוק לאתחל רשימות משתמשים
        }
        void InitList() // פונקציית אתחול
        {
            try
            {
                IDAL.AddHost(new Host
                {
                    HostKey = 10000001,
                    PrivateName = "1Accccccc",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch(),
                    //{
                    //    BankNumber = 1,
                    //    BankName = "Leumi",
                    //    BranchNumber = 111,
                    //    BranchAddress = "aaaa aaaa",
                    //    BranchCity = "Afula"
                    //},
                    BankAccountNumber = 111,
                    CollectionClearance = true,

                });
                IDAL.AddHost(new Host
                {
                    HostKey = 10000002,
                    PrivateName = "2Accccccc",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch(),
                    //{
                    //    BankNumber = 1,
                    //    BankName =Enums.BankName.BankLeum,
                    //    BranchNumber = 111,
                    //    BranchAddress = "aaaa aaaa",
                    //    BranchCity =Enums.SubArea.Afula,// "Afula"
                    //},
                    BankAccountNumber = 111,
                    CollectionClearance = true,

                });
                IDAL.AddHost(new Host
                {
                    HostKey = 10000003,
                    PrivateName = "3Accccccc",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch(),
                    //{
                    //    BankNumber = 1,
                    //    BankName = "Leumi",
                    //    BranchNumber = 111,
                    //    BranchAddress = "aaaa aaaa",
                    //    BranchCity = "Afula"
                    //},
                    BankAccountNumber = 111,
                    CollectionClearance = true,

                });
                IDAL.AddHost(new Host
                {
                    HostKey = 10000004,
                    PrivateName = "Accccccc",
                    FamilyName = "AA",
                    PhoneNumber = "0000000000",
                    MailAddress = "aaa@gmail.com",
                    BankBranchDetails = new BankBranch(),
                    //{
                    //    BankNumber = 1,
                    //    BankName = "Leumi",
                    //    BranchNumber = 111,
                    //    BranchAddress = "aaaa aaaa",
                    //    BranchCity = "Afula"
                    //},
                    BankAccountNumber = 111,
                    CollectionClearance = true,

                });
                IDAL.AddHostingUnit(new HostingUnit
                {
                    HostingUnitKey = 100000001,
                   UnitName="aa",
                   Adults=3,
                   Children=6,
                   SubArea=Enums.SubArea.Afula,
                   Area=Enums.Area.Center,
                   Pool=Enums.Option.possible,
                   Jacuzzi=Enums.Option.possible,
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
                            BankName = "Leumi",
                            BranchNumber = 111,
                            BranchAddress = "aaaa aaaa",
                            BranchCity = "Afula"
                        },
                        BankAccountNumber = 111,
                        CollectionClearance = true
                    },
                    PricePerNight = 300,
                    Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }
                });
                IDAL.AddHostingUnit(new HostingUnit
                {
                    HostingUnitKey = 100000002,
                    UnitName = "aa",
                    Adults = 3,
                    Children = 6,
                    SubArea = Enums.SubArea.Afula,
                    Area = Enums.Area.Center,
                    Pool = Enums.Option.possible,
                    Jacuzzi = Enums.Option.possible,
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
                            BankName = "Leumi",
                            BranchNumber = 111,
                            BranchAddress = "aaaa aaaa",
                            BranchCity = "Afula"
                        },
                        BankAccountNumber = 111,
                        CollectionClearance = true
                    },
                    PricePerNight = 300,
                    Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }
                });
                IDAL.AddHostingUnit(new HostingUnit
                {
                    HostingUnitKey = 100000003,
                    UnitName = "aa",
                    Adults = 3,
                    Children = 6,
                    SubArea = Enums.SubArea.Afula,
                    Area = Enums.Area.Center,
                    Pool = Enums.Option.possible,
                    Jacuzzi = Enums.Option.possible,
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
                            BankName = "Leumi",
                            BranchNumber = 111,
                            BranchAddress = "aaaa aaaa",
                            BranchCity = "Afula"
                        },
                        BankAccountNumber = 111,
                        CollectionClearance = true
                    },
                    PricePerNight = 300,
                    Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }
                });
                IDAL.AddHostingUnit(new HostingUnit
                {
                    HostingUnitKey = 100000004,
                    UnitName = "aa",
                    Adults = 3,
                    Children = 6,
                    SubArea = Enums.SubArea.Afula,
                    Area = Enums.Area.Center,
                    Pool = Enums.Option.possible,
                    Jacuzzi = Enums.Option.possible,
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
                            BankName = "Leumi",
                            BranchNumber = 111,
                            BranchAddress = "aaaa aaaa",
                            BranchCity = "Afula"
                        },
                        BankAccountNumber = 111,
                        CollectionClearance = true
                    },
                    PricePerNight = 300,
                    Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }
                });
                IDAL.AddHostingUnit(new HostingUnit
                {
                    HostingUnitKey = 100000005,
                    UnitName = "aa",
                    Adults = 3,
                    Children = 6,
                    SubArea = Enums.SubArea.Afula,
                    Area = Enums.Area.Center,
                    Pool = Enums.Option.possible,
                    Jacuzzi = Enums.Option.possible,
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
                            BankName = "Leumi",
                            BranchNumber = 111,
                            BranchAddress = "aaaa aaaa",
                            BranchCity = "Afula"
                        },
                        BankAccountNumber = 111,
                        CollectionClearance = true
                    },
                     PricePerNight = 300,
                    Uris = new List<string>
                        {
                           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                        }
                });


            }
            catch(Exception e)
            {

            }
        
        }

        #region Guest
        void Ibl.AddGuest(Guest guest)
        {
            if(IDAL.GetGuests()!=null)
            {
                foreach (Guest g in IDAL.GetGuests())
                    if (g.GuestKey == guest.GuestKey)
                        throw new Exception("ERROR: This key number is alrady exist.\n");
            }
            guest.GuestKey = IDAL.GetGuests().Count + 1;
            IDAL.AddGuest(guest);
        }

         void Ibl.UpdateGuest(Guest guest)
        {
            IDAL.UpdateGuest(guest);
        }

        void Ibl.DeleteGuest(Guest guest)
        {
            if (IDAL.GetGuests() != null)
            {
                foreach (Guest g in IDAL.GetGuests())
                    if (g.GuestKey == guest.GuestKey)
                        IDAL.DeleteGuest(guest);
            }
            throw new Exception("ERROR: This guest is not exist.\n");
                       
        }

         List<Guest> Ibl.GetGuests()
        {
          return  IDAL.GetGuests();
        }

        public Guest GetGuest(long guestKey)
        {
            if (IDAL.GetGuests() != null)
            {
                foreach (Guest g in IDAL.GetGuests())
                    if (g.GuestKey == guestKey)
                        return IDAL.GetGuest(guestKey);
            }
            throw new Exception("ERROR: This guest is not exist.\n");
           
        }
        #endregion
        #region GustRequest
        void Ibl.AddGuestRequest(GuestRequest request)
        {
            if (request.EntryDate >= request.ReleaseDate)
                throw new Exception("Entry date has to be at least one day before release date");
            request.GuestRequestKey = IDAL.GetGuestRequestList().Count + 1;
            IDAL.AddGuestRequest(request);
        }
        void Ibl.UpdateGuestRequest(GuestRequest request)
        {
            IDAL.UpdateGuestRequest(request);
        }

        List<GuestRequest> Ibl.GetGuestRequestList()
        {
            return IDAL.GetGuestRequestList();
        }
        GuestRequest Ibl.GetGuestRequest(long gustReqKey)
        {
            return IDAL.GetGuestRequest(gustReqKey);
        }

        #endregion
        #region Host
        void Ibl.DeleteHost(Host host)
        {
            var temp= (from item in IDAL.GetHosts() where item.HostKey == host.HostKey select item).FirstOrDefault();
            if (temp != null)
            {
                IDAL.DeleteHost(host);
            }
            else
                throw new Exception("The host you try to delete doesn't exsit/n");
        }
        void Ibl.AddHost(Host host)
        {
            if (IDAL.GetHosts() != null)
            {
                foreach (Host h in IDAL.GetHosts())
                    if (h.HostKey == host.HostKey)
                        throw new Exception("ERROR: This host is alrady exist.\n");
            }
            host.HostKey = IDAL.GetHosts().Count + 1;
            IDAL.AddHost(host);
        }
        void Ibl.UpdateHost(Host host)
        {
            var temp = (from item in IDAL.GetHosts() where item.HostKey == host.HostKey select item).FirstOrDefault();
            if (temp != null)
            {
                IDAL.UpdateHost(host);
            }
            else
                throw new Exception("The host you try to update doesn't exsit/n");
        }
        List<Host> Ibl.GetHosts()
        {
           return IDAL.GetHosts();   
        }

        Host Ibl.GetHost(long hostKey)
        {
            return IDAL.GetHost(hostKey);
        }

        #endregion

        #region HostingUnit
        void Ibl.AddHostingUnit(HostingUnit unit)
        {
            if (IDAL.GetHostingUnits() != null)
            {
                foreach (HostingUnit h in IDAL.GetHostingUnits())
                    if (h.HostingUnitKey == unit.HostingUnitKey)
                        throw new Exception("ERROR: This unit is alrady exist.\n");
            }
            unit.HostingUnitKey = IDAL.GetHostingUnits().Count + 1;
            IDAL.AddHostingUnit(unit);
        }
        void Ibl.DeleteHostingUnit(HostingUnit unit)
        {
            foreach(Order item in IDAL.GetOrderList())
            {
                if(item.HostingUnitKey==unit.HostingUnitKey)
                    throw new Exception("Unable to delete hosting unit because of ongoing order");
            }
             IDAL.DeleteHostingUnit(unit);
        }
        void Ibl.UpdateHostingUnit(HostingUnit unit)
        {
            IDAL.UpdateHostingUnit(unit);
        }
        List<HostingUnit> Ibl.GetHostingUnits()
        {
            return IDAL.GetHostingUnits();
        }
         HostingUnit Ibl.GetHostingUnit(long hostingUnitKey)
        {
            return IDAL.GetHostingUnit(hostingUnitKey);
        }

        #endregion

        #region Order
        void Ibl.AddOrder(Order order)
        {
            HostingUnit u = IDAL.GetHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.GetGuestRequest(order.GuestRequestKey);
            if (u.Diary[g.EntryDate.Day, g.EntryDate.Month] || u.Diary[g.ReleaseDate.Day, g.ReleaseDate.Month])
                throw new Exception("Hosting unit already booked");
            order.OrderKey = IDAL.GetOrderList().Count + 1;
            IDAL.AddOrder(order);
        }
        void Ibl.UpdateOrder(Order order)
        {
            HostingUnit u = IDAL.GetHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.GetGuestRequest(order.GuestRequestKey);
            if (!g.Signed)
                throw new Exception("No standing order confirmation");//אין הרשאת חיוב
            if (order.Status == Enums.Status.Treated)
                throw new Exception("Order already closed");//ההזמנה כבר סגורה
            if (order.Status == Enums.Status.MailSent)
            {
                order.EmailSent = DateTime.Now;
                Console.WriteLine("Email sent");
            }
            if (order.Status == Enums.Status.Treated)
            {
                order.Fee = order.Fee + 10 * (g.ReleaseDate.Day - g.EntryDate.Day);///הוספת עמלה של 10 ש"ח ללילה לתשלום הסופי
                for (int j = g.EntryDate.Month; j <= g.ReleaseDate.Month; j++)
                    for (int i = g.EntryDate.Day; i <= g.ReleaseDate.Day; i++)
                        u.Diary[i, j] = true;
                g.Status = Enums.Status.Treated;
                IDAL.UpdateHostingUnit(u);//עדכון היומן
                IDAL.UpdateGuestRequest(g);///עדכון סטטוס בקשת הלקוח
              //לעדכן גם את כל ההזמנות של הלקוח!!!          
            }
            IDAL.UpdateOrder(order);
        }
        List<Order> Ibl.GetOrderList()
        {
            return IDAL.GetOrderList();
        }
        #endregion

        #region Lists
        List<BankBranch> Ibl.GetBankBranchList()
        {
            return IDAL.GetBankBranchList();
        }
                
        
        List<HostingUnit> Ibl.AvailableHostingUnits(DateTime date, int n)
        {
            List<HostingUnit> tempList = IDAL.GetHostingUnits();
            return tempList.Where(u => u.Diary[date.Month, date.Day]).ToList();
        }
        List<Order> Ibl.NumberOfOrders(int days)
        {
            List<Order> tempList = IDAL.GetOrderList();
            return tempList.Where(order => ((DateTime.Now.Day - order.CreateDate.Day) >= days) || ((DateTime.Now.Day - order.EmailSent.Day) >= days)).ToList();
        }

        /* public IEnumerable<GuestRequest> GetRequestsOfType*/
        IEnumerable<GuestRequest> Ibl.GetRequestsOfType(Func<BE.GuestRequest, bool> predicate = null)
        {
            IEnumerable<GuestRequest> tempList = IDAL.GetGuestRequestList();
            if (predicate == null)
                return tempList.AsEnumerable().Select(g => g.Clone());
            return tempList.Where(predicate).Select(g => g.Clone());
        }
       IEnumerable<HostingUnit> Ibl.GetUnitsOfType(Func<BE.HostingUnit, bool> predicate = null)
        {
            IEnumerable<HostingUnit> tempList = IDAL.GetHostingUnits();
            if (predicate == null)
                return tempList.AsEnumerable().Select(u => u.Clone());
            return tempList.Where(predicate).Select(u => u.Clone());
        }
        IEnumerable<Order> Ibl.GetOrdersOfType(Func<BE.Order, bool> predicate = null)
        {
            IEnumerable<Order> tempList = IDAL.GetOrderList();
            if (predicate == null)
                return tempList.AsEnumerable().Select(o => o.Clone());
            return tempList.Where(predicate).Select(o => o.Clone());
        }
        #endregion

        #region Groups
        IEnumerable<IGrouping<Enums.Area, GuestRequest>> Ibl.GroupRequestsByArea()
        {
            IEnumerable<IGrouping<Enums.Area, GuestRequest>> gByA;
            gByA = from item in IDAL.GetGuestRequestList()
                   group item by item.Area;
            return gByA;
        }
        IEnumerable<IGrouping<int, GuestRequest>> Ibl.GroupRequestsByNumOfGuests()
        {
            IEnumerable<IGrouping<int, GuestRequest>> gByNum;
            gByNum = from item in IDAL.GetGuestRequestList()
                     group item by (item.Adults + item.Children);
            return gByNum;
        }
        IEnumerable<IGrouping<int, Host>> Ibl.GroupHostsByNumOfUnits()
        {
            IEnumerable<IGrouping<int, Host>> gByU;
            gByU = from item in IDAL.GetHosts()
                   group item by item.NumOfUnits;
            return gByU;
        }
        IEnumerable<IGrouping<Enums.Area, HostingUnit>> Ibl.GroupUnitsByArea()
        {
            IEnumerable<IGrouping<Enums.Area, HostingUnit>> gByA;
            gByA = from item in IDAL.GetHostingUnits()
                   group item by item.Area;
            return gByA;
        }

        IEnumerable<IGrouping<Host, HostingUnit>> Ibl.GroupUnitsByHost()
        {
            IEnumerable<IGrouping<Host, HostingUnit>> gByH;
            gByH = from item in IDAL.GetHostingUnits()
                   group item by item.Owner;
            return gByH;
        }
        IEnumerable<IGrouping<Enums.Option, GuestRequest>> Ibl.GroupRequestByPool()
        {
            IEnumerable<IGrouping<Enums.Option, GuestRequest>> gByP;
            gByP = from item in IDAL.GetGuestRequestList()
                   group item by item.Pool;
            return gByP;
        }
        IEnumerable<IGrouping<DateTime, Order>> Ibl.GroupOrdersByCreationDate()
        {
            IEnumerable<IGrouping<DateTime, Order>> gByD;
            gByD = from item in IDAL.GetOrderList()
                   group item by item.CreateDate;
            return gByD;
        }
        IEnumerable<IGrouping<Guest, GuestRequest>> Ibl.GroupRequestsByGuest()
        {
            IEnumerable<IGrouping<Guest, GuestRequest>> gByG;
            gByG = from item in IDAL.GetGuestRequestList()
                   group item by item.Guest;
            return gByG;
        }
        IEnumerable<IGrouping<Enums.Status, Order>> Ibl.GroupOrdersByStatus()
        {
            IEnumerable<IGrouping<Enums.Status, Order>> gByS;
            gByS = from item in IDAL.GetOrderList()
                   group item by item.Status;
            return gByS;
        }
        IEnumerable<IGrouping<Enums.Type, HostingUnit>> Ibl.GroupUnitsByType()
        {
            IEnumerable<IGrouping<Enums.Type, HostingUnit>> gByT;
            gByT = from item in IDAL.GetHostingUnits()
                   group item by item.Type;
            return gByT;
        }
        #endregion

        #region AssistingMethods
        int Ibl.NumberOfDays(DateTime date1, DateTime date2)
        {
            if (date2 == null)
                return Math.Abs(DateTime.Now.Day - date1.Day);
            return Math.Abs(date1.Day - date2.Day);
        }
        int Ibl.NumberOfInvites(GuestRequest request)
        {
            List<Order> tempList = IDAL.GetOrderList();
            var count = (tempList.Count(item => item.GuestRequestKey == request.GuestRequestKey));
            return count;
        }
        int Ibl.NumberOfInvites(HostingUnit unit)
        {
            List<Order> tempList = IDAL.GetOrderList();
            var count = (tempList.Count(item => item.HostingUnitKey == unit.HostingUnitKey && (item.Status == Enums.Status.MailSent || item.Status == Enums.Status.Treated)));
            return count;
        }

       

       

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(long horderKey)
        {
            throw new NotImplementedException();
        }


        #endregion


       
    }
  

}