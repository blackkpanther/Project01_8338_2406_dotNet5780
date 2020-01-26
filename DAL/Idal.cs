using BE;
using System.Collections.Generic;

namespace DAL
{
    public interface Idal
    {
        #region GuestRequest
        void AddGuestRequest(GuestRequest request);
        void UpdateGuestRequest(ref GuestRequest request, Enums.Status status);
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
        void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary);
        void DeleteHostingUnit(HostingUnit unit);
        HostingUnit CheckHostingUnit(long key);
        #endregion

        #region Order
        void AddOrder(Order order);
        void UpdateOrder(ref Order order, Enums.Status status);
        Order CheckOrder(long key);
        #endregion

        #region Lists
        List<HostingUnit> GetHostingUnitList();
        List<GuestRequest> GetGuestRequestList();
        List<Order> GetOrderList();
        List<BankBranch> GetBankBranchList();
        List<Host> GetHostList();
        #endregion
    }
}
