using BE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public interface Ibl
    {
        #region Guest
        void AddGuest(Guest guest);
        void UpdateGuest(Guest guest);
        void DeleteGuest(Guest guest);
        List<Guest> GetGuests();
        Guest GetGuest(long guestKey);
        #endregion

        #region GuestRequest
        void AddGuestRequest(GuestRequest request);
        void UpdateGuestRequest(GuestRequest request);
        List<GuestRequest> GetGuestRequestList();
        GuestRequest GetGuestRequest(long gustReqKey);
        #endregion

        #region Host
        void DeleteHost(Host host);
        void UpdateHost(Host host);
        void AddHost(Host host);
        List<Host> GetHosts();
        Host GetHost(long hostKey);
        #endregion

        #region HostingUnit
        void AddHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(HostingUnit unit);
        void DeleteHostingUnit(HostingUnit unit);
        List<HostingUnit> GetHostingUnits();
        HostingUnit GetHostingUnit(long hostingUnitKey);
        #endregion

        #region Order
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        List<Order> GetOrderList();
        Order GetOrder(long horderKey);
        #endregion

        #region Lists
        List<BankBranch> GetBankBranchList();
        List<HostingUnit> AvailableHostingUnits(DateTime date, int n);
        List<Order> NumberOfOrders(int days);
        //List<GuestRequest> termOfRequest(GuestRequestDelegate requestDelegate);
        IEnumerable<GuestRequest> GetRequestsOfType(Func<BE.GuestRequest, bool> predicate = null);
        IEnumerable<HostingUnit> GetUnitsOfType(Func<BE.HostingUnit, bool> predicate = null);
        IEnumerable<Order> GetOrdersOfType(Func<BE.Order, bool> predicate = null);
        #endregion

        #region Groups
        IEnumerable<IGrouping<Enums.Area, GuestRequest>> GroupRequestsByArea();
        IEnumerable<IGrouping<int, GuestRequest>> GroupRequestsByNumOfGuests();
        IEnumerable<IGrouping<int, Host>> GroupHostsByNumOfUnits();
        IEnumerable<IGrouping<Enums.Area, HostingUnit>> GroupUnitsByArea();
        IEnumerable<IGrouping<Host, HostingUnit>> GroupUnitsByHost();
        IEnumerable<IGrouping<Enums.Option, GuestRequest>> GroupRequestByPool();
        IEnumerable<IGrouping<DateTime, Order>> GroupOrdersByCreationDate();
        IEnumerable<IGrouping<Guest, GuestRequest>> GroupRequestsByGuest();
        IEnumerable<IGrouping<Enums.Status, Order>> GroupOrdersByStatus();
        IEnumerable<IGrouping<Enums.Type, HostingUnit>> GroupUnitsByType();
        #endregion

        #region AssistingMethods
        int NumberOfDays(DateTime date1, DateTime date2);
        int NumberOfInvites(GuestRequest request);
        int NumberOfInvites(HostingUnit unit);
       
        #endregion

    }
}

