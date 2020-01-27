using BE;
using DS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Dal_imp : Idal
    {
        //Singleton
        private List<Guest> allGuest;
        private List<Host> allHosts;
        private List<HostingUnit> allUnits;
        private List<Guest> allGusts;
        private List<Order> allOrders;
        public Dal_imp()
        {
            allGuest = new List<Guest>();
            allHosts = new List<Host>();
            allUnits = new List<HostingUnit>();
            allGusts = new List<Guest>();
            allOrders = new List<Order>();

        }

        #region Guest
        void Idal.AddGuest(Guest guest)
        {
            DataSource.GuestList.Add(guest);
        }
        void Idal.UpdateGuest(Guest guest)
        {
            DataSource.GuestList.Remove(guest);
            DataSource.GuestList.Add(guest);
        }
        void Idal.DeleteGuest(Guest guest)
        {
            DataSource.GuestList.Remove(guest);
        }
        List<Guest> Idal.GetGuests()
        {
            return DataSource.GuestList;
        }
        Guest Idal.GetGuest(long guestKey)
        {
            var temp = (from item in DataSource.GuestList where item.GuestKey == guestKey select item).FirstOrDefault();
            if (temp != null)
                return temp;
            else
                throw new Exception("The guest you try to find doesn't exsit/n");
        }
        #endregion
        #region GuestRequest
        void Idal.AddGuestRequest(GuestRequest request)
        {
             DataSource.GuestRequestList.Add(request.Clone());
        }

        void Idal.UpdateGuestRequest(GuestRequest request)
        {
            DataSource.GuestRequestList.Remove(request);
            DataSource.GuestRequestList.Add(request);
        }
        List<GuestRequest> Idal.GetGuestRequestList()
        {
            return DataSource.GuestRequestList;
        }
        GuestRequest Idal.GetGuestRequest(long gustReqKey)
        {
            var temp = (from item in DataSource.GuestRequestList where item.GuestRequestKey == gustReqKey select item).FirstOrDefault();
            if (temp != null)
                return temp;
            else
                throw new Exception("The guestReq you try to find doesn't exsit/n");
        }
        #endregion


        #region Host
        void Idal.UpdateHost(Host host)
        {
            DataSource.HostList.Remove((from item in DataSource.HostList where item.HostKey == host.HostKey select item).FirstOrDefault());
            DataSource.HostList.Add(host);
        }
        void Idal.AddHost(Host host)
        {
            DataSource.HostList.Add(host);

        }
        void Idal.DeleteHost(Host host)
        {
            DataSource.HostList.Remove(host);

        }
        List<Host> Idal.GetHosts()
        {
            return DataSource.HostList;
        }
        Host Idal.GetHost(long hostKey)
        {

            var temp = (from item in DataSource.HostList where item.HostKey == hostKey select item).FirstOrDefault();
            if (temp != null)
                return temp;
            else
                throw new Exception("The host you try to find doesn't exsit/n");
        }

        #endregion
        #region HostingUnit
        void Idal.AddHostingUnit(HostingUnit unit)
        {
            DataSource.HostingUnitList.Add(unit.Clone());
        }

        void Idal.UpdateHostingUnit(HostingUnit unit)
        {
            DataSource.HostingUnitList.Remove((from item in DataSource.HostingUnitList where item.HostingUnitKey == unit.HostingUnitKey select item).FirstOrDefault());
            DataSource.HostingUnitList.Add(unit);
        }
        void Idal.DeleteHostingUnit(HostingUnit unit)
        {
            DataSource.HostingUnitList.Remove(unit);
        }
        List<HostingUnit> Idal.GetHostingUnits()
        {
            return DataSource.HostingUnitList;
        }
        HostingUnit Idal.GetHostingUnit(long hostingUnitKey)
        {
            var temp = (from item in DataSource.HostingUnitList where item.HostingUnitKey == hostingUnitKey select item).FirstOrDefault();
            if (temp != null)
                return temp;
            else
                throw new Exception("The unit you try to find doesn't exsit/n");
        }
        #endregion

        #region Order
        void Idal.AddOrder(Order order)
        {
                DataSource.OrderList.Add(order.Clone());
        }

        void Idal.UpdateOrder(Order order)
        {
            DataSource.OrderList.Remove(order);
            DataSource.OrderList.Add(order);
        }

        void Idal.DeleteOrder(Order order)
        {
            DataSource.OrderList.Remove(order);
        }

        List<Order> Idal.GetOrderList()
        {
            return DataSource.OrderList;
        }
         Order Idal.GetOrder(long orderKey)
        {
            var temp = (from item in DataSource.OrderList where item.OrderKey == orderKey select item).FirstOrDefault();
            if (temp != null)
                return temp;
            else
                throw new Exception("The order you try to find doesn't exsit/n");
        }
        #endregion

        #region bank


        List<BankBranch> Idal.GetBankBranchList()
        {
            return DataSource.BankBranchList.Select(item => item).ToList();
        }

        #endregion

        
    }
}
