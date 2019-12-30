using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public interface Idal
    {
        #region GuestRequest
        void AddGuestRequest(GuestRequest request);
        void UpdateGuestRequest(ref GuestRequest request, Enums.Status status);
#endregion
        
        #region HostingUnit
void AddHostingUnit(HostingUnit unit);
        void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary);
        void DeleteHostingUnit(HostingUnit unit);
#endregion
        
        #region Order
void AddOrder(Order order);
        void UpdateOrder(ref Order order, Enums.Status status);
#endregion      
  
        #region Lists
List<HostingUnit> GetHostingUnitList();
        List<GuestRequest> GetGuestRequestList();
        List<Order> GetOrderList();
        List<BankBranch> GetBankBranchList();
      #endregion
  
#region AssistingMethods
GuestRequest CheckGuestRequest(long key);
        HostingUnit CheckHostingUnit(long key);
        Order CheckOrder(long key);
        #endregion
    }
}
