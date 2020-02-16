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
           // IDAL = DAL.FactoryDAL.GetFactory("XML");
              IDAL = DAL.FactoryDAL.GetFactory("List");
            InitList();// בשביל לבדוק לאתחל רשימות משתמשים
        }
        void InitList() // פונקציית אתחול
        {
            try
            {
                IDAL.AddHost(new Host
                {
                   // HostKey = 10000001,
                    PrivateName = "first",
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
                //IDAL.AddHost(new Host
                //{
                //  //  HostKey = 10000002,
                //    PrivateName = "2Accccccc",
                //    FamilyName = "AA",
                //    PhoneNumber = "0000000000",
                //    MailAddress = "aaa@gmail.com",
                //    BankBranchDetails = new BankBranch(),
                //    //{
                //    //    BankNumber = 1,
                //    //    BankName =Enums.BankName.BankLeum,
                //    //    BranchNumber = 111,
                //    //    BranchAddress = "aaaa aaaa",
                //    //    BranchCity =Enums.SubArea.Afula,// "Afula"
                //    //},
                //    BankAccountNumber = 111,
                //    CollectionClearance = true,

                //});
                //IDAL.AddHost(new Host
                //{
                //    HostKey = 10000003,
                //    PrivateName = "3Accccccc",
                //    FamilyName = "AA",
                //    PhoneNumber = "0000000000",
                //    MailAddress = "aaa@gmail.com",
                //    BankBranchDetails = new BankBranch(),
                //    //{
                //    //    BankNumber = 1,
                //    //    BankName = "Leumi",
                //    //    BranchNumber = 111,
                //    //    BranchAddress = "aaaa aaaa",
                //    //    BranchCity = "Afula"
                //    //},
                //    BankAccountNumber = 111,
                //    CollectionClearance = true,

                //});
                //IDAL.AddHost(new Host
                //{
                //    HostKey = 10000004,
                //    PrivateName = "Accccccc",
                //    FamilyName = "AA",
                //    PhoneNumber = "0000000000",
                //    MailAddress = "aaa@gmail.com",
                //    BankBranchDetails = new BankBranch(),
                //    //{
                //    //    BankNumber = 1,
                //    //    BankName = "Leumi",
                //    //    BranchNumber = 111,
                //    //    BranchAddress = "aaaa aaaa",
                //    //    BranchCity = "Afula"
                //    //},
                //    BankAccountNumber = 111,
                //    CollectionClearance = true,

                //});
                //IDAL.AddHostingUnit(new HostingUnit
                //{
                //    HostingUnitKey = 100000001,
                //    UnitName = "aa",
                //    Adults = 3,
                //    Children = 6,
                //    SubArea = Enums.SubArea.Afula,
                //    Area = Enums.Area.Center,
                //    Pool = Enums.OptionForUnit.Yes,
                //    Jacuzzi = Enums.OptionForUnit.Yes,
                //    Owner = new Host
                //    {
                //        HostKey = 10000001,
                //        PrivateName = "A",
                //        FamilyName = "AA",
                //        PhoneNumber = "0000000000",
                //        MailAddress = "aaa@gmail.com",
                //        BankBranchDetails = new BankBranch
                //        {
                //            BankNumber = 1,
                //            BankName = "Leumi",
                //            BranchNumber = 111,
                //            BranchAddress = "aaaa aaaa",
                //            BranchCity = "Afula"
                //        },
                //        BankAccountNumber = 111,
                //        CollectionClearance = true
                //    },
                //    PricePerNight = 300,
                //    Uris = new List<string>
                //        {
                //           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                //           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                //        }
                //});
                //IDAL.AddHostingUnit(new HostingUnit
                //{
                //    HostingUnitKey = 100000002,
                //    UnitName = "aa",
                //    Adults = 3,
                //    Children = 6,
                //    SubArea = Enums.SubArea.Afula,
                //    Area = Enums.Area.Center,
                //    Pool = Enums.OptionForUnit.Yes,
                //    Jacuzzi = Enums.OptionForUnit.Yes,
                //    Owner = new Host
                //    {
                //        HostKey = 10000001,
                //        PrivateName = "A",
                //        FamilyName = "AA",
                //        PhoneNumber = "0000000000",
                //        MailAddress = "aaa@gmail.com",
                //        BankBranchDetails = new BankBranch
                //        {
                //            BankNumber = 1,
                //            BankName = "Leumi",
                //            BranchNumber = 111,
                //            BranchAddress = "aaaa aaaa",
                //            BranchCity = "Afula"
                //        },
                //        BankAccountNumber = 111,
                //        CollectionClearance = true
                //    },
                //    PricePerNight = 300,
                //    Uris = new List<string>
                //        {
                //           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                //           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                //        }
                //});
                //IDAL.AddHostingUnit(new HostingUnit
                //{
                //    HostingUnitKey = 100000003,
                //    UnitName = "aa",
                //    Adults = 3,
                //    Children = 6,
                //    SubArea = Enums.SubArea.Afula,
                //    Area = Enums.Area.Center,
                //    Pool = Enums.OptionForUnit.Yes,
                //    Jacuzzi = Enums.OptionForUnit.Yes,
                //    Owner = new Host
                //    {
                //        HostKey = 10000001,
                //        PrivateName = "A",
                //        FamilyName = "AA",
                //        PhoneNumber = "0000000000",
                //        MailAddress = "aaa@gmail.com",
                //        BankBranchDetails = new BankBranch
                //        {
                //            BankNumber = 1,
                //            BankName = "Leumi",
                //            BranchNumber = 111,
                //            BranchAddress = "aaaa aaaa",
                //            BranchCity = "Afula"
                //        },
                //        BankAccountNumber = 111,
                //        CollectionClearance = true
                //    },
                //    PricePerNight = 300,
                //    Uris = new List<string>
                //        {
                //           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                //           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                //        }
                //});
                //IDAL.AddHostingUnit(new HostingUnit
                //{
                //    HostingUnitKey = 100000004,
                //    UnitName = "aa",
                //    Adults = 3,
                //    Children = 6,
                //    SubArea = Enums.SubArea.Afula,
                //    Area = Enums.Area.Center,
                //    Pool = Enums.OptionForUnit.Yes,
                //    Jacuzzi = Enums.OptionForUnit.Yes,
                //    Owner = new Host
                //    {
                //        HostKey = 10000001,
                //        PrivateName = "A",
                //        FamilyName = "AA",
                //        PhoneNumber = "0000000000",
                //        MailAddress = "aaa@gmail.com",
                //        BankBranchDetails = new BankBranch
                //        {
                //            BankNumber = 1,
                //            BankName = "Leumi",
                //            BranchNumber = 111,
                //            BranchAddress = "aaaa aaaa",
                //            BranchCity = "Afula"
                //        },
                //        BankAccountNumber = 111,
                //        CollectionClearance = true
                //    },
                //    PricePerNight = 300,
                //    Uris = new List<string>
                //        {
                //           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                //           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                //        }
                //});
                //IDAL.AddHostingUnit(new HostingUnit
                //{
                //    HostingUnitKey = 100000005,
                //    UnitName = "aa",
                //    Adults = 3,
                //    Children = 6,
                //    SubArea = Enums.SubArea.Afula,
                //    Area = Enums.Area.Center,
                //    Pool = Enums.OptionForUnit.Yes,
                //    Jacuzzi = Enums.OptionForUnit.Yes,
                //    Owner = new Host
                //    {
                //        HostKey = 10000001,
                //        PrivateName = "A",
                //        FamilyName = "AA",
                //        PhoneNumber = "0000000000",
                //        MailAddress = "aaa@gmail.com",
                //        BankBranchDetails = new BankBranch
                //        {
                //            BankNumber = 1,
                //            BankName = "Leumi",
                //            BranchNumber = 111,
                //            BranchAddress = "aaaa aaaa",
                //            BranchCity = "Afula"
                //        },
                //        BankAccountNumber = 111,
                //        CollectionClearance = true
                //    },
                //    PricePerNight = 300,
                //    Uris = new List<string>
                //        {
                //           "https://q-ak.bstatic.com/images/hotel/max1024x768/194/194305766.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/240/240310117.jpg",
                //           "https://q-ak.bstatic.com/images/hotel/max1280x900/193/193378835.jpg",
                //           "https://r-ak.bstatic.com/images/hotel/max1280x900/193/193379099.jpg"
                //        }
                //});


            }
            catch (Exception e)
            {
                throw new Exception("ERROR: InitList\n");

            }

        }

        #region Guest
        void Ibl.AddGuest(Guest guest)
        {
            try
            {
                if (IDAL.GetGuests() == null)//the first guest
                    guest.GuestKey = Configuration.GetNewSerialGuestKey();
                else
                {
                    if (guest.GuestKey == 0)//new key
                        guest.GuestKey = IDAL.GetGuests().LastOrDefault().GuestKey + 1;

                    if (IDAL.GetGuest(guest.GuestKey) != null)//key exist
                        throw new Exception(String.Format("ERROR: Guest key number is alrady exist.\n key num:{0} ", guest.GuestKey));
                }
                IDAL.AddGuest(guest);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl add guest- key num:{0} ", guest.GuestKey));
            }
            
        }

        void Ibl.UpdateGuest(Guest guest)
        {
            try
            {
                if (IDAL.GetGuest(guest.GuestKey) != null)//check guest exist
                    IDAL.UpdateGuest(guest);
                else
                    throw new Exception("The guest you try to update doesn't exsit/n");
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl update guest- key num:{0} ", guest.GuestKey));
            }
          
        }

        void Ibl.DeleteGuest(Guest guest)
        {
            try
            {
               if (IDAL.GetGuest(guest.GuestKey)!=null)//check guest exist
                    IDAL.DeleteGuest(guest);

            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl delete guest- key num:{0} ", guest.GuestKey));

            }
        }

        List<Guest> Ibl.GetGuests()
        {
            try
            {
                return IDAL.GetGuests();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get guest list "));
            }
        }

        Guest Ibl.GetGuest(long guestKey)
        {
            try
            {
                if (IDAL.GetGuest(guestKey) != null)//check guest exist
                    return IDAL.GetGuest(guestKey);
                throw new Exception("ERROR: This guest is not exist.\n");
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get guest- key num:{0} ", guestKey));

            }
        }
        #endregion

        #region GustRequest
        void Ibl.AddGuestRequest(GuestRequest request)
        {
            try
            {
                if (request.EntryDate >= request.ReleaseDate)
                    throw new Exception("Entry date has to be at least one day before release date");
                if (IDAL.GetGuestRequestList() == null)//the first req
                    request.GuestRequestKey = Configuration.GetNewSerialGuestRequestKey();
                else
                {
                    if (request.GuestRequestKey == 0)// new key
                        request.GuestRequestKey = IDAL.GetGuestRequestList().LastOrDefault().GuestRequestKey + 1;
                    if (IDAL.GetGuestRequest(request.GuestRequestKey) != null)//key exist
                   throw new Exception(String.Format("ERROR: Guest request key number is alrady exist.\n key num:{0} ", request.GuestRequestKey));
                }
                IDAL.AddGuestRequest(request);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl add guest request- key num:{0} ", request.GuestRequestKey));
            }
           
        }
        void Ibl.UpdateGuestRequest(GuestRequest request)
        {
            try
            {
                if(IDAL.GetGuestRequest(request.GuestRequestKey)!=null)//check req exist
                          IDAL.UpdateGuestRequest(request);
                else
                    throw new Exception("The req you try to update doesn't exsit/n");
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl update guest req- key num:{0} ", request.GuestRequestKey));
            }  
        }

        List<GuestRequest> Ibl.GetGuestRequestList()
        {
            try
            {
                return IDAL.GetGuestRequestList();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get guest req list "));
            }
        }
        GuestRequest Ibl.GetGuestRequest(long gustReqKey)
        {
            try
            {
                return IDAL.GetGuestRequest(gustReqKey);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get guest req- key num:{0} ", gustReqKey));
            }
           
        }

        #endregion
       
        #region Host
        void Ibl.DeleteHost(Host host)
        {
            try
            {
                if(IDAL.GetHost(host.HostKey)!=null)//check host exist
                   IDAL.DeleteHost(host);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl delete host- key num:{0} ", host.HostKey));
            }
        }
        void Ibl.AddHost(Host host)
        {
            try
            {
                if (IDAL.GetHosts() == null)//first host
                    host.HostKey = Configuration.GetNewSerialHostKey();
                else
                {
                    if(host.HostKey==0)
                        host.HostKey = IDAL.GetHosts().LastOrDefault().HostKey + 1;
                    if(IDAL.GetHost(host.HostKey)!=null)//key exist
                        throw new Exception("ERROR: This host is alrady exist.\n");
                }
                host.NumOfUnits = 0;              
                IDAL.AddHost(host);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl add host- key num:{0} ", host.HostKey));
            }
        }
        void Ibl.UpdateHost(Host host)
        {
            try
            {
                if (IDAL.GetHost(host.HostKey)!=null)//check host exist
                         IDAL.UpdateHost(host);
                else

                    throw new Exception("The host you try to update doesn't exsit/n");
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl update host- key num:{0} ", host.HostKey));
            }
           
        }
        List<Host> Ibl.GetHosts()
        {
            try
            {
                return IDAL.GetHosts();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get host list "));

            }

        }
        Host Ibl.GetHost(long hostKey)
        {
            try
            {
                if (IDAL.GetHost(hostKey) != null)//check host exist
                    return IDAL.GetHost(hostKey);
                else
                    throw new Exception("The host you try to update doesn't exsit/n");
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl get host- key num:{0} ", hostKey));
            }
        }
        #endregion

        #region HostingUnit
        void Ibl.AddHostingUnit(HostingUnit unit)
        {
            try 
            {
                Host ownerUnit = unit.Owner;
                if (IDAL.GetHostingUnits() == null)//first unit
                    unit.HostingUnitKey = Configuration.GetNewSerialHostingUnitKey();
                else
                {
                    if (unit.HostingUnitKey == 0)// new unit- new key and update host unit num
                    {
                        unit.HostingUnitKey = IDAL.GetHostingUnits().LastOrDefault().HostingUnitKey + 1;
                        ownerUnit.NumOfUnits += 1;                       
                    }
                    if(IDAL.GetHostingUnit(unit.HostingUnitKey)!=null)//key exist
                        throw new Exception("ERROR: This unit is alrady exist.\n");
                }            
                IDAL.AddHostingUnit(unit);
                IDAL.UpdateHost(ownerUnit);//after add unit //update host for numOfUnits
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl add unit- key num:{0} ", unit.HostingUnitKey));
            }
        }
        void Ibl.DeleteHostingUnit(HostingUnit unit)
        {
            try
            {
                if (IDAL.GetHostingUnit(unit.HostingUnitKey) != null)//check unit exist
                    if((from item in IDAL.GetOrderList() where   //check if the unit exist in open order //only futur orders:                    
                                (item.HostingUnitKey==unit.HostingUnitKey) && ((item.OrderDate-DateTime.Now) > new TimeSpan()) 
                         select item).FirstOrDefault() !=null )
                        throw new Exception("Unable to delete hosting unit because of ongoing order");
                else
                    throw new Exception("Unable to delete hosting unit does not exist");
                Host ownerUnit = unit.Owner;
                IDAL.DeleteHostingUnit(unit);
                ownerUnit.NumOfUnits -= 1;
                IDAL.UpdateHost(ownerUnit);//after delete unit //update host for numOfUnits
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n bl delete unit- key num:{0} ", unit.HostingUnitKey));
            }
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
            if (u == null) throw new Exception("unit does not exist ");
            GuestRequest g = IDAL.GetGuestRequest(order.GuestRequestKey);
            if (g == null) throw new Exception("req does not exist ");
           
            if (!AvailableUnit(order))
                throw new Exception(" Hosting unit already booked \n");

            var numOfDays = (g.ReleaseDate- g.EntryDate ).TotalDays;
            for (int i = 0; i < numOfDays; i++)
            {
                u.AllDates.Add(g.EntryDate.AddDays(i));
            }

            if (IDAL.GetOrderList() == null)// the first guest
                order.OrderKey = Configuration.GetNewSerialOrderKey();
            else
                if (order.OrderKey == 0)// new guest- not an update
                order.OrderKey = IDAL.GetOrderList().LastOrDefault().OrderKey + 1;
            IDAL.AddOrder(order);
        }

        void Ibl.UpdateOrder(Order order)
        {
            
            HostingUnit u = IDAL.GetHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.GetGuestRequest(order.GuestRequestKey);
            Order ogOrder = IDAL.GetOrder(order.OrderKey);
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
               
                var numOfDays = ((IDAL.GetGuestRequest(ogOrder.GuestRequestKey).ReleaseDate)- (IDAL.GetGuestRequest(ogOrder.GuestRequestKey).EntryDate)).TotalDays;
                for (int i = 0; i < numOfDays; i++)//clear original dates 
                    IDAL.GetHostingUnit(ogOrder.HostingUnitKey).AllDates.Remove(IDAL.GetGuestRequest(ogOrder.GuestRequestKey).EntryDate.AddDays(i));
                if (!AvailableUnit(order))//if days not available book  original dates back and not updating order
                {
                    for (int i = 0; i < numOfDays; i++)
                       IDAL.GetHostingUnit(ogOrder.HostingUnitKey).AllDates.Add(IDAL.GetGuestRequest(ogOrder.GuestRequestKey).EntryDate.AddDays(i));
                    throw new Exception("Order new dates not available");
                }
                g.Status = Enums.Status.Treated;
                IDAL.UpdateHostingUnit(u);//עדכון היומן
                IDAL.UpdateGuestRequest(g);///עדכון סטטוס בקשת הלקוח
              //לעדכן גם את כל ההזמנות של הלקוח!!!          
            }
            IDAL.UpdateOrder(order);
        }
        void Ibl.DeleteOrder(Order order)
        {
            IDAL.DeleteOrder(order);
        }

        Order Ibl.GetOrder(long horderKey)
        {
           return IDAL.GetOrder(horderKey);
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

        bool AvailableUnit(Order order)
        {
            HostingUnit u = IDAL.GetHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.GetGuestRequest(order.GuestRequestKey);
            bool flag = true;
            var numOfDays = (g.ReleaseDate - g.EntryDate).TotalDays;
            for (int i = 0; i < numOfDays; i++)
                if (u.AllDates.Find(d => d == g.EntryDate.AddDays(i)) != null)
                {
                    flag = false;
                    break;
                }
            return flag;
        }
        List<HostingUnit> Ibl.AvailableHostingUnits(DateTime date, int n)
        {
            List<HostingUnit> tempList = new List<HostingUnit>(); //IDAL.GetHostingUnits();
            foreach (HostingUnit h in IDAL.GetHostingUnits())
            {
                bool flag = true;
                for (int i = 0; i < n; i += 1)
                {
                    if (h.AllDates.Find(d => d == date.AddDays(i)) != null)
                        flag = false;
                    break;
                }
                if (flag)
                    tempList.Add(h);
            }
            if (tempList == null)
                throw new Exception("There are no available at these dates\n");
            return tempList;
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
                return tempList.AsEnumerable().Select(g => g.Clone());//בודק רשימה ראשית לא ריקה
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

        #endregion



    }


}