using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DAL
{
    class DAL_XML
    {
        //Roots and paths of the files
        XElement unitRoot;
        string unitPath = @"UnitsXML.xml";

        XElement requestRoot;
        string requestPath = @"RequestsXML.xml";

        XElement orderRoot;
        string orderPath = @"OrdersXML.xml";

        XElement configRoot;
        string configPath = @"ConfigXML.xml";

        //להוסיף מארח??
        // XElement hostRoot;
        // string hostPath = @"HostXML.xml";

        public DAL_XML()
        {
            if (!File.Exists(unitPath))
                CreateFiles(unitRoot, "units", unitPath);
            else
                LoadData(requestRoot, requestPath);

            if (!File.Exists(requestPath))
                CreateFiles(requestRoot, "requests", requestPath);
            else
                LoadData(requestRoot, requestPath);

            if (!File.Exists(orderPath))
                CreateFiles(orderRoot, "orders", orderPath);
            else
                LoadData(orderRoot, orderPath);

            if (!File.Exists(configPath))
                CreateFiles(configRoot, "config", configPath);
            else
                LoadData(configRoot, configPath);

            //if (!File.Exists(hostPath))
            //  CreateFiles(hostRoot, "hosts", hostPath);
            //  else
            //     LoadData(hostRoot, hostPath);
        }

        private void CreateFiles(XElement root, string s, string path)
        {
            root = new XElement(s);
            root.Save(path);
        }

        private void LoadData(XElement root, string path)
        {
            try
            {
                root = XElement.Load(path);
            }
            catch
            {
                throw new Exception("Problem uploading file");
            }
        }

        #region Units
        public void SaveUnitList(List<HostingUnit> unitList)
        {
            unitRoot = new XElement("units");

            foreach (HostingUnit item in unitList)
            {
                AddUnit(item);
            }

            unitRoot.Save(unitPath);
        }

        public List<HostingUnit> GetUnitList()
        {
            LoadData(unitRoot, unitPath);
            List<HostingUnit> units;
            try
            {
                units = (from p in unitRoot.Elements()
                         select new HostingUnit()
                         {
                             HostingUnitKey = Convert.ToInt32(p.Element("unitKey").Value),
                             HostringUnitName = p.Element("unitName").Value,
                             //     Owner = p.Element("host").Value,Diary=p.Element("diary").Value,SubArea=p.Element("subArea").Value,Area=p.Element("area").Value,Type=p.Element("type").Value,Adults=p.Element("adults").Value,Children=p.Element("children").Value,Pool=p.Elements("pool").Value,Jacuzzi=p.Element("jacuzzi").Value,Garden=p.Element("garden").Value,ChildrensAttractions=p.Element("childrensAttractions").Value,PricePerNight=p.Element("pricePerNight").Value
                         }).ToList();
            }
            catch
            {
                units = null;
            }
            return units;
        }

        public void AddUnit(HostingUnit unit)
        {
            XElement host = new XElement("host", unit.Owner);
            XElement unitName = new XElement("unitName", unit.HostringUnitName);
            XElement unitKey = new XElement("unitKey", unit.HostingUnitKey);
            XElement diary = new XElement("diary", unit.Diary);
            XElement subArea = new XElement("subArea", unit.SubArea);
            XElement area = new XElement("area", unit.Area);
            XElement type = new XElement("type", unit.Type);
            XElement adults = new XElement("adults", unit.Adults);
            XElement children = new XElement("children", unit.Children);
            XElement pool = new XElement("pool", unit.Pool);
            XElement jacuzzi = new XElement("jacuzzi", unit.Jacuzzi);
            XElement garden = new XElement("garden", unit.Garden);
            XElement childrensAttractions = new XElement("childrensAttractions", unit.ChildrensAttractions);
            XElement pricePerNight = new XElement("pricePerNight", unit.PricePerNight);

            unitRoot.Add(new XElement("unit", unitName, host, unitKey, diary, subArea, area, type, adults, children, pool, jacuzzi, garden, childrensAttractions, pricePerNight));
            unitRoot.Save(unitPath);
        }

        public bool RemoveUnit(long key)
        {
            XElement unitElement;
            try
            {
                unitElement = (from p in unitRoot.Elements()
                               where Convert.ToInt32(p.Element("unitKey").Value) == key
                               select p).FirstOrDefault();
                unitElement.Remove();
                unitRoot.Save(unitPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void UpdateUnit(HostingUnit unit)
        {
            XElement unitElement = (from p in unitRoot.Elements()
                                    where Convert.ToInt32(p.Element("unitKey").Value) == unit.HostingUnitKey
                                    select p).FirstOrDefault();

            unitElement.Element("unitName").Value = unit.HostringUnitName;
            //   unitElement.Element("host").Value = unit.Owner;
            //  unitElement.Element("diary").Value = unit.Diary;
            //  unitElement.Element("subArea").Value = unit.SubArea;
            //  unitElement.Element("area").Value = unit.Area;
            //  unitElement.Element("type").Value = unit.Type;
            // unitElement.Element("adults").Value = unit.Adults;
            // unitElement.Element("children").Value = unit.Children;
            // unitElement.Element("pool").Value = unit.Pool;
            // unitElement.Element("jacuzzi").Value = unit.Jacuzzi;
            // unitElement.Element("garden").Value = unit.Garden;
            // unitElement.Element("childrensAttractions").Value = unit.ChildrensAttractions;
            // unitElement.Element("pricePerNight").Value = unit.PricePerNight;
            //stringלתקן שיעבור ל

            unitRoot.Save(unitPath);
        }

        public HostingUnit GetUnit(long key)
        {
            LoadData();
            HostingUnit unit;
            try
            {
                unit = (from p in unitRoot.Elements()
                        where Convert.ToInt32(p.Element("unitKey").Value) == key
                        select new HostingUnit()
                        {
                            Host = p.Element("host").Value,
                            HostingUnitName = p.Element("unitName").Value,
                            HostingUnitKey = p.Element("unitKey").Value,
                            Diary = p.Element("diary").Value,
                            SubArea = p.Element("subArea").Value,
                            Area = p.Element("area").Value,
                            Type = p.Element("type").Value,
                            Adults = p.Element("adults").Value,
                            Children = p.Element("children").Value,
                            Pool = p.Element("pool").Value,
                            Jacuzzi = p.Element("jacuzzi").Value,
                            Garden = p.Element("garden").Value,
                            ChildrensAttractions = p.Element("childrensAttractions").Value,
                            PricePerNight = p.Element("pricePerNight").Value
                        }).FirstOrDefault();
            }
            catch
            {
                unit = null;
            }
            return unit;
        }
        #endregion

        #region Orders
        public void SaveOrdertList(List<Order> orderList)
        {
            orderRoot = new XElement("orders");

            foreach (Order item in orderList)
            {
                AddOrder(item);
            }

            orderRoot.Save(orderPath);
        }

        public List<Order> GetOrderList()
        {
            LoadData(orderRoot, orderPath);
            List<Order> orders;
            try
            {
                orders = (from p in orderRoot.Elements()
                          select new Order()
                          {
                              OrderKey = Convert.ToInt32(p.Element("orderKey").Value),
                              GuestRequestKey = p.Element("requestKey").Value,
                              HostingUnitKey = Convert.ToInt32(p.Element("unitKey").Value),
                              Status = p.Element("status").Value,
                              //     CreateDate=Convert.ToString(p.Element("createDate").Value),
                              OrderDate = p.Element("orderDate").Value,
                              EmailSent = p.Element("emailSent").Value,
                              Fee = Convert.ToInt32(p.Element("fee").Value)
                          }).ToList();
            }
            catch
            {
                orders = null;
            }
            return orders;
        }

        public void AddOrder(Order order)
        {
            XElement orderKey = new XElement("orderKey", order.OrderKey);
            XElement unitKey = new XElement("unitKey", order.HostingUnitKey);
            XElement requestKey = new XElement("requestKey", order.GuestRequestKey);
            XElement status = new XElement("status", order.Status);
            XElement createDate = new XElement("createDate", order.CreateDate);
            XElement orderDate = new XElement("orderDate", order.OrderDate);
            XElement email = new XElement("emailSent", order.EmailSent);
            XElement fee = new XElement("fee", order.Fee);

            orderRoot.Add(new XElement("order", orderKey, unitKey, requestKey, status, createDate, orderDate, email, fee));
            orderRoot.Save(orderPath);
        }

        public void UpdateOrder(long key, Enums.Status status)
        {
            XElement orderElement = (from p in orderRoot.Elements()
                                     where Convert.ToInt32(p.Element("orderKey").Value) == key
                                     select p).FirstOrDefault();

            orderElement.Element("status").Value = status;
            //stringלתקן שיעבור ל

            orderRoot.Save(orderPath);
        }

        public Order GetOrder(long key)
        {
            LoadData(orderRoot, orderPath);
            Order order;
            try
            {
                order = (from p in orderRoot.Elements()
                         where Convert.ToInt32(p.Element("orderKey").Value) == key
                         select new Order()
                         {
                             OrderKey = p.Element("orderKey").Value,
                             HostingUnitKey = p.Element("unitKey").Value,
                             GuestRequestKey = p.Element("requestKey").Value,
                             Status = p.Element("status").Value,
                             CreateDate = p.Element("createDate").Value,
                             OrderDate = p.Element("orderDate").Value,
                             EmailSent = p.Element("emailSent").Value,
                             Fee = p.Element("fee").Value
                         }).FirstOrDefault();
            }
            catch
            {
                order = null;
            }
            return order;
        }
        #endregion

        #region Requests
        public void SaveRequestList(List<GuestRequest> requestList)
        {
            requestRoot = new XElement("requests");

            foreach (GuestRequest item in requestList)
            {
                AddGuestRequest(item);
            }

            requestRoot.Save(requestPath);
        }

        public List<GuestRequest> GetRequestList()
        {
            LoadData(requestRoot, requestPath);
            List<GuestRequest> requests;
            try
            {
                requests = (from p in requestRoot.Elements()
                            select new GuestRequest()
                            {
                                GuestRequestKey = Convert.ToInt32(p.Element("requestKey").Value),
                                PrivateName = p.Element("privateName").Value,
                                FamilyName = p.Element("familyNAme").Value,
                                MailAddress = p.Element("mailAddress").Value,
                                Status = p.Element("status").Value,
                                RegistrationDate = p.Element("registration").Value,
                                EntryDate = p.Element("entryDate").Value,
                                ReleaseDate = p.Element("releaseDate").Value,
                                SubArea = p.Element("subArea").Value,
                                Area = p.Element("area").Value,
                                Type = p.Element("type").Value,
                                Adults = p.Element("adults").Value,
                                Children = p.Element("children").Value,
                                Pool = p.Elements("pool").Value,
                                Jacuzzi = p.Element("jacuzzi").Value,
                                Garden = p.Element("garden").Value,
                                ChildrensAttractions = p.Element("childrensAttractions").Value,
                                Signed = p.Element("signed").Value
                            }).ToList();
            }
            catch
            {
                requests = null;
            }
            return requests;
        }

        public void AddGuestRequest(GuestRequest request)
        {
            XElement requestKey = new XElement("requestKey", request.GuestRequestKey);
            XElement firstName = new XElement("privateName", request.PrivateName);
            XElement familyName = new XElement("familyNAme", request.FamilyName);
            XElement emailAddress = new XElement("mailAddress", request.MailAddress);
            XElement status = new XElement("status", request.Status);
            XElement registration = new XElement("registration", request.RegistrationDate);
            XElement entry = new XElement("entryDate", request.EntryDate);
            XElement release = new XElement("releaseDate", request.ReleaseDate);
            XElement subArea = new XElement("subArea", request.SubArea);
            XElement area = new XElement("area", request.Area);
            XElement type = new XElement("type", unit.Type);
            XElement adults = new XElement("adults", request.Adults);
            XElement children = new XElement("children", request.Children);
            XElement pool = new XElement("pool", request.Pool);
            XElement jacuzzi = new XElement("jacuzzi", request.Jacuzzi);
            XElement garden = new XElement("garden", request.Garden);
            XElement childrensAttractions = new XElement("childrensAttractions", request.ChildrensAttractions);
            XElement signed = new XElement("signed", request.Signed);

            requestRoot.Add(new XElement("request", requestKey, firstName, familyName, emailAddress, status, registration, entry, release, area, subArea, type, adults, children, pool, jacuzzi, garden, childrensAttractions, signed));
            requestRoot.Save(requestPath);
        }

        public GuestRequest GetRequest(long key)
        {
            LoadData(requestRoot, requestPath);
            GuestRequest request;
            try
            {
                request = (from p in requestRoot.Elements()
                           where Convert.ToInt32(p.Element("requestKey").Value) == key
                           select new GuestRequest()
                           {
                               GuestRequestKey = Convert.ToInt32(p.Element("requestKey").Value),
                               PrivateName = p.Element("privateName").Value,
                               FamilyName = p.Element("familyNAme").Value,
                               MailAddress = p.Element("mailAddress").Value,
                               Status = p.Element("status").Value,
                               RegistrationDate = p.Element("registration").Value,
                               EntryDate = p.Element("entryDate").Value,
                               ReleaseDate = p.Element("releaseDate").Value,
                               SubArea = p.Element("subArea").Value,
                               Area = p.Element("area").Value,
                               Type = p.Element("type").Value,
                               Adults = p.Element("adults").Value,
                               Children = p.Element("children").Value,
                               Pool = p.Elements("pool").Value,
                               Jacuzzi = p.Element("jacuzzi").Value,
                               Garden = p.Element("garden").Value,
                               ChildrensAttractions = p.Element("childrensAttractions").Value,
                               Signed = p.Element("signed").Value
                           }).FirstOrDefault();
            }
            catch
            {
                request = null;
            }
            return request;
        }
        #endregion
    }
}
