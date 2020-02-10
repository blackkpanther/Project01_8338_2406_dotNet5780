using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE
{
    public class Configuration
    {
        public const int NumOfDaysInMonth = 31;
        public const int NumOfMonthsInYear = 12;

        public static long serialGuestKey { get; set; } = 10000000;
        public static int serialBankNumber { get; set; } = 10;
        public static long serialGuestRequestKey { get; set; } = 10000000;
        public static long serialHostKey { get; set; } = 10000000;
        public static long serialHostingUnitKey { get; set; } = 10000000;
        public static long serialOrderKey { get; set; } = 20000000;
        public static double serviceCharge { get; set; } = 0.2;//עמלה

        public static int GetNewSerialBankNumber() { return serialBankNumber++; }
        public static long GetNewSerialGuestRequestKey() { return serialGuestRequestKey++; }
        public static long GetNewSerialGuestKey() { return serialGuestRequestKey++; }
        public static long GetNewSerialHostKey() { return serialHostKey++; }
        public static long GetNewSerialHostingUnitKey() { return serialHostingUnitKey++; }
        public static long GetNewSerialOrderKey() { return serialOrderKey++; }
        public static double GetServiceCharge() { return serviceCharge; }

    }
}
