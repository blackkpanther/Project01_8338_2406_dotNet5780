using BE;
using System.Collections.Generic;

namespace DAL
{
    public interface Idal
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
        void UpdateHostingUnit(HostingUnit unit);
        void DeleteHostingUnit(HostingUnit unit);
        HostingUnit CheckHostingUnit(long key);
        #endregion

        #region Order
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        Order CheckOrder(long key);
        #endregion

        #region Lists
        List<HostingUnit> GetHostingUnitList();
        List<GuestRequest> GetGuestRequestList();
        List<Order> GetOrderList();
        List<BankBranch> GetBankBranchList();
      
        #endregion
    }
}
