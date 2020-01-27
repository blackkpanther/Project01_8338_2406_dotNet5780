using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Threading;
using System.Threading.Tasks;
using BE;
using System.Xml.Serialization;
using System.Net;
using System.ComponentModel;

namespace DAL
{
    class DAL_XML : Idal
    {

        private XElement hostsFile, guestsFile, ordersFile, unitsFile, guestsReqFile, bankFile;
        string hostPath = "Hosts.xml";
        string guestPath = "Guests.xml";
        string ordersPath = "Orders.xml";
        string unitPath = "Units.xml";
        string guestsReqPath = "GuestsReq.xml";
        //string bankPath = @"BranchXML.xml";

        List<BankBranch> branches = new List<BankBranch>();
        //BackgroundWorker worker = new BackgroundWorker();



        public DAL_XML()
        {
            if (!System.IO.File.Exists(hostPath))
            {
                SaveToXML(new List<Host>(), hostPath);
            }
            else
                LoadData(hostPath);

            if (!System.IO.File.Exists(guestPath))
            {
                SaveToXML(new List<Guest>(), guestPath);
            }
            else
                LoadData(guestPath);

            if (!System.IO.File.Exists(ordersPath))
            {
                SaveToXML(new List<Order>(), ordersPath);
            }
            else
                LoadData(ordersPath);

            if (!System.IO.File.Exists(guestsReqPath))
            {
                SaveToXML(new List<GuestRequest>(), guestsReqPath);
            }
            else
                LoadData(guestsReqPath);

            //if (!System.IO.File.Exists(unitPath))
            //{
            //    SaveToXML(new List<HostingUnit>(), unitPath);
            //}
            //else
            //    LoadData(unitPath);


        }


        #region XML

        public static void SaveToXML<T>(T source, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source);
            file.Close();
        }

        public static T LoadFromXML<T>(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T result = (T)xmlSerializer.Deserialize(file);
            file.Close();
            return result;
        }

        private void LoadData(string path)
        {
            try
            {
                switch (path)
                {
                    case "Guests.xml":
                        guestsFile = XElement.Load(guestPath);
                        break;
                    case "Orders.xml":
                        ordersFile = XElement.Load(ordersPath);
                        break;
                    case "Hosts.xml":
                        hostsFile = XElement.Load(hostPath);
                        break;
                    case "Units.xml":
                        unitsFile = XElement.Load(unitPath);
                        break;
                    case "GuestsReq.xml":
                        guestsReqFile = XElement.Load(guestsReqPath);
                        break;
                    //case "snifim_dnld_he.xml":
                    //    bankFile = XElement.Load(bankPath);
                    //    break;
                    default:
                        throw new Exception("File upload problem");
                }
            }
            catch
            {
                throw new Exception("File upload problem");
            }

            //worker.DoWork += w_doWork;
            //worker.RunWorkerAsync();

        }

        //public void w_doWork(object sender, DoWorkEventArgs e)
        //{
        //    if (bankFile.IsEmpty)
        //    {
        //        const string xmlLocalPath = @"atm.xml";
        //        WebClient wc = new WebClient();
        //        try
        //        {
        //            string xmlServerPath =
        //           @"http://www.boi.org.il/he/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/atm.xml";
        //            wc.DownloadFile(xmlServerPath, xmlLocalPath);
        //        }
        //        catch (Exception)
        //        {
        //            string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";
        //            wc.DownloadFile(xmlServerPath, xmlLocalPath);
        //        }
        //        finally
        //        {
        //            wc.Dispose();
        //        }
        //        if (!File.Exists(xmlLocalPath))
        //        {
        //            throw new Exception("File upload problem");
        //        }
        //        bankFile = LoadData(bankPath);
        //        foreach (var item in bankFile.Elements())
        //        {
        //            branches.Add(new BankBranch()
        //            {
        //                BranchAddress = item.Element("כתובת_ה-ATM").value,
        //                BankNumber = item.Element("קוד_בנק").Value,
        //                BankName = item.Element("שם_בנק").Value,
        //                BranchCity = item.Element("ישוב").value,
        //                BranchNumber = item.Element("קוד_סניף").value
        //            };)
        //        }
        //    }
        //    else
        //    {
        //        foreach (itme in bankFile.Elements())
        //        {
        //            branches.Add(new BankBranch()
        //            {
        //                BranchAddress = item.Element("כתובת_ה-ATM").value,
        //                BankNumber = item.Element("קוד_בנק").value,
        //                BankName = item.Element("שם_בנק").value,
        //                BranchCity = item.Element("ישוב").value,
        //                BranchNumber = item.Element("קוד_סניף").value
        //            };)
        //        }
        //    }
        //    branches = branches.GroupBy(x => x.BranchNumber).Select(y => y.FirstOrDefault()).ToList();
        //}

