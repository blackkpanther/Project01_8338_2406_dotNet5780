using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        private long hostingUnitKey;
        private long guestRequestKey;
        private long orderKey;
        private Enums.Status status;
        private DateTime createDate;
        private DateTime orderDate;
        private DateTime emailSent;//*date email was sent to client
        private long fee; // * הצעת מחיר
        //properties
        public long HostingUnitKey
        {
            get { return hostingUnitKey; }
            set { hostingUnitKey = value; }
        }
        public long GuestRequestKey
        {
            get { return guestRequestKey; }
            set { guestRequestKey = value; }
        }
        public long OrderKey
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
        public  DateTime EmailSent
            {
get{return emailSent;}
            set{emailSent=value;}
}
        public long Fee
     {
get{return fee;}
            set{fee=value;}
            }

        //printing method
        public override string ToString()
        {
            return "Hosting unit key: " + this.hostingUnitKey + " Guest request key: " + this.guestRequestKey + " Order key: " + this.orderKey + " Order status: " + this.status + " Date order was created: " + this.CreateDate + " Date Email was sent to client: " + this.OrderDate;
        }
        public Order() { }
    }
}
