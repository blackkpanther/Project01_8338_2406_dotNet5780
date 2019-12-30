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
        #endregion
        void AddHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary);
        void DeleteHostingUnit(HostingUnit unit);
        void AddOrder(Order order);
        void UpdateOrder(ref Order order, Enums.Status status);
        List<HostingUnit> GetHostingUnitList();
        List<GuestRequest> GetGuestRequestList();
        List<Order> GetOrderList();
        List<BankBranch> GetBankBranchList();
        GuestRequest CheckGuestRequest(int key);
        HostingUnit CheckHostingUnit(int key);
        Order CheckOrder(int key);
        List<HostingUnit> AvailableHostingUnits(DateTime date, int n);
        int NumberOfDays(DateTime date1, DateTime date2 = 0);
        List<Order> NumberOfOrders(int days);
        List<GuestRequest> Requests();
        int NumberOfInvites(GuestRequest request);
        int NumberOfInvites(HostingUnit unit);


    }
}