        //private void CreateFiles(XElement root, string s, string path)
        //{
        //    root = new XElement(s);
        //    root.Save(path);
        //}

        #endregion


        #region Host

        public void AddHost(Host host)
        {
            var list = LoadFromXML<List<Host>>(hostPath);
            list.Add(host);
            SaveToXML<List<Host>>(list, hostPath);
        }

        public Host GetHost(long hostKey)
        {
            var list = LoadFromXML<List<Host>>(hostPath);
            Host host = (from h in list where h.HostKey == hostKey select h).FirstOrDefault();
            if (host == null)
                throw new Exception("The host you're trying to get doesn't exist");
            return host;
        }

        public void DeleteHost(Host host)
        {
            var list = LoadFromXML<List<Host>>(hostPath);
            list.Remove(host);
            SaveToXML<List<Host>>(list, hostPath);
        }

        public List<Host> GetHosts()
        {
            List<Host> hosts = LoadFromXML<List<Host>>(hostPath);
            if (hosts == null)
                throw new Exception("This File is empty");
            return hosts;
        }

        public void UpdateHost(Host host)
        {
            var list = LoadFromXML<List<Host>>(hostPath);
            Host upDate = (from h in list where h.HostKey == host.HostKey select h).FirstOrDefault();
            if (upDate == null)
                throw new Exception("The host you're trying to upDate doesn't exist");

            list.Remove(upDate);//delete the old host
            list.Add(host);//insert the update host
            SaveToXML<List<Host>>(list, hostPath);
        }






        #endregion


        #region Unit

        public void AddHostingUnit(HostingUnit unit)
        {
            var list = LoadFromXML<List<HostingUnit>>(unitPath);
            list.Add(unit);
            //SaveToXML<List<Host>>(list, unitPath);
        }


        public List<HostingUnit> GetHostingUnits()
        {
            List<HostingUnit> units = LoadFromXML<List<HostingUnit>>(unitPath);
            if (units == null)
                throw new Exception("This File is empty");
            return units;
        }


        public void DeleteHostingUnit(HostingUnit unit)
        {
            var list = LoadFromXML<List<HostingUnit>>(unitPath);
            list.Remove(unit);
            SaveToXML<List<HostingUnit>>(list, unitPath);
        }

        public void UpdateHostingUnit(HostingUnit unit)
        {
            var list = LoadFromXML<List<HostingUnit>>(unitPath);
            HostingUnit upDate = (from u in list where u.HostingUnitKey == unit.HostingUnitKey select u).FirstOrDefault();
            if (upDate == null)
                throw new Exception("The unit you're trying to upDate doesn't exist");

            list.Remove(upDate);//delete the old unit
            list.Add(unit);//insert the update unit
            SaveToXML<List<HostingUnit>>(list, unitPath);
        }

        public HostingUnit GetHostingUnit(long hostingUnitKey)
        {
            var list = LoadFromXML<List<HostingUnit>>(unitPath);
            HostingUnit unit = (from u in list where u.HostingUnitKey == hostingUnitKey select u).FirstOrDefault();
            if (unit == null)
                throw new Exception("The unit you're trying to get doesn't exist");
            return unit;
        }

        #endregion

        #region Order

        public void AddOrder(Order order)
        {
            var list = LoadFromXML<List<Order>>(ordersPath);
            list.Add(order);
            SaveToXML<List<Order>>(list, ordersPath);
        }

        public List<Order> GetOrderList()
        {
            List<Order> orders = LoadFromXML<List<Order>>(ordersPath);
            if (orders == null)
                throw new Exception("This File is empty");
            return orders;
        }

