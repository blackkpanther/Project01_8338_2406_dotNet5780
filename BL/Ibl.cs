using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface Ibl
    {
        #region GuestRequest
        void AddGuestRequest(GuestRequest request);
        void UpdateGuestRequest(ref GuestRequest request, Enums.Status status);
        GuestRequest CheckGuestRequest(long key);
       
        #endregion

        #region HostingUnit
        void AddHostingUnit(HostingUnit unit);
        void DeleteHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary);
        HostingUnit CheckHostingUnit(long key);
        #endregion

        #region Order
        void AddOrder(Order order);
        void UpdateOrder(ref Order order, Enums.Status status);
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
     List<GuestRequest> GetRequestsOfType(Func<BE.GuestRequest, bool> predicate = null );
        List<HostingUnit> GetUnitsOfType(Func<BE.HostingUnit, bool> predicate = null);
       List<Order> GetOrdersOfType(Func<BE.Order, bool> predicate = null);
        #endregion

        #region Groups
        IEnumerable<IGrouping<Enums.Area,GuestRequest>> GroupRequestsByArea();
        IEnumerable<IGrouping<int,GuestRequest>> GroupRequestsByNumOfGuests();
        IEnumerable<IGrouping<int,Host>> GroupHostsByNumOfUnits();
        IEnumerable<IGrouping<Enums.Area,HostingUnit>> GroupUnitsByArea();
        #endregion

        #region AssistingMethods
        int NumberOfDays(DateTime date1, DateTime date2);
        int NumberOfInvites(GuestRequest request);
        int NumberOfInvites(HostingUnit unit);
        #endregion

    }
}

