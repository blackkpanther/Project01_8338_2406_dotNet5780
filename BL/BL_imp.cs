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

        public void AddGuestRequest(GuestRequest request)
        {
            if (request.EntryDate >= request.ReleaseDate)


                throw new NotImplementedException();
        }

        public void AddHostingUnit(HostingUnit unit)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> AvailableHostingUnits(DateTime date, int n)
        {
            throw new NotImplementedException();
        }

        public GuestRequest CheckGuestRequest(int key)
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

        public void DeleteHostingUnit(HostingUnit unit)
        {
            throw new NotImplementedException();
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

        public int NumberOfDays(DateTime date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public int NumberOfDays(DateTime date)
        {
            throw new NotImplementedException();
        }

        public int NumberOfInvites(GuestRequest request)
        {
            throw new NotImplementedException();
        }

        public int NumberOfInvites(HostingUnit unit)
        {
            throw new NotImplementedException();
        }

        public List<Order> NumberOfOrders(int days)
        {
            throw new NotImplementedException();
        }

        public List<GuestRequest> Requests()
        {
            throw new NotImplementedException();
        }

        public void UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            throw new NotImplementedException();
        }

        public void UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(ref Order order, Enums.Status status)
        {
            throw new NotImplementedException();
        }
    }
}