        public void UpdateOrder(Order order)
        {
            var list = LoadFromXML<List<Order>>(ordersPath);
            Order upDate = (from o in list where o.OrderKey == order.OrderKey select o).FirstOrDefault();
            if (upDate == null)
                throw new Exception("The order you're trying to upDate doesn't exist");

            list.Remove(upDate);//delete the old order
            list.Add(order);//insert the update order
            SaveToXML<List<Order>>(list, ordersPath);
        }

        public void DeleteOrder(Order order)
        {
            var list = LoadFromXML<List<Order>>(ordersPath);
            list.Remove(order);
            SaveToXML<List<Order>>(list, ordersPath);
        }

        public Order GetOrder(long horderKey)
        {
            var list = LoadFromXML<List<Order>>(ordersPath);
            Order order = (from o in list where o.OrderKey == horderKey select o).FirstOrDefault();
            if (order == null)
                throw new Exception("The unit you're trying to get doesn't exist");
            return order;
        }

        #endregion

        #region Guest

        void Idal.AddGuest(Guest guest)
        {
            var list = LoadFromXML<List<Guest>>(guestPath);
            list.Add(guest);
            SaveToXML<List<Guest>>(list, guestPath);
        }

        void Idal.UpdateGuest(Guest guest)
        {
            var list = LoadFromXML<List<Guest>>(guestPath);
            Guest upDate = (from g in list where g.GuestKey == guest.GuestKey select g).FirstOrDefault();
            if (upDate == null)
                throw new Exception("The order you're trying to upDate doesn't exist");

            list.Remove(upDate);//delete the old order
            list.Add(guest);//insert the update order
            SaveToXML<List<Guest>>(list, guestPath);
        }

        void Idal.DeleteGuest(Guest guest)
        {
            var list = LoadFromXML<List<Guest>>(guestPath);
            list.Remove(guest);
            SaveToXML<List<Guest>>(list, guestPath);
        }

        List<Guest> Idal.GetGuests()
        {
            List<Guest> guests = LoadFromXML<List<Guest>>(guestPath);
            if (guests == null)
                throw new Exception("This File is empty");
            return guests;
        }

        Guest Idal.GetGuest(long guestKey)
        {
            var list = LoadFromXML<List<Guest>>(guestPath);
            Guest guest = (from g in list where g.GuestKey == guestKey select g).FirstOrDefault();
            if (guest == null)
                throw new Exception("The unit you're trying to get doesn't exist");
            return guest;
        }


        #endregion

        #region GuestReq

        public void AddGuestRequest(GuestRequest request)
        {
            var list = LoadFromXML<List<GuestRequest>>(guestsReqPath);
            list.Add(request);
            SaveToXML<List<GuestRequest>>(list, guestsReqPath);
        }

        public List<GuestRequest> GetGuestRequestList()
        {
            List<GuestRequest> gr = LoadFromXML<List<GuestRequest>>(guestsReqPath);
            if (gr == null)
                throw new Exception("This File is empty");
            return gr;
        }

        public void UpdateGuestRequest(GuestRequest gRequest)
        {
            var list = LoadFromXML<List<GuestRequest>>(guestsReqPath);
            GuestRequest upDate = (from gr in list where gr.GuestRequestKey == gRequest.GuestRequestKey select gr).FirstOrDefault();
            if (upDate == null)
                throw new Exception("The request you're trying to upDate doesn't exist");

            list.Remove(upDate);//delete the old req
            list.Add(gRequest);//insert the update req
            SaveToXML<List<GuestRequest>>(list, guestsReqPath);
        }

        public GuestRequest GetGuestRequest(long gustReqKey)
        {
            var list = LoadFromXML<List<GuestRequest>>(guestsReqPath);
            GuestRequest gr = (from g in list where g.GuestRequestKey == gustReqKey select g).FirstOrDefault();
            if (gr == null)
                throw new Exception("The unit you're trying to get doesn't exist");
            return gr;
        }


        #endregion


