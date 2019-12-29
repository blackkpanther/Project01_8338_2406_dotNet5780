using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        private int hostingUnitKey;
        private int guestRequestKey;
        private int orderKey;
        private Enums.Status status;
        private DateTime createDate;
        private DateTime orderDate;
        //properties
        public int HostingUnitKey
        {
            get { return hostingUnitKey; }
            set { hostingUnitKey = value; }
        }
        public int GuestRequestKey
        {
            get { return guestRequestKey; }
            set { guestRequestKey = value; }
        }
        public int OrderKey
        {
            get { return orderKey; }
            set { orderKey = value; }
        }
        public Enums.Status Status
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        //printing method
        public override string ToString()
        {
            return "Hosting unit key: " + this.hostingUnitKey + " Guest request key: " + this.guestRequestKey + " Order key: " + this.orderKey + " Order status: " + this.status + " Date order was created: " + this.CreateDate + " Date Email was sent to client: " + this.OrderDate;
        }
        public Order() { }
    }
}
