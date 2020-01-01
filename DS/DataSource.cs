using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DS
{
    public class DataSource
    {
        public static List<Order> OrderList = new List<Order>();

        public static List<GuestRequest> GuestRequestList = new List<GuestRequest>();

        public static List<HostingUnit> HostingUnitList = new List<HostingUnit>();

        public static List<BankBranch> BankBranchList = new List<BankBranch>();

        public static List<Host> HostList=new List<Host>();
      
  public DataSource()
        {
            OrderList = new List<Order>();

            GuestRequestList = new List<GuestRequest>();

            HostingUnitList = new List<HostingUnit>();

            BankBranchList = new List<BankBranch>();

            HostList=new List<Host>();
        }
                     
    }
}