        //public List<BankBranch> GetBankBranchList()
        //{
        //    List<BankBranch> b = LoadFromXML<List<BankBranch>>(bankPath);/////////////////ADD THE PATH TO BankBranch FILE!!!!
        //    if (b == null)
        //        throw new Exception("This File is empty");
        //    return b;
        //}

        public List<BankBranch> GetBankBranchList()
        {
            return new List<BankBranch>()
            {
                new BankBranch()
                {
                    BankName="Citibank N.A",
                    BankNumber=22,
                    BranchAddress="דרך מנחם בגין 121 מגדל עזריאלי שרונה",
                    BranchCity="תל אביב -יפו",
                    BranchNumber=1
                },

                new BankBranch()
                {
                    BankNumber = 1,
                    BankName = "Leumi",
                    BranchNumber = 111,
                    BranchAddress = "aaaa aaaa",
                    BranchCity = "Afula"
                },
                new BankBranch()
                {
                    BankName="SBI State Bank of India",
                    BankNumber=39,
                    BranchAddress="זבוטינסקי 3 3",
                    BranchCity="רמת גן",
                    BranchNumber=1
                }
            };
        }



        public void Clean()
        {
            Thread t = new Thread(DailyUpdate);
            t.Start();
        }
        public void DailyUpdate()//
        {
            try
            {
                List<GuestRequest> oldRequests = GetGuestRequestList();
                oldRequests.Where(req => ((DateTime.Now.Day - req.RegistrationDate.Day) > 30));

                foreach (var item in oldRequests)
                {
                    oldRequests.Remove(item);
                }
            }
            catch
            {

                if (guestsReqFile.IsEmpty)
                    throw new Exception("no old req");
            }
            Thread.Sleep(1440000);
        }

    }
}

//class DAL_XML
//{
//    //Roots and paths of the files
//    XElement unitRoot;
//    string unitPath = @"UnitsXML.xml";

//    XElement requestRoot;
//    string requestPath = @"RequestsXML.xml";

//    XElement orderRoot;
//    string orderPath = @"OrdersXML.xml";

//    XElement configRoot;
//    string configPath = @"ConfigXML.xml";

//    //להוסיף מארח??
//    // XElement hostRoot;
//    // string hostPath = @"HostXML.xml";

//    public DAL_XML()
//    {
//        if (!File.Exists(unitPath))
//            CreateFiles(unitRoot, "units", unitPath);
//        else
//            LoadData(requestRoot, requestPath);

//        if (!File.Exists(requestPath))
//            CreateFiles(requestRoot, "requests", requestPath);
//        else
//            LoadData(requestRoot, requestPath);

//        if (!File.Exists(orderPath))
//            CreateFiles(orderRoot, "orders", orderPath);
//        else
//            LoadData(orderRoot, orderPath);

//        if (!File.Exists(configPath))
//            CreateFiles(configRoot, "config", configPath);
//        else
//            LoadData(configRoot, configPath);

//        //if (!File.Exists(hostPath))
//        //  CreateFiles(hostRoot, "hosts", hostPath);
//        //  else
//        //     LoadData(hostRoot, hostPath);
//    }

//    private void CreateFiles(XElement root, string s, string path)
//    {
//        root = new XElement(s);
//        root.Save(path);
//    }

//    private void LoadData(XElement root, string path)
//    {
//        try
//        {
//            root = XElement.Load(path);
//        }
//        catch
//        {
//            throw new Exception("Problem uploading file");
//        }
//    }

//    #region Units
//    public void SaveUnitList(List<HostingUnit> unitList)
//    {
//        unitRoot = new XElement("units");

//        foreach (HostingUnit item in unitList)
//        {
//            AddUnit(item);
//        }

//        unitRoot.Save(unitPath);
//    }

//    public List<HostingUnit> GetUnitList()
//    {
//        LoadData(unitRoot, unitPath);
//        List<HostingUnit> units;
//        try
//        {
//            units = (from p in unitRoot.Elements()
//                     select new HostingUnit()
//                     {
//                         HostingUnitKey = Convert.ToInt32(p.Element("unitKey").Value),
//                         HostringUnitName = p.Element("unitName").Value,
//                         //     Owner = p.Element("host").Value,Diary=p.Element("diary").Value,SubArea=p.Element("subArea").Value,Area=p.Element("area").Value,Type=p.Element("type").Value,Adults=p.Element("adults").Value,Children=p.Element("children").Value,Pool=p.Elements("pool").Value,Jacuzzi=p.Element("jacuzzi").Value,Garden=p.Element("garden").Value,ChildrensAttractions=p.Element("childrensAttractions").Value,PricePerNight=p.Element("pricePerNight").Value
//                     }).ToList();
//        }
//        catch
//        {
//            units = null;
//        }
//        return units;
//    }

