using BE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public interface Ibl
    {
        #region GuestRequest
        void AddGuestRequest(GuestRequest request);
        void UpdateGuestRequest(GuestRequest request);
        GuestRequest CheckGuestRequest(long key);

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
        void DeleteHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(HostingUnit unit);
        HostingUnit CheckHostingUnit(long key);
        #endregion

        #region Order
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order CheckOrder(long key);
        #endregion

        #region Lists
        List<BankBranch> GetBankBranchList();
        List<GuestRequest> GetGuestRequestList();
        List<HostingUnit> GetHostingUnitList();
        List<Order> GetOrderList();
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
        #endregion

        #region AssistingMethods
        int NumberOfDays(DateTime date1, DateTime date2);
        int NumberOfInvites(GuestRequest request);
        int NumberOfInvites(HostingUnit unit);
        #endregion

    }
}

