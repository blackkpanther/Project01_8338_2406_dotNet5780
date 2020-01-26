using BE;
using System.Collections.Generic;

namespace DS
{
    public class DataSource
    {
        public static List<Order> OrderList = new List<Order>();

        public static List<Guest> GeustList = new List<Guest>();
        public static List<GuestRequest> GuestRequestList = new List<GuestRequest>();

        public static List<HostingUnit> HostingUnitList = new List<HostingUnit>();

        public static List<BankBranch> BankBranchList = new List<BankBranch>();

        public static List<Host> HostList = new List<Host>();

        public DataSource()
        {
            OrderList = new List<Order>();
            GeustList = new List<Guest>();
            GuestRequestList = new List<GuestRequest>();

            HostingUnitList = new List<HostingUnit>();

            BankBranchList = new List<BankBranch>();

            HostList = new List<Host>();
        }

    }
}