//    public void AddUnit(HostingUnit unit)
//    {
//        XElement host = new XElement("host", unit.Owner);
//        XElement unitName = new XElement("unitName", unit.HostringUnitName);
//        XElement unitKey = new XElement("unitKey", unit.HostingUnitKey);
//        XElement diary = new XElement("diary", unit.Diary);
//        XElement subArea = new XElement("subArea", unit.SubArea);
//        XElement area = new XElement("area", unit.Area);
//        XElement type = new XElement("type", unit.Type);
//        XElement adults = new XElement("adults", unit.Adults);
//        XElement children = new XElement("children", unit.Children);
//        XElement pool = new XElement("pool", unit.Pool);
//        XElement jacuzzi = new XElement("jacuzzi", unit.Jacuzzi);
//        XElement garden = new XElement("garden", unit.Garden);
//        XElement childrensAttractions = new XElement("childrensAttractions", unit.ChildrensAttractions);
//        XElement pricePerNight = new XElement("pricePerNight", unit.PricePerNight);

//        unitRoot.Add(new XElement("unit", unitName, host, unitKey, diary, subArea, area, type, adults, children, pool, jacuzzi, garden, childrensAttractions, pricePerNight));
//        unitRoot.Save(unitPath);
//    }

//    public bool RemoveUnit(long key)
//    {
//        XElement unitElement;
//        try
//        {
//            unitElement = (from p in unitRoot.Elements()
//                           where Convert.ToInt32(p.Element("unitKey").Value) == key
//                           select p).FirstOrDefault();
//            unitElement.Remove();
//            unitRoot.Save(unitPath);
//            return true;
//        }
//        catch
//        {
//            return false;
//        }
//    }

//    public void UpdateUnit(HostingUnit unit)
//    {
//        XElement unitElement = (from p in unitRoot.Elements()
//                                where Convert.ToInt32(p.Element("unitKey").Value) == unit.HostingUnitKey
//                                select p).FirstOrDefault();

//        unitElement.Element("unitName").Value = unit.HostringUnitName;
//        //   unitElement.Element("host").Value = unit.Owner;
//        //  unitElement.Element("diary").Value = unit.Diary;
//        //  unitElement.Element("subArea").Value = unit.SubArea;
//        //  unitElement.Element("area").Value = unit.Area;
//        //  unitElement.Element("type").Value = unit.Type;
//        // unitElement.Element("adults").Value = unit.Adults;
//        // unitElement.Element("children").Value = unit.Children;
//        // unitElement.Element("pool").Value = unit.Pool;
//        // unitElement.Element("jacuzzi").Value = unit.Jacuzzi;
//        // unitElement.Element("garden").Value = unit.Garden;
//        // unitElement.Element("childrensAttractions").Value = unit.ChildrensAttractions;
//        // unitElement.Element("pricePerNight").Value = unit.PricePerNight;
//        //stringלתקן שיעבור ל

//        unitRoot.Save(unitPath);
//    }

//    public HostingUnit GetUnit(long key)
//    {
//        LoadData();
//        HostingUnit unit;
//        try
//        {
//            unit = (from p in unitRoot.Elements()
//                    where Convert.ToInt32(p.Element("unitKey").Value) == key
//                    select new HostingUnit()
//                    {
//                        Host = p.Element("host").Value,
//                        HostingUnitName = p.Element("unitName").Value,
//                        HostingUnitKey = p.Element("unitKey").Value,
//                        Diary = p.Element("diary").Value,
//                        SubArea = p.Element("subArea").Value,
//                        Area = p.Element("area").Value,
//                        Type = p.Element("type").Value,
//                        Adults = p.Element("adults").Value,
//                        Children = p.Element("children").Value,
//                        Pool = p.Element("pool").Value,
//                        Jacuzzi = p.Element("jacuzzi").Value,
//                        Garden = p.Element("garden").Value,
//                        ChildrensAttractions = p.Element("childrensAttractions").Value,
//                        PricePerNight = p.Element("pricePerNight").Value
//                    }).FirstOrDefault();
//        }
//        catch
//        {
//            unit = null;
//        }
//        return unit;
//    }
//    #endregion

