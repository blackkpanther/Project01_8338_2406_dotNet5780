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
            IDAL.UpdateGuestRequest(ref request, status);
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
            Order o = IDAL.GetOrderList().Find(item => item.HostingUnitKey == unit.HostingUnitKey);
            if (o != null)
                throw new Exception("Unable to delete hosting unit because of ongoing order");
            IDAL.DeleteHostingUnit(unit);
        }
        void Ibl.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            IDAL.UpdateHostingUnit(ref unit, diary);
        }
        HostingUnit Ibl.CheckHostingUnit(long key)
        {
            return IDAL.CheckHostingUnit(key);
        }
        #endregion

        #region Order
        void Ibl.AddOrder(Order order)
        {
            HostingUnit u = IDAL.CheckHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.CheckGuestRequest(order.GuestRequestKey);
            if (u.Diary[g.EntryDate.Day, g.EntryDate.Month] || u.Diary[g.ReleaseDate.Day, g.ReleaseDate.Month])
                throw new Exception("Hosting unit already booked");
            IDAL.AddOrder(order);
        }
        void Ibl.UpdateOrder(ref Order order, Enums.Status status)
        {
            HostingUnit u = IDAL.CheckHostingUnit(order.HostingUnitKey);
            GuestRequest g = IDAL.CheckGuestRequest(order.GuestRequestKey);
            if (!g.Signed)
                throw new Exception("No standing order confirmation");//אין הרשאת חיוב
            if (order.Status == Enums.Status.Treated)
                throw new Exception("Order already closed");//ההזמנה כבר סגורה
            if (status == Enums.Status.MailSent)
            {
                order.EmailSent = DateTime.Now;
                Console.WriteLine("Email sent");
            }
            if (status == Enums.Status.Treated)
            {
                order.Fee = order.Fee + 10 * (g.ReleaseDate.Day - g.EntryDate.Day);///הוספת עמלה של 10 ש"ח ללילה לתשלום הסופי
                for (int j = g.EntryDate.Month; j <= g.ReleaseDate.Month; j++)
                    for (int i = g.EntryDate.Day; i <= g.ReleaseDate.Day; i++)
                        u.Diary[i, j] = true;
                IDAL.UpdateHostingUnit(ref u, u.Diary);//עדכון היומן
                IDAL.UpdateGuestRequest(ref g, Enums.Status.Treated);///עדכון סטטוס בקשת הלקוח
              //לעדכן גם את כל ההזמנות של הלקוח!!!          
            }
            IDAL.UpdateOrder(ref order, status);
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
            return Ibl.GetUnitsOfType(u => u.Diary[date.Month, date.Day]);
        }
        List<Order> Ibl.NumberOfOrders(int days)
        {
            return Ibl.GetOrdersOfType(order => ((DateTime.Now.Day - order.CreateDate.Day) >= days) || ((DateTime.Now.Day - order.EmailSent.Day) >= days));
        }


        // List<GuestRequest> Ibl.GetRequestsOfType
        public IEnumerable<GuestRequest> GetRequestsOfType(Func<BE.GuestRequest, bool> predicate = null)
        {
            if (predicate == null)
                return IDAL.GetGuestRequestList.AsEnumerable().Select(g => g.Clone());
            return IDAL.GetGuestRequestList.Where(predicate).Select(g => g.Clone());
        }
        List<HostingUnit> Ibl.GetUnitsOfType(Func<BE.HostingUnit, bool> predicate = null)
        {
            if (predicate == null)
                return IDAL.GetHostingUnitList.AsEnumerable().Select(u => u.Clone());
            return IDAL.GetHostingUnitList.Where(predicate).Select(u => u.Clone());
        }
        List<Order> Ibl.GetOrdersOfType(Func<BE.Order, bool> predicate = null)
        {
            if (predicate == null)
                return IDAL.GetOrderList.AsEnumerable().Select(o => o.Clone());
            return IDAL.GetOrderList.Where(predicate).Select(o => o.Clone());
        }
        #endregion

        #region Groups
        IEnumerable<IGrouping<Enums.Area, GuestRequest>> Ibl.GroupRequestsByArea()
        {
            IEnumerable<IGrouping<Enums.Area, GuestRequest>> gByA;
            gByA = from item in IDAL.GetGuestRequestList()
                   group item by item.Area;
            return gByA;
        }
        IEnumerable<IGrouping<int, GuestRequest>> Ibl.GroupRequestsByNumOfGuests()
        {
            IEnumerable<IGrouping<int, GuestRequest>> gByNum;
            gByNum = from item in IDAL.GetGuestRequestList()
                     group item by (item.Adults + item.Children);
            return gByNum;
        }
        IEnumerable<IGrouping<int, Host>> Ibl.GroupHostsByNumOfUnits()
        {
            IEnumerable<IGrouping<int, Host>> gByU;
            gByU = from item in IDAL.GetHostList()
                   group item by item.NumOfUnits;
            return gByU;
        }
        IEnumerable<IGrouping<Enums.Area, HostingUnit>> Ibl.GroupUnitsByArea()
        {
            IEnumerable<IGrouping<Enums.Area, HostingUnit>> gByA;
            gByA = from item in IDAL.GetHostingUnitList()
                   group item by item.Area;
            return gByA;
        }
        #endregion

        #region AssistingMethods
        int Ibl.NumberOfDays(DateTime date1, DateTime date2)
        {
            if (date2 == null)
                return Math.Abs(DateTime.Now.Day - date1.Day);
            return Math.Abs(date1.Day - date2.Day);
        }
        int Ibl.NumberOfInvites(GuestRequest request)
        {
            var count = (GetOrderList().Count(item => item.GuestRequestKey == request.GuestRequestKey));
            return count;
        }
        int Ibl.NumberOfInvites(HostingUnit unit)
        {
            var count = (GetOrderList().Count(item => item.HostingUnitKey == unit.HostingUnitKey && (item.Status == Enums.Status.MailSent || item.Status == Enums.Status.Treated)));
            return count;
        }
        #endregion


       /* public List<GuestRequest> termOfRequest(GuestRequestDelegate requestDelegate)
        {

            return IDAL.GetGuestRequestList().Where(item => (requestDelegate));
        }
        static public bool BPool(GuestRequest guestRequest)
        {
            if (guestRequest.Pool == Enums.Option.Necessary || guestRequest.Pool == Enums.Option.possible)
                return true;
            return false;

        }*/
    }
   // public delegate bool GuestRequestDelegate(GuestRequest guestRequest);

}