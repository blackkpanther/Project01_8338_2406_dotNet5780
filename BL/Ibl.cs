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
 
        void AddHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary);
        void DeleteHostingUnit(HostingUnit unit);
        void AddOrder(Order order);
        void UpdateOrder(ref Order order, Enums.Status status);
        List<HostingUnit> GetHostingUnitList();
        List<GuestRequest> GetGuestRequestList();
        List<Order> GetOrderList();
        List<BankBranch> GetBankBranchList();
         List<HostingUnit> AvailableHostingUnits(DateTime date, int n);
  List<Order> NumberOfOrders(int days);
        List<GuestRequest> Requests();      
 GuestRequest CheckGuestRequest(long key);
        HostingUnit CheckHostingUnit(long key);
        Order CheckOrder(long key);
        int NumberOfDays(DateTime date1, DateTime date2 = 0);
        int NumberOfInvites(GuestRequest request);
        int NumberOfInvites(HostingUnit unit);


    }
}