//    #region Orders
//    public void SaveOrdertList(List<Order> orderList)
//    {
//        orderRoot = new XElement("orders");

//        foreach (Order item in orderList)
//        {
//            AddOrder(item);
//        }

//        orderRoot.Save(orderPath);
//    }

//    public List<Order> GetOrderList()
//    {
//        LoadData(orderRoot, orderPath);
//        List<Order> orders;
//        try
//        {
//            orders = (from p in orderRoot.Elements()
//                      select new Order()
//                      {
//                          OrderKey = Convert.ToInt32(p.Element("orderKey").Value),
//                          GuestRequestKey = p.Element("requestKey").Value,
//                          HostingUnitKey = Convert.ToInt32(p.Element("unitKey").Value),
//                          Status = p.Element("status").Value,
//                          //     CreateDate=Convert.ToString(p.Element("createDate").Value),
//                          OrderDate = p.Element("orderDate").Value,
//                          EmailSent = p.Element("emailSent").Value,
//                          Fee = Convert.ToInt32(p.Element("fee").Value)
//                      }).ToList();
//        }
//        catch
//        {
//            orders = null;
//        }
//        return orders;
//    }

//    public void AddOrder(Order order)
//    {
//        XElement orderKey = new XElement("orderKey", order.OrderKey);
//        XElement unitKey = new XElement("unitKey", order.HostingUnitKey);
//        XElement requestKey = new XElement("requestKey", order.GuestRequestKey);
//        XElement status = new XElement("status", order.Status);
//        XElement createDate = new XElement("createDate", order.CreateDate);
//        XElement orderDate = new XElement("orderDate", order.OrderDate);
//        XElement email = new XElement("emailSent", order.EmailSent);
//        XElement fee = new XElement("fee", order.Fee);

//        orderRoot.Add(new XElement("order", orderKey, unitKey, requestKey, status, createDate, orderDate, email, fee));
//        orderRoot.Save(orderPath);
//    }

//    public void UpdateOrder(long key, Enums.Status status)
//    {
//        XElement orderElement = (from p in orderRoot.Elements()
//                                 where Convert.ToInt32(p.Element("orderKey").Value) == key
//                                 select p).FirstOrDefault();

//        orderElement.Element("status").Value = status;
//        //stringלתקן שיעבור ל

//        orderRoot.Save(orderPath);
//    }

//    public Order GetOrder(long key)
//    {
//        LoadData(orderRoot, orderPath);
//        Order order;
//        try
//        {
//            order = (from p in orderRoot.Elements()
//                     where Convert.ToInt32(p.Element("orderKey").Value) == key
//                     select new Order()
//                     {
//                         OrderKey = p.Element("orderKey").Value,
//                         HostingUnitKey = p.Element("unitKey").Value,
//                         GuestRequestKey = p.Element("requestKey").Value,
//                         Status = p.Element("status").Value,
//                         CreateDate = p.Element("createDate").Value,
//                         OrderDate = p.Element("orderDate").Value,
//                         EmailSent = p.Element("emailSent").Value,
//                         Fee = p.Element("fee").Value
//                     }).FirstOrDefault();
//        }
//        catch
//        {
//            order = null;
//        }
//        return order;
//    }
//    #endregion

//    #region Requests
//    public void SaveRequestList(List<GuestRequest> requestList)
//    {
//        requestRoot = new XElement("requests");

//        foreach (GuestRequest item in requestList)
//        {
//            AddGuestRequest(item);
//        }

//        requestRoot.Save(requestPath);
//    }

