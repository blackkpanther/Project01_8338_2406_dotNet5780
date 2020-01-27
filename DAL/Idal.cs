using BE;
using System.Collections.Generic;

namespace DAL
{
    public interface Idal
    {
        #region Guest
        void AddGuest(Guest guest);
        void UpdateGuest(Guest guest);
        void DeleteGuest(Guest guest);
        List<Guest> GetGuests() ;
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

        #region bank

        List<BankBranch> GetBankBranchList();
      
        #endregion
    }
}
