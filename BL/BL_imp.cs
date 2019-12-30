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

        public void Ibl.AddGuestRequest(GuestRequest request)
        {
            if (request.EntryDate >= request.ReleaseDate)
                throw new Exception("Entry date has to be at least one day before release date");
            IDAL.AddGuestRequest(request);
        }

        public void Ibl.AddHostingUnit(HostingUnit unit)
        {
            IDAL.AddHostingUnit(unit);
        }

        public void Ibl.AddOrder(Order order)
        {
            if ()
                throw new Exception("hosting unit already booked");
            IDAL.AddOrder(order);
        }

        public GuestRequest Ibl.CheckGuestRequest(int key)
        {
            throw new NotImplementedException();
        }

        public HostingUnit CheckHostingUnit(int key)
        {
            throw new NotImplementedException();
        }

        public Order CheckOrder(int key)
        {
            throw new NotImplementedException();
        }

        public void Ibl.DeleteHostingUnit(HostingUnit unit)
        {
            if (קיימת הזמנה פתוחה)
               throw new Exception("Unable to delete hosting unit");
            IDAL.DeleteHostingUnit(unit);
        }

        public List<BankBranch> GetBankBranchList()
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> GetGuestRequestList()
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> GetHostingUnitList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderList()
        {
            throw new NotImplementedException();
        }

        public void Ibl.UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            IDAL.UpdateGuestRequest(request, status);
        }

        public void Ibl.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            IDAL.UpdateHostingUnit(unit, diary);
        }

        public void UpdateOrder(ref Order order, Enums.Status status)
        {
            if (!order.HostingUnitKey.owner.collectionClearance)
                throw new Exception("אין הרשאה");
            if (order.Status == Enums.Status.Treated)
                throw new Exception("Order already closed");
            if (status == Enums.Status.MailSent)
                //print
                if (status == Enums.Status.Treated)
                {
                    //amla
                    //matriza
                    //statuses
                }
            IDAL.UpdateOrder(order, status);
        }
        public List<HostingUnit> Ibl.AvailableHostingUnits(DateTime date, int n)
        {

        }
        public int Ibl.NumberOfDays(DateTime date1, DateTime date2 = 0)
        {
            if (date2 == 0)
                return Math.Abs(DateTime.Now - date1);
            return Math.Abs(date1 - date2);
        }
        public List<Order> Ibl.NumberOfOrders(int days)
        {

        }
        public List<GuestRequest> Ibl.Requests()
        {

        }
        public int Ibl.NumberOfInvites(GuestRequest request)
        {

        }
        public int Ibl.NumberOfInvites(HostingUnit unit)
        {

        }


    }


}