//    public List<GuestRequest> GetRequestList()
//    {
//        LoadData(requestRoot, requestPath);
//        List<GuestRequest> requests;
//        try
//        {
//            requests = (from p in requestRoot.Elements()
//                        select new GuestRequest()
//                        {
//                            GuestRequestKey = Convert.ToInt32(p.Element("requestKey").Value),
//                            PrivateName = p.Element("privateName").Value,
//                            FamilyName = p.Element("familyNAme").Value,
//                            MailAddress = p.Element("mailAddress").Value,
//                            Status = p.Element("status").Value,
//                            RegistrationDate = p.Element("registration").Value,
//                            EntryDate = p.Element("entryDate").Value,
//                            ReleaseDate = p.Element("releaseDate").Value,
//                            SubArea = p.Element("subArea").Value,
//                            Area = p.Element("area").Value,
//                            Type = p.Element("type").Value,
//                            Adults = p.Element("adults").Value,
//                            Children = p.Element("children").Value,
//                            Pool = p.Elements("pool").Value,
//                            Jacuzzi = p.Element("jacuzzi").Value,
//                            Garden = p.Element("garden").Value,
//                            ChildrensAttractions = p.Element("childrensAttractions").Value,
//                            Signed = p.Element("signed").Value
//                        }).ToList();
//        }
//        catch
//        {
//            requests = null;
//        }
//        return requests;
//    }

//    public void AddGuestRequest(GuestRequest request)
//    {
//        XElement requestKey = new XElement("requestKey", request.GuestRequestKey);
//        XElement firstName = new XElement("privateName", request.PrivateName);
//        XElement familyName = new XElement("familyNAme", request.FamilyName);
//        XElement emailAddress = new XElement("mailAddress", request.MailAddress);
//        XElement status = new XElement("status", request.Status);
//        XElement registration = new XElement("registration", request.RegistrationDate);
//        XElement entry = new XElement("entryDate", request.EntryDate);
//        XElement release = new XElement("releaseDate", request.ReleaseDate);
//        XElement subArea = new XElement("subArea", request.SubArea);
//        XElement area = new XElement("area", request.Area);
//        XElement type = new XElement("type", unit.Type);
//        XElement adults = new XElement("adults", request.Adults);
//        XElement children = new XElement("children", request.Children);
//        XElement pool = new XElement("pool", request.Pool);
//        XElement jacuzzi = new XElement("jacuzzi", request.Jacuzzi);
//        XElement garden = new XElement("garden", request.Garden);
//        XElement childrensAttractions = new XElement("childrensAttractions", request.ChildrensAttractions);
//        XElement signed = new XElement("signed", request.Signed);

//        requestRoot.Add(new XElement("request", requestKey, firstName, familyName, emailAddress, status, registration, entry, release, area, subArea, type, adults, children, pool, jacuzzi, garden, childrensAttractions, signed));
//        requestRoot.Save(requestPath);
//    }

//    public GuestRequest GetRequest(long key)
//    {
//        LoadData(requestRoot, requestPath);
//        GuestRequest request;
//        try
//        {
//            request = (from p in requestRoot.Elements()
//                       where Convert.ToInt32(p.Element("requestKey").Value) == key
//                       select new GuestRequest()
//                       {
//                           GuestRequestKey = Convert.ToInt32(p.Element("requestKey").Value),
//                           PrivateName = p.Element("privateName").Value,
//                           FamilyName = p.Element("familyNAme").Value,
//                           MailAddress = p.Element("mailAddress").Value,
//                           Status = p.Element("status").Value,
//                           RegistrationDate = p.Element("registration").Value,
//                           EntryDate = p.Element("entryDate").Value,
//                           ReleaseDate = p.Element("releaseDate").Value,
//                           SubArea = p.Element("subArea").Value,
//                           Area = p.Element("area").Value,
//                           Type = p.Element("type").Value,
//                           Adults = p.Element("adults").Value,
//                           Children = p.Element("children").Value,
//                           Pool = p.Elements("pool").Value,
//                           Jacuzzi = p.Element("jacuzzi").Value,
//                           Garden = p.Element("garden").Value,
//                           ChildrensAttractions = p.Element("childrensAttractions").Value,
//                           Signed = p.Element("signed").Value
//                       }).FirstOrDefault();
//        }
//        catch
//        {
//            request = null;
//        }
//        return request;
//    }
//    #endregion
//