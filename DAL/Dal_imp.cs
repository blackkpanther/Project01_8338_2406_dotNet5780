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

        private List<Host> allHosts;
        private List<HostingUnit> allUnits;
        private List<Guest> allGusts;
        private List<Order> allOrders;
        public Dal_imp()
        {
            allHosts = new List<Host>();
            allUnits = new List<HostingUnit>();
            allGusts = new List<Guest>();
            allOrders = new List<Order>();

        }

        #region GuestRequest
        void Idal.AddGuestRequest(GuestRequest request)
        {
            if (CheckGuestRequest(request.GuestRequestKey) != null)
                throw new /*DuplicateRequest*/Exception("Request already submitted");
            DataSource.GuestRequestList.Add(request.Clone());
        }

        void Idal.UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            request.Status = status;
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
            if (CheckHostingUnit(unit.HostingUnitKey) != null)
                throw new /*DuplicateUnit*/Exception("Hosting unit already added");
            DataSource.HostingUnitList.Add(unit.Clone());
        }

        void Idal.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            if (diary.Length != 12 * 31)
                throw new /*WrongDiary*/Exception("Wrong format for diary");
            unit.Diary = diary;
        }
        void Idal.DeleteHostingUnit(HostingUnit unit)
        {
            if (CheckHostingUnit(unit.HostingUnitKey) == null)
                throw new /*NonExistingUnit*/Exception("Hosting unit does not exist");
            DataSource.HostingUnitList.RemoveAll(item => item.HostingUnitKey == unit.HostingUnitKey);
        }
        #endregion

        #region Order
        void Idal.AddOrder(Order order)
        {
            if (CheckOrder(order.OrderKey) != null)
                throw new /*DuplicateOrder*/Exception("Orderalready submitted");
            DataSource.OrderList.Add(order.Clone());
        }

        void Idal.UpdateOrder(ref Order order, Enums.Status status)
        {
            order.Status = status;
        }
        #endregion

        #region Lists
        List<HostingUnit> Idal.GetHostingUnitList()
        {
            return DataSource.HostingUnitList.Select(item => item).ToList();
        }

        List<GuestRequest> Idal.GetGuestRequestList()
        {
            return DataSource.GuestRequestList.Select(item => item).ToList();
        }

        List<Order> Idal.GetOrderList()
        {
            return DataSource.OrderList.Select(item => item).ToList();
        }
        List<BankBranch> Idal.GetBankBranchList()
        {
            return DataSource.BankBranchList.Select(item => item).ToList();
        }
        List<Host> Idal.GetHostList()
        {
            return DataSource.HostList.Select(item => item).ToList();
        }
        #endregion

        #region AssistingMethods
        public GuestRequest CheckGuestRequest(long guestRequestKey)
        {
            return DataSource.GuestRequestList.Find(item => item.GuestRequestKey == guestRequestKey);
        }
        /* GuestRequest Idal.CheckGuestRequest(long key)
         {
             return DataSource.GuestRequestList.Find(item => item.GuestRequestKey == key);
         }*/
        public HostingUnit CheckHostingUnit(long key)
        {
            return DataSource.HostingUnitList.Find(item => item.HostingUnitKey == key);
        }
        public Order CheckOrder(long key)
        {
            return DataSource.OrderList.Find(item => item.OrderKey == key);
        }
        #endregion
    }
}
