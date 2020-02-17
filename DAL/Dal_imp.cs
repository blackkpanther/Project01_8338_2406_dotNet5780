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
            try
            {
                DataSource.GuestList.Add(guest);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal add guest- key num:{0} ", guest.GuestKey));
            }
        }
        void Idal.UpdateGuest(Guest guest)
        {
            try
            {
                var oldGuest = (from item in DataSource.GuestList where item.GuestKey == guest.GuestKey select item).FirstOrDefault();
                int tempIndex = DataSource.GuestList.IndexOf(oldGuest);
                DataSource.GuestList.Remove(oldGuest);
                DataSource.GuestList.Insert(tempIndex, guest);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal update guest- key num:{0} ", guest.GuestKey));
            }
        }
        void Idal.DeleteGuest(Guest guest)
        {
            try
            {
                DataSource.GuestList.Remove(guest);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal delete guest- key num:{0} ", guest.GuestKey));
            }
        }
        List<Guest> Idal.GetGuests()
        {
            try
            {
                return DataSource.GuestList;
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get Guest list "));
            }
           
        }
        Guest Idal.GetGuest(long guestKey)
        {
            try
            {
                return (from item in DataSource.GuestList where item.GuestKey == guestKey select item).FirstOrDefault();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get Guest list "));
            }
        }
        #endregion
        //ללא תיקון
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
            try
            {
                var oldHost = (from item in DataSource.HostList where item.HostKey ==host.HostKey select item).FirstOrDefault();
                int tempIndex = DataSource.HostList.IndexOf(oldHost);
                DataSource.HostList.Remove(oldHost);
                DataSource.HostList.Insert(tempIndex, host);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal update host- key num:{0} ", host.HostKey));
            }

        }
        void Idal.AddHost(Host host)
        {
            try
            {
                DataSource.HostList.Add(host);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal add host- key num:{0} ", host.HostKey));
            }
          

        }
        void Idal.DeleteHost(Host host)
        {
            try
            {
                DataSource.HostList.Remove(host);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal delete guest- key num:{0} ", host.HostKey));
            }
        }
        List<Host> Idal.GetHosts()
        {
            try
            {
                return DataSource.HostList;
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get host list "));

            }
        }
        Host Idal.GetHost(long hostKey)
        {
            try
            {
                return (from item in DataSource.HostList where item.HostKey == hostKey select item).FirstOrDefault();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get Guest list "));
            }

        }

        #endregion
        #region HostingUnit
        void Idal.AddHostingUnit(HostingUnit unit)
        {
            try
            {
                DataSource.HostingUnitList.Add(unit);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal add unit- key num:{0} ", unit.HostingUnitKey));
            }
        }

        void Idal.UpdateHostingUnit(HostingUnit unit)
        {
            try
            {
                var oldUnit = (from item in DataSource.HostingUnitList where item.HostingUnitKey == unit.HostingUnitKey select item).FirstOrDefault();
                int tempIndex = DataSource.HostingUnitList.IndexOf(oldUnit);
                DataSource.HostingUnitList.Remove(oldUnit);
                DataSource.HostingUnitList.Insert(tempIndex, unit);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal update unit- key num:{0} ", unit.HostingUnitKey));
            }
        }
        void Idal.DeleteHostingUnit(HostingUnit unit)
        {
            try
            {
                DataSource.HostingUnitList.Remove(unit);
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong \n dal delete unit- key num:{0} ", unit.HostingUnitKey));
            }
        }
            List<HostingUnit> Idal.GetHostingUnits()
        {
            try
            {
                return DataSource.HostingUnitList;
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get unit list "));
            }
        }
        HostingUnit Idal.GetHostingUnit(long hostingUnitKey)
        {
            try
            {
                return (from item in DataSource.HostingUnitList where item.HostingUnitKey == hostingUnitKey select item).FirstOrDefault();
            }
            catch
            {
                throw new Exception(String.Format("ERROR: Something went wrong: \n dal get Guest "));
            }
        }
        #endregion

        #region Order
        void Idal.AddOrder(Order order)
        {
            DataSource.OrderList.Add(order);
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
        {try
            {
                return (from item in DataSource.OrderList where item.OrderKey == orderKey select item).FirstOrDefault();
            }
            catch
            {
                throw new Exception("The order you try to find doesn't exsit/n");
            }
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


