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
        void Ibl.AddGuestRequest(GuestRequest request)
        {
            if (request.EntryDate >= request.ReleaseDate)
                throw new Exception("Entry date has to be at least one day before release date");
            IDAL.AddGuestRequest(request);
        }
        void Ibl.UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            IDAL.UpdateGuestRequest( request, status);
        }
        GuestRequest Ibl.CheckGuestRequest(long key)
        {
            return IDAL.CheckGuestRequest(key);
        }
        #endregion
        
        #region HostingUnit
        void Ibl.AddHostingUnit(HostingUnit unit)
        {
            IDAL.AddHostingUnit(unit);
        }
        void Ibl.DeleteHostingUnit(HostingUnit unit)
        {
            //if (קיימת הזמנה פתוחה)
               throw new Exception("Unable to delete hosting unit");
          //  IDAL.DeleteHostingUnit(unit);
        }
        void Ibl.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            IDAL.UpdateHostingUnit( unit , diary);
        }
        HostingUnit Ibl.CheckHostingUnit(long key)
        {
            return IDAL.CheckHostingUnit(key);
        }
        #endregion

        #region Order
        void Ibl.AddOrder(Order order)
        {
            HostingUnit u = CheckHostingUnit(order.HostingUnitKey);
            GuestRequest g = CheckGuestRequest(order.GuestRequestKey);
            if (u.Diary[g.EntryDate.Day, g.EntryDate.Month] || u.Diary[g.ReleaseDate.Day, g.ReleaseDate.Month])
                throw new Exception("Hosting unit already booked");
            IDAL.AddOrder(order);
        }
        void Ibl.UpdateOrder(ref Order order, Enums.Status status)
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
        Order Ibl.CheckOrder(long key)
        {
            return IDAL.CheckOrder(key);
        }
        #endregion

        #region Lists
        List<BankBranch> Ibl.GetBankBranchList()
        {
           return IDAL.GetBankBranchList();
        }
        List<GuestRequest> Ibl.GetGuestRequestList()
        {
            return IDAL.GetGuestRequestList();
        }
        List<HostingUnit> Ibl.GetHostingUnitList()
        {
          return IDAL.GetHostingUnitList();
        }
        List<Order> Ibl.GetOrderList()
        {
          return IDAL.GetOrderList();
        }
        List<HostingUnit> Ibl.AvailableHostingUnits(DateTime date, int n)
        {
         throw new NotImplementedException();
        }
        List<Order> Ibl.NumberOfOrders(int days)
        {
            throw new NotImplementedException();
        }
        List<GuestRequest> Ibl.GetRequests(Func<GuestRequest,bool> func)
        {
            return IDAL.GetGuestRequestList(p);
        }
        #endregion

        #region AssistingMethods
        public int NumberOfDays(DateTime date1, DateTime date2=null )
        {
            if (date2==null)
                return Math.Abs( DateTime.Now.Day - date1.Day);
            return Math.Abs(date1.Day - date2.Day);
        }
        int Ibl.NumberOfInvites(GuestRequest request)
        {
            var count=(GetOrderList().Count(item=> item.GuestRequestKey==request.GuestRequestKey));
return count;
        }
        int Ibl.NumberOfInvites(HostingUnit unit)
        {
            var count=(GetOrderList().Count(item=>item.HostingUnitKey==unit.HostingUnitKey&&(item.Status==Enums.Status.MailSent||item.Status==Enums.Status.Treated)));
            return count;
        }
        #endregion

    }


}