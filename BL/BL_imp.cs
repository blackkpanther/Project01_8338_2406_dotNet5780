using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class BL_imp : Ibl
    {
        DAL.Idal IDAL;

        public BL_imp()
        {
            IDAL = DAL.FactoryDAL.GetFactory();
        }

        #region GustRequest
       public void Ibl.AddGuestRequest(GuestRequest request)
        {
            if (request.EntryDate >= request.ReleaseDate)
                throw new Exception("Entry date has to be at least one day before release date");
            IDAL.AddGuestRequest(request);
        }
      public  void Ibl.UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            IDAL.UpdateGuestRequest( request, status);
        }
     public   GuestRequest Ibl.CheckGuestRequest(long key)
        {
            return IDAL.CheckGuestRequest(key);
        }
        #endregion
        
        #region HostingUnit
        public void Ibl.AddHostingUnit(HostingUnit unit)
        {
            IDAL.AddHostingUnit(unit);
        }
        public void Ibl.DeleteHostingUnit(HostingUnit unit)
        {
            Order o=IDAL.GetOrderList().Find(item => item.HostingUnitKey == unit.HostingUnitKey);
            if (0!=null)
               throw new Exception("Unable to delete hosting unit because of ongoing order");
         IDAL.DeleteHostingUnit(unit);
        }
        public void Ibl.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            IDAL.UpdateHostingUnit( unit , diary);
        }
        public HostingUnit Ibl.CheckHostingUnit(long key)
        {
            return IDAL.CheckHostingUnit(key);
        }
        #endregion

        #region Order
        public void Ibl.AddOrder(Order order)
        {
            HostingUnit u = CheckHostingUnit(order.HostingUnitKey);
            GuestRequest g = CheckGuestRequest(order.GuestRequestKey);
            if (u.Diary[g.EntryDate.Day, g.EntryDate.Month] || u.Diary[g.ReleaseDate.Day, g.ReleaseDate.Month])
                throw new Exception("Hosting unit already booked");
            IDAL.AddOrder(order);
        }
        public void Ibl.UpdateOrder(ref Order order, Enums.Status status)
        {
            HostingUnit u = CheckHostingUnit(order.HostingUnitKey);
            GuestRequest g = CheckGuestRequest(order.GuestRequestKey);
            if (!g.Signed)
                throw new Exception("No standing order confirmation");//אין הרשאת חיוב
            if (order.Status == Enums.Status.Treated)
                throw new Exception("Order already closed");//ההזמנה כבר סגורה
            if (status == Enums.Status.MailSent)
            {
                Console.WriteLine("Email sent");
            }
            if (status == Enums.Status.Treated)
            {
                order.Fee=order.Fee+10*(g.ReleaseDate.Day-g.EntryDate.Day);///הוספת עמלה של 10 ש"ח ללילה לתשלום הסופי
                for(int j=g.EntryDate.Month;j<=g.ReleaseDate.Month;j++)                
                     for(int i=g.EntryDate.Day;i<=g.ReleaseDate.Day;i++)
                         u.Diary[i,j]=true;  
                IDAL.UpdateHostingUnit(u,u.Diary);//עדכון היומן
                IDAL.UpdateGuestRequest(g,Enums.Status.treated);///עדכון סטטוס בקשת הלקוח
              //לעדכן גם את כל ההזמנות של הלקוח!!!          
            }
            IDAL.UpdateOrder(order, status);
        }
       public Order Ibl.CheckOrder(long key)
        {
            return IDAL.CheckOrder(key);
        }
        #endregion

        #region Lists
     public   List<BankBranch> Ibl.GetBankBranchList()
        {
           return IDAL.GetBankBranchList();
        }
    public    List<GuestRequest> Ibl.GetGuestRequestList()
        {
            return IDAL.GetGuestRequestList();
        }
      public  List<HostingUnit> Ibl.GetHostingUnitList()
        {
          return IDAL.GetHostingUnitList();
        }
     public   List<Order> Ibl.GetOrderList()
        {
          return IDAL.GetOrderList();
        }
    public    List<HostingUnit> Ibl.AvailableHostingUnits(DateTime date, int n)
        {
         throw new NotImplementedException();
        }
     public   List<Order> Ibl.NumberOfOrders(int days)
        {
            throw new NotImplementedException();
        }
   public    List<GuestRequest> Ibl.GetRequestsOfType(Func<BE.GuestRequest, bool> predicate = null)
          {  
            if(predicate==null)
            return IDAL.GetGuestRequestList.AsEnumerable().Select(t => t.Clone());
            return IDAL.GetGuestRequestList.Where(predicate).Select(g => g.Clone());
        }
        #endregion

        #region Groups
       public IEnumerable<IGrouping<Enums.Area,GuestRequest>> GroupRequestsByArea()
            {
IEnumerable<IGrouping<Enums.Area,GuestRequest>> gByA;
gByA=from item in IDAL.GetGuestRequestList()
     group item by item.Area;
            return gByA;
            }
       public IEnumerable<IGrouping<int,GuestRequest>> GroupRequestsByNumOfGuests()
            {
IEnumerable<IGrouping<int,GuestRequest>> gByNum;
gByNum=from item in IDAL.GetGuestRequestList()
     group item by (item.Adults+item.Children);
            return gByNum;
}
       public IEnumerable<IGrouping<int,Host>> GroupHostsByNumOfUnits()
            {
IEnumerable<IGrouping<int,Host>> gByU;
gByU=from item in IDAL.GetHostList()
     group item by item.NumOfUnits;
            return gByU;
}
       public      IEnumerable<IGrouping<Enums.Area,HostingUnit>> GroupUnitsByArea()
            {
IEnumerable<IGrouping<Enums.Area,HostingUnit>> gByA;
gByA=from item in IDAL.GetHostingUnitList()
     group item by item.Area;
            return gByA;
}
        #endregion

        #region AssistingMethods
        public int NumberOfDays(DateTime date1, DateTime date2=null )
        {
            if (date2==null)
                return Math.Abs( DateTime.Now.Day - date1.Day);
            return Math.Abs(date1.Day - date2.Day);
        }
       public  int Ibl.NumberOfInvites(GuestRequest request)
        {
            var count=(GetOrderList().Count(item=> item.GuestRequestKey==request.GuestRequestKey));
return count;
        }
       public  int Ibl.NumberOfInvites(HostingUnit unit)
        {
            var count=(GetOrderList().Count(item=>item.HostingUnitKey==unit.HostingUnitKey&&(item.Status==Enums.Status.MailSent||item.Status==Enums.Status.Treated)));
            return count;
        }
        #endregion

    }


}