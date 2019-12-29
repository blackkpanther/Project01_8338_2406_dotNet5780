using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {  
      //Singleton
        private static Dal_imp instance;

        public static Dal_imp Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dal_imp();
                return instance;
            }
        }

        private Dal_imp() { }
    

        void Idal.AddGuestRequest(GuestRequest request)
        {
            if (CheckGuestRequest(request.GuestRequestKey))
                throw new /*DuplicateRequest*/Exception("Request already submitted");
            DataSource.GuestRequestList.Add(request.Clone());
        }

        void Idal.UpdateGuestRequest(ref GuestRequest request, Enums.Status status)
        {
            request.Status = status;
        }

        void Idal.AddHostingUnit(HostingUnit unit)
        {
            if (CheckHostingUnit(unit.HostingUnitKey))
                throw new /*DuplicateUnit*/Exception("Hosting unit already added");
            DataSource.HostingUnitList.Add(unit.Clone());
        }

        void Idal.UpdateHostingUnit(ref HostingUnit unit, bool[,] diary)
        {
            if (diary.Length != 12 * 31)
                throw new /*WrongDiary*/Exception("Wrong format for diary");
            unit.Diary = diary;
        }
        void Idal.DeleteHostingUnit(HostingUnit unit)
        {
            if (!CheckHostingUnit(unit.HostingUnitKey))
                throw new /*NonExistingUnit*/Exception("Hosting unit does not exist");
            DataSource.HostingUnitList.RemoveAll(item => item.HostingUnitKey == unit.HostingUnitKey);
        }
        void Idal.AddOrder(Order order)
        {
            if (CheckOrder(order.OrderKey))
                throw new /*DuplicateOrder*/Exception("Orderalready submitted");
            DataSource.OrderList.Add(order.Clone());
        }

        void Idal.UpdateOrder(ref Order order, Enums.Status status)
        {
            order.Status = status;
        }

        List<HostingUnit> Idal.GetHostingUnitList()
        {
            return DataSource.HostingUnitList.Select(item => item).ToList();
        }

        List<GuestRequest> Idal.GetGuestRequestList()
        {
            return DataSource.GuestRequestList.Select(item => item).ToList();
        }

        List<Order> Idal.GetOrderList()
        {
            return DataSource.OrderList.Select(item => item).ToList();
        }
        List<BankBranch> Idal.GetBankBranchList()
        {
            return DataSource.BankBranchList.Select(item => item).ToList();
        }
        GuestRequest Idal.CheckGuestRequest(int key)
        {
            return DataSource.GuestRequestList.Find(item => item.GuestRequestKey == key);
        }
        HostingUnit Idal.CheckHostingUnit(int key)
        {
            return DataSource.HostingUnitList.Find(item => item.HostingUnitKey == key);
        }
        Order Idal.CheckOrder(int key)
        {
            return DataSource.OrderList.Find(item => item.OrderKey == key);
        }
    }
}
