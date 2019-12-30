using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BE
{
   public class Configuration
    {
        public const int NumOfDaysInMonth = 31;
        public const int NumOfMonthsInYear = 12;

        private static int serialBankNumber = 10;
        private static long serialGuestRequestKey = 10000000;
        private static long serialHostKey = 10000000;
        private static long serialHostingUnitKey = 10000000;
        private static long serialOrderKey = 20000000;

        public static int GetNewSerialBankNumber() { return serialBankNumber++; }
        public static long GetNewSerialGuestRequestKey() { return serialGuestRequestKey++; }
        public static long GetNewSerialHostKey() { return serialHostKey++; }
        public static long GetNewSerialHostingUnitKey() { return serialHostingUnitKey++; }
        public static long GetNewSerialOrderKey() { return serialOrderKey++; }


    }